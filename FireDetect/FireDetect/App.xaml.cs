using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using uPLibrary.Networking.M2Mqtt;

namespace FireDetect
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();
        static public void Execute(string url, params object[] args)
        {
            System.Mvc.Engine.Execute(url, args);
        }

        public static Window IsActiveWindow
        {
            //get {
            //    return App.Current.Windows.OfType<Window>().SingleOrDefault(w => w.IsActive);
            //}
            get; set;
        }

        public App()
        {
            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();

            object currentView = null;
            var layout = new MainLayout();

            System.Mvc.Engine.Register(this, result =>
            {
                var view = result?.View;

                if (view.Content is Window)
                {
                    currentView = view;
                    IsActiveWindow = (Window)view.Content;
                    ((Window)view.Content).ShowDialog();
                    return;
                }

                if (layout.UpdateView((IAppView)view))
                {
                    ((IDisposable)currentView)?.Dispose();
                    currentView = view;
                    //if (!MainWindow.IsActive)
                    //{
                    //    MainWindow.ShowDialog();
                    //}
                }
            });

            MainWindow = new Window
            {
                Content = layout,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                Title = "Hệ thống cảnh báo cháy"
            };

            App.Execute("home/default");
        }

        protected override void OnExit(ExitEventArgs e)
        {
            System.Mvc.Engine.Exit();
            base.OnExit(e);
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            if(now.Hour == 0 && now.Minute == 0 && now.Second == 0)
            {
                Console.WriteLine("a");
            }
            //Clock.Content = String.Format("{0:MM/dd/yyyy HH:mm:ss}", d);
            App.Execute("building/statistical", new object { });
        }
    }
}

