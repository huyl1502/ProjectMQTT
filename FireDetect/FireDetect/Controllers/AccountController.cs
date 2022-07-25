using Models;

namespace FireDetect.Controllers
{
    class AccountController : BaseController
    {
        public object Login()
        {
            return View();
        }

        public void Login(LoginInfo u)
        {
            Publish("account", "user/login", u);
        }

        public void Logout()
        {
            Publish("account", "user/logout", new object { });
        }
    }
}
