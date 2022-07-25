using System;
using System.Windows.Controls;
using System.Windows.Data;
using FDM = FireDetect.AppModels;

namespace FireDetect.Views.Apartment
{
    /// <summary>
    /// Interaction logic for ManageForm.xaml
    /// </summary>
    public partial class ManageForm : UserControl
    {
        public ManageForm()
        {
            InitializeComponent();

            lstView.Content.SetBinding(DataGrid.ItemsSourceProperty, new Binding("DataContext")
            {
                Source = this
            });

            lstView.Content.MouseDoubleClick += (s, e) =>
            {
                if (lstView.Content.SelectedItem != null)
                {
                    var selectedApartment = lstView.Content.SelectedItem as FDM.Apartment;
                    
                    App.Execute("apartment/detail", selectedApartment.ID);
                }
            };
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            App.Execute("building/manage");
        }
    }
}
