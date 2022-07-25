using FireDetect.AppModels;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Mvc;
using System.Windows;
using System.Windows.Controls;
using JC = Newtonsoft.Json.JsonConvert;

namespace FireDetect.Controllers
{
    class ResponseController : BaseController
    {
        public void Default()
        {
            var action = GetMethod(Response.Pop<string>("Action"));
            System.Console.WriteLine(action.ToString());

            Engine.BeginInvoke(() =>
            {
                action.Invoke(this, new object[] { });
            });
        }

        public void user_login()
        {
            var v = JObject.Parse(JC.SerializeObject(Response.Pop<object>("Value")));
            var token = v["Token"];

            if (token == null)
            {
                Token = null;
            }
            else
            {
                Token = token.ToString();
            }

            App.Current.Dispatcher.InvokeAsync(() =>
            {
                App.IsActiveWindow.Close();
                App.Current.Dispatcher.InvokeAsync(() =>
                {
                    App.Current.MainWindow.Visibility = Visibility.Visible;
                });
                App.Execute("home/index");
            });
        }

        public void building_create()
        {
            //var code = Response.Pop<object>("Code");

            //if ((bool)code)
            //{
            //    var msg = Response.Pop<string>("Message");
            //    App.Current.Dispatcher.InvokeAsync(() =>
            //    {
            //        if (MyMessageBox.Alert(msg) == true) { }
            //    });
            //}

            var msg = Response.Pop<string>("Message");
            App.Current.Dispatcher.InvokeAsync(() =>
            {
                if(MyMessageBox.Alert(msg) == true)
                {
                    App.Execute("building/manage");
                }
            });
        }

        public void building_delete()
        {
            //var code = Response.Pop<object>("Code");

            //if ((bool)code)
            //{
            //    var msg = Response.Pop<string>("Message");
            //    App.Current.Dispatcher.InvokeAsync(() =>
            //    {
            //        if (MyMessageBox.Alert(msg) == true) { }
            //    });
            //}

            var msg = Response.Pop<string>("Message");
            App.Current.Dispatcher.InvokeAsync(() =>
            {
                if (MyMessageBox.Alert(msg) == true)
                {
                    App.Execute("building/manage");
                }
            });
        }

        public void building_getall()
        {
            var v = ConvertArray<List<Building>>(Response["Value"]);
            App.Current.Dispatcher.InvokeAsync(() =>
            {
                App.Execute("building/manage", v);
            });
        }

        public void user_logout()
        {
            App.Current.Dispatcher.InvokeAsync(() =>
            {
                App.Current.MainWindow.Visibility = Visibility.Hidden;
                App.Execute("account/login");
            });
        }

        public void apartment_manage()
        {
            var v = ConvertArray<List<Apartment>>(Response["Value"]);
            App.Current.Dispatcher.InvokeAsync(() =>
            {
                App.Execute("apartment/manage", v);
            });
        }

        public void apartment_detail()
        {
            //var v = ConvertDictionary<Dictionary<string, List<Index>>>(Response["Value"]);
            var v = JC.DeserializeObject<IndexCollection>(Response["Value"].ToString());

            App.Current.Dispatcher.InvokeAsync(() =>
            {
                App.Execute("apartment/detail", v);
            });
        }

        public void index_updatechart()
        {
            var v = GetValue<Index>(Response["Value"]);
            App.Current.Dispatcher.InvokeAsync(() =>
            {
                //var layout = ((Border)((MainLayout)App.Current.MainWindow.Content).main_content).Child;
                //if(layout is FireDetect.Views.Index.DrawChartForm)
                //{
                //    ((FireDetect.Views.Index.DrawChartForm)layout).SeriesCollection[0].Values.RemoveAt(0);
                //    ((FireDetect.Views.Index.DrawChartForm)layout).Labels.RemoveAt(0);
                //    ((FireDetect.Views.Index.DrawChartForm)layout).SeriesCollection[0].Values.Add(v.Value);
                //    ((FireDetect.Views.Index.DrawChartForm)layout).Labels.Add(string.Format("{0:T}", v.TimeMeasure));
                //}
                var w = (FireDetect.Views.Index.DrawChartForm)App.IsActiveWindow;

                w.SeriesCollection[0].Values.RemoveAt(0);
                w.Labels.RemoveAt(0);
                w.SeriesCollection[0].Values.Add(v.Value);
                w.Labels.Add(string.Format("{0:T}", v.TimeMeasure));
            });
        }

        public void index_manage()
        {
            var v = JC.DeserializeObject<IndexCollection>(Response["Value"].ToString());
            App.Current.Dispatcher.InvokeAsync(() =>
            {
                App.Execute("index/drawchart", v);
            });
        }

        public void simulation_start()
        {
            var v = ConvertArray<List<Apartment>>(Response["Value"]);
            App.Current.Dispatcher.InvokeAsync(() =>
            {
                App.Execute("simulation/start", v);
            });
        }
    }
}
