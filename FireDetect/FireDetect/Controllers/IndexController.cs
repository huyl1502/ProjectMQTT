using FireDetect.AppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace FireDetect.Controllers
{
    class IndexController : BaseController
    {
        static Thread trd;

        public void Manage(string apartmentId, string indexName)
        {
            var dt = new DataContext();
            dt.SetString("ApartmentId", apartmentId);
            dt.SetString("IndexName", indexName);
            Publish("firedetection", "index/manage", dt);
        }

        public object DrawChart(IndexCollection ic)
        {
            App.Execute("index/getnewestindex", ic);
            return View(ic);
        }

        public void GetNewestIndex(IndexCollection ic)
        {
            var apartmentId = ic.ApartmentId;
            var dt = new DataContext();
            dt.SetString("ApartmentId", apartmentId);
            dt.SetString("IndexName", ic.Indexs.Keys.First());
            trd = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    Publish("firedetection", "index/updatechart", dt);
                    Thread.Sleep(5000);
                }
            }));
            trd.Name = apartmentId;
            trd.IsBackground = true;
            trd.Start();
        }

        public void ChartClosing()
        {
            trd.Abort();
        }
    }
}
