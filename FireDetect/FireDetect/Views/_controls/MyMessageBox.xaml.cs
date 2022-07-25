namespace System.Windows.Controls
{
    /// <summary>
    /// Interaction logic for MyMessageBox.xaml
    /// </summary>
    public partial class MyMessageBox : Window
    {
        public MyMessageBox()
        {
            InitializeComponent();

            OK.Click += (s, e) =>
            {
                this.DialogResult = true;
            };
            Cancel.Click += (s, e) =>
            {
                this.Close();
            };
        }
        static public bool? Show(string text, string cancel, string ok)
        {
            var frm = new MyMessageBox();
            frm.Message.Text = text;

            if (!string.IsNullOrEmpty(cancel))
            {
                frm.Cancel.Text = cancel;
            }
            if (!string.IsNullOrEmpty(ok))
            {
                frm.OK.Text = ok;
            }
            return frm.ShowDialog();

        }
        static public bool? Alert(string text)
        {
            return Show(text, null, null);
        }
        static public bool? Confirm(string text)
        {
            return Show(text, "Hủy bỏ", "Đồng ý");
        }

    }
}
