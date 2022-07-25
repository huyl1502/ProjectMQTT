using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Controls;

namespace FireDetect.Views
{
    /// <summary>
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class ChartSampleForm : UserControl
    {
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();
        public ChartSampleForm()
        {
            InitializeComponent();

            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<int> { 4, 6, 5, 2 ,4 },
                    PointGeometrySize = 15,
                    
                },
            };

            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
            YFormatter = value => value.ToString("C");

            DataContext = this;
        }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        private void Timer_Click(object sender, EventArgs e)
        {
            //modifying any series values will also animate and update the chart
            SeriesCollection[0].Values.Add(new Random().Next(2, 10));
        }
    }
}
