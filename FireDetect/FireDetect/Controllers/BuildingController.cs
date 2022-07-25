using FireDetect.AppModels;
using System;
using System.Collections.Generic;

namespace FireDetect.Controllers
{
    class BuildingController : BaseController
    {
        public void Manage()
        {
            Publish("firedetection", "building/getall", new object { });
        }

        public object Manage(List<Building> buildings)
        {
            return View(buildings);
        }

        public object Create()
        {
            return View();
        }

        public void Create(Building b)
        {
            Publish("firedetection", "building/create", b);
        }

        public void Delete(Building b)
        {
            Publish("firedetection", "building/delete", b);
        }

        public void Detail(Building b)
        {
            //var buildingId = new DataContext();
            //buildingId.SetString("BuildingId", b.ID);
            App.Execute("apartment/manage", b.ID);
        }

        public void Statistical()
        {

        }
    }
}
