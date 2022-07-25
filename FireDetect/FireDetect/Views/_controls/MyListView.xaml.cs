using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace System.Windows.Controls
{
    /// <summary>
    /// Interaction logic for MyListView.xaml
    /// </summary>
    public partial class MyListView : UserControl
    {
        public MyListView()
        {
            InitializeComponent();

            Content.Loaded += (s, e) =>
            {
                foreach (DataGridColumn column in Content.Columns)
                {
                    column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
                }
            };
        }

        private void Dg_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            var pd = (PropertyDescriptor)e.PropertyDescriptor;
            var da = (DisplayAttribute)pd.Attributes[typeof(DisplayAttribute)];
            var dn = (DisplayNameAttribute)pd.Attributes[typeof(DisplayNameAttribute)];

            if (da == null) return;

            var autoGenerateField = da.GetAutoGenerateField();
            if (autoGenerateField != null && !autoGenerateField.Value)
            {
                e.Cancel = true;
            }

            if (!string.IsNullOrEmpty(dn.DisplayName))
            {
                e.Column.Header = dn.DisplayName;
            }
        }
    }
}
