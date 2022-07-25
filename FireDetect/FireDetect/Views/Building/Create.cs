using System.Windows.Controls;

namespace FireDetect.Views.Building
{
    class Create : BaseView<CreateForm, object>
    {
        protected override void RenderCore()
        {
            MainContent.DataContext = Model;
        }
    }
}