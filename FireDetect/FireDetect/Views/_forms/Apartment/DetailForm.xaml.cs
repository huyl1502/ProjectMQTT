using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using FDM = FireDetect.AppModels;

namespace FireDetect.Views.Apartment
{
    /// <summary>
    /// Interaction logic for DetailForm.xaml
    /// </summary>
    public partial class DetailForm : UserControl
    {
        public DetailForm()
        {
            InitializeComponent();

            this.Loaded += (s, e) =>
            {
                var indexCollection = (FDM.IndexCollection)this.DataContext;
                var dataDictionary = indexCollection.Indexs;
                var dataSource = new List<FDM.Index>();

                dataSource.Add(dataDictionary["Temp"].Last<FDM.Index>());
                dataSource.Add(dataDictionary["Humidity"].Last<FDM.Index>());
                dataSource.Add(dataDictionary["Gas"].Last<FDM.Index>());
                dataSource.Add(dataDictionary["Smoke"].Last<FDM.Index>());

                lstView.Content.SetBinding(DataGrid.ItemsSourceProperty, new Binding()
                {
                    Source = dataSource
                });
            };

            lstView.Content.MouseDoubleClick += (s, e) =>
            {
                if (lstView.Content.SelectedItem != null)
                {
                    var indexCollection = (FDM.IndexCollection)this.DataContext;
                    var selectedIndex = lstView.Content.SelectedItem as FDM.Index;
                    //var drawindexs = indexCollection.Indexs[selectedIndex.Name].ToArray();

                    //var dt = new DataContext();
                    //dt.SetString("ApartmentId", indexCollection.ApartmentId);
                    //dt.SetString("IndexName", selectedIndex.Name);
                    //dt.Push("Indexs", drawindexs.ToList());

                    App.Execute("index/manage", indexCollection.ApartmentId, selectedIndex.Name);
                }
            };
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            var indexCollection = (FDM.IndexCollection)this.DataContext;
            //var dt = new DataContext();
            //dt.SetString("BuildingId", indexCollection.BuildingId);
            App.Execute("apartment/manage", indexCollection.BuildingId);
        }
    }
}
