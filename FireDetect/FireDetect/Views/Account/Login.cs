using Models;
using System.Windows.Controls;

namespace FireDetect.Views.Account
{
    public class Login : BaseView<LoginForm, LoginInfo>
    {
        protected override void RenderCore()
        {
            MainContent.DataContext = Model;
        }
    }
}
