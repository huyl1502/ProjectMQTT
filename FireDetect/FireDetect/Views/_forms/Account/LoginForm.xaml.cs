using System;
using System.Windows;
using System.Windows.Media;

namespace FireDetect.Views.Account
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();

            FontFamily = new FontFamily("Calibri");
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            App.Execute("account/login", new Models.LoginInfo { UserName = un.Text, Password = pw.Password });
        }
    }
}
