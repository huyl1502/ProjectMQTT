using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Controls;

namespace FireDetect.Controllers
{
    internal class HomeController : BaseController
    {
        public void Default()
        {
            if (Client.IsConnected) {}
            App.Execute("account/login");
        }

        public void Index()
        {
            App.Execute("building/manage");
        }

        public object ChartSample()
        {
            return View();
        }
    }
}
