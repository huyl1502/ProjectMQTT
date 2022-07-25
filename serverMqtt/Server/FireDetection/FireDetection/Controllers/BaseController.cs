using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vst.Server.Data;
using FireDetect.Models;

namespace FireDetect.Controllers
{
    class BaseController : Vst.Server.SlaveController
    {
        public static void CreateDb()
        {
            var bc = new BuildingController();
            bc.FireDetectionDb = new FireDetectionData(bc.MainDb.PhysicalPath);

            if(bc.FireDetectionDb.Buildings.Count() == 0)
            {
                var buildingId = ("building" + DateTime.Now.ToString()).ToMD5();
                var apartmentId = ("building" + DateTime.Now.ToString()).ToMD5();

                var temp = new Index { Name = "Temp", Value = 30, Unit = "do C", TimeMeasure = DateTime.Now };
                var gas = new Index { Name = "Gas", Value = 20, Unit = "LPG", TimeMeasure = DateTime.Now };
                var humidity = new Index { Name = "Humidity", Value = 60, Unit = "%", TimeMeasure = DateTime.Now };
                var smoke = new Index { Name = "Smoke", Value = 60, Unit = "Kg", TimeMeasure = DateTime.Now };
                var indexs = new Dictionary<string, List<Index>>();
                indexs.Add("Temp", new List<Index>() { temp });
                indexs.Add("Gas", new List<Index>() { gas });
                indexs.Add("Humidity", new List<Index>() { humidity });
                indexs.Add("Smoke", new List<Index>() { smoke });
                var owner = new Resident { Name = "admin", PhoneNumber = "0123456789" };

                var indexcollection = new IndexCollection { BuildingId = buildingId, ApartmentId = apartmentId, Indexs = indexs };
                var apartment = new Apartment { ID = apartmentId, BuildingId = buildingId, FloorNumber = 1, Number = 1, Owner = owner };
                var building = new Building { 
                    ID = buildingId, Name = "Sample", Address = "Address", NoFloors = 1, 
                    NoApartments = 1, ApartmentsId = new List<string>() { apartmentId } 
                };

                bc.FireDetectionDb.Indexs.Insert(apartmentId, indexcollection);
                bc.FireDetectionDb.Buildings.Insert(buildingId, building);
                bc.FireDetectionDb.Apartments.Insert(apartmentId, apartment);
            }
        }

    }
}
