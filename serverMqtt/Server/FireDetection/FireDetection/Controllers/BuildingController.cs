using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vst.Server.Data;

namespace FireDetect.Controllers
{
    class BuildingController : BaseController
    {
        public string GetID(Models.Building b)
        {
            return (b.Name + DateTime.Now.ToString()).ToMD5();
        }

        public object GetAll()
        {
            var lstBuilding = FireDetectionDb.Buildings.ToList<Models.Building>();
            return Response(lstBuilding);
        }

        public object Create()
        {
            var context = ServerContext.ParseObject<Models.Building>();

            var id = GetID(context);

            var NoFloors = context.NoFloors;
            var NoApartmentsPerFloor = context.NoApartments / context.NoFloors;

            for (int i = 1; i <= NoFloors; i++)
            {
                for (int j = 1; j <= NoApartmentsPerFloor; j++)
                {
                    var apartmentId = (string.Format("{0}-{1}", i, j) + context.Name + DateTime.Now.ToString()).ToMD5();
                    var apartment = new Models.Apartment { ID = apartmentId, BuildingId = id, Number = j, FloorNumber = i };
                    var indexCollection = new Models.IndexCollection { ApartmentId = apartmentId, BuildingId = id };

                    FireDetectionDb.Apartments.Insert(apartmentId, apartment);
                    FireDetectionDb.Indexs.Insert(apartmentId, indexCollection);

                    context.ApartmentsId.Add(apartmentId);
                }
            }
            var building = JObject.FromObject(context);

            FireDetectionDb.Buildings.Insert(id, building);

            return Response(0, "Tạo bản ghi thành công!", new object { });
        }

        public object Update()
        {
            var context = ServerContext.ParseObject<Models.Building>();

            var building = JObject.FromObject(context);
            FireDetectionDb.Buildings.Update(context.ID, building);

            return Response(0, "Cập nhật thành công!", new object { });
        }

        public object Delete()
        {
            var context = ServerContext.ParseObject<Models.Building>();

            foreach(var apartmentId in context.ApartmentsId)
            {
                FireDetectionDb.Indexs.Delete(apartmentId);
                FireDetectionDb.Apartments.Delete(apartmentId);
            }
            FireDetectionDb.Buildings.Delete(context.ID.ToString());

            return Response(0, "Đã xóa bản ghi!", new object { });
        }
    }
}
