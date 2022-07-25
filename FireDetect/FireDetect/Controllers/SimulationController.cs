using System;
using System.Collections.Generic;
using System.Threading;
using FDM = FireDetect.AppModels;

namespace FireDetect.Controllers
{
    class SimulationController : BaseController
    {
        public FDM.Index RandomIndex(string name)
        {
            var unit = "";
            int value = 0;
            if (name == "Temp")
            {
                unit = "do C";
                value = new Random().Next(25, 35);
            }
            else if (name == "Humidity")
            {
                unit = "%";
                value = new Random().Next(20, 80);
            }
            else if (name == "Gas")
            {
                unit = "LPG";
                value = new Random().Next(1, 5);
            }
            else if (name == "Smoke")
            {
                unit = "Kg";
                value = new Random().Next(2, 10);
            }
            return new FDM.Index() { Name = name, Unit = unit, Value = value, TimeMeasure = DateTime.Now };
        }

        public void Start()
        {
            Publish("firedetection", "simulation/start", new object { });
        }

        public void Start(List<FDM.Apartment> lstApartments)
        {
            foreach (var apartment in lstApartments)
            {
                Thread trd = new Thread(new ThreadStart(() =>
                {
                    while (true)
                    {
                        var indexs = new Dictionary<string, FDM.Index>();
                        indexs["Temp"] = RandomIndex("Temp");
                        indexs["Humidity"] = RandomIndex("Humidity");
                        indexs["Gas"] = RandomIndex("Gas");
                        indexs["Smoke"] = RandomIndex("Smoke");

                        var dt = new DataContext();
                        dt.SetString("ApartmentId", apartment.ID);
                        dt.SetObject("Indexs", indexs);
                        Publish("firedetection", "apartment/update", dt);

                        Thread.Sleep(5000);
                    }
                }));
                trd.IsBackground = true;
                trd.Start();
            }
        }
    }
}
