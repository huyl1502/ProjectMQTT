using System;
using System.Collections.Generic;
using FDM = FireDetect.AppModels;

namespace FireDetect.Controllers
{
    class ApartmentController : BaseController
    {
        public void Manage(string buildingId)
        {
            var dt = new DataContext();
            dt.SetString("BuildingId", buildingId);
            Publish("firedetection", "apartment/manage", dt);
        }

        public object Manage(List<FDM.Apartment> lstApartment)
        {
            return View(lstApartment);
        }

        public void Detail(string apartmentId)
        {
            var dt = new DataContext();
            dt.SetString("ApartmentId", apartmentId);
            Publish("firedetection", "apartment/detail", dt);
        }

        public object Detail(FDM.IndexCollection ic)
        {
            return View(ic);
        }
    }
}
