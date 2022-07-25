using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vst.Server.Data;
using FireDetect.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading;

namespace FireDetect.Controllers
{
    class ApartmentController : BaseController
    {
        public object Manage()
        {
            var context = ServerContext.ParseObject<JObject>();
            var buildingId = context["BuildingId"].ToString();
            var building = FireDetectionDb.Buildings.Find<Building>(buildingId);
            var lstApartmentId = building.ApartmentsId;

            var lstApartment = new List<Apartment>();
            foreach(var apartmentId in lstApartmentId)
            {
                lstApartment.Add(FireDetectionDb.Apartments.Find<Apartment>(apartmentId));
            }

            //var buildingId = i["BuildingId"].ToString();
            //var floorNumber = (int)i["FloorNumber"];
            //var apartmentNumber = (int)i["ApartmentNumber"];

            //var b = FireDetectionDb.Buildings.Find<Models.Building>(buildingId);
            //var rs = new JObject();

            //foreach(var f in b.Floors)
            //{
            //    if (f.Number == floorNumber)
            //    {
            //        foreach (var a in f.Apartments)
            //        {
            //            if (a.Number == apartmentNumber)
            //            {
            //                rs.Add(new JProperty("Apartment", JToken.FromObject(a)));
            //                rs.Add("BuildingId", buildingId);
            //                return Response(rs);
            //            }
            //        }
            //    }
            //}

            return Response(lstApartment);
        }

        public object Detail()
        {
            var context = ServerContext.ParseObject<JObject>();
            var apartmentId = context["ApartmentId"].ToString();
            var indexs = FireDetectionDb.Indexs.Find<IndexCollection>(apartmentId);

            foreach (var item in indexs.Indexs.ToList())
            {
                var rsIndex = new List<Index>();
                var lstIndex = (List<Index>)item.Value;
                //var count = lstIndex.Count() - 1;

                //if(count >= 3)
                //{
                //    for (int i = 0; i < 4; i++)
                //    {
                //        rsIndex.Add(lstIndex[count - i]);
                //    }
                //    indexs.Indexs[item.Key] = rsIndex;
                //}
                rsIndex.Add(lstIndex.Last<Index>());
                indexs.Indexs[item.Key] = rsIndex;
            }

            return Response(indexs);
        }

        public void Update()
        {
            var context = ServerContext.ParseObject<JObject>();
            var apartmentId = context["ApartmentId"].ToString();
            var indexs = JsonConvert.DeserializeObject<Dictionary<string, Index>>(context["Indexs"].ToString());
            var indexCollection = FireDetectionDb.Indexs.Find<IndexCollection>(apartmentId);

            indexCollection.Indexs["Temp"].Add(indexs["Temp"]);
            indexCollection.Indexs["Gas"].Add(indexs["Gas"]);
            indexCollection.Indexs["Humidity"].Add(indexs["Humidity"]);
            indexCollection.Indexs["Smoke"].Add(indexs["Smoke"]);

            FireDetectionDb.Indexs.Update(apartmentId, indexCollection);
        }
    }
}
