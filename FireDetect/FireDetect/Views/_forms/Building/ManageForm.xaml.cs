using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using FDM = FireDetect.AppModels;

namespace FireDetect.Views.Building
{
    /// <summary>
    /// Interaction logic for Manage.xaml
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

            lstView.Content.SelectedCellsChanged += (s, e) =>
            {
                deleteButton.Visibility = Visibility.Visible;
            };

            lstView.Content.MouseDoubleClick += (s, e) =>
            {
                if (lstView.Content.SelectedItem != null)
                {
                    var selectedBuilding = lstView.Content.SelectedItem as FDM.Building;
                    App.Execute("building/detail", selectedBuilding);
                }
            };
        }
        private void Create_Clicked(object sender, EventArgs e)
        {
            App.Execute("building/create");
        }
        private void Refresh_Clicked(object sender, EventArgs e)
        {
            App.Execute("building/manage");
        }
        private void Delete_Building(FDM.Building b)
        {
            App.Execute("building/delete", b);
        }
        private void Delete_Clicked(object sender, EventArgs e)
        {
            if (MyMessageBox.Confirm("Chắc chắn xóa bản ghi?") == true)
            {
                Delete_Building((FDM.Building)lstView.Content.SelectedItem);
            }
        }
    }
}
