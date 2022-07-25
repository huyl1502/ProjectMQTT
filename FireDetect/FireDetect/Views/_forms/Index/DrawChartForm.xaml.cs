using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using FDM = FireDetect.AppModels;

namespace FireDetect.Views.Index
{
    /// <summary>
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class DrawChartForm : Window
    {
        public DrawChartForm()
        {
            InitializeComponent();

            this.Loaded += (s, e) =>
            {
                var dt = (FDM.IndexCollection)this.DataContext;
                var indexList = dt.Indexs.Values.First<List<FDM.Index>>();
                var labels = new List<string>();

                var line = new LineSeries
                {
                    Title = indexList[0].Name,
                    Values = new ChartValues<int> { },
                    Stroke = (SolidColorBrush)new BrushConverter().ConvertFrom("#333399"),
                    Fill = Brushes.Transparent,
                };
                foreach (var i in indexList)
                {
                    labels.Add(string.Format("{0:T}", i.TimeMeasure));
                    line.Values.Add(i.Value);
                }
                SeriesCollection = new SeriesCollection { line };

                //Labels = labels.ToArray();
                Labels = labels;

                YFormatter = value => value.ToString();

                chart.SetBinding(CartesianChart.SeriesProperty, new Binding("SeriesCollection")
                {
                    Source = this
                });
                YAxis.SetBinding(Axis.LabelFormatterProperty, new Binding("YFormatter")
                {
                    Source = this
                });
                XAxis.SetBinding(Axis.LabelsProperty, new Binding("Labels")
                {
                    Source = this
                });
            };

            this.Closing += (s, e) =>
            {
                App.Execute("index/chartclosing");
            };
        }
        public SeriesCollection SeriesCollection { get; set; }
        public List<string> Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        //private void Back_Clicked(object sender, EventArgs e)
        //{
        //    var ic = (FDM.IndexCollection)this.DataContext;
        //    var dt = new DataContext();
        //    dt.SetString("ApartmentId", ic.ApartmentId);
        //    App.Execute("apartment/detail", dt);
        //}
    }
}
