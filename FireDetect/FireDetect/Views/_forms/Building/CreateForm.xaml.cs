using System;
using System.Windows;
using FDM = FireDetect.AppModels;

namespace FireDetect.Views.Building
{
    /// <summary>
    /// Interaction logic for AddForm.xaml
    /// </summary>
    public partial class CreateForm : Window
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void Create_Clicked(object sender, EventArgs e)
        {
            var noFloor = Int32.Parse(no_floors.Text);
            var noApartmentPerFloor = Int32.Parse(no_apartment_per_floor.Text);

            var b = new FDM.Building { Name = name.Text, Address = address.Text, NoFloors = noFloor, NoApartments = (noFloor * noApartmentPerFloor) };

            App.Execute("building/create", b);
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            DialogResult = false;
        }
    }
}
