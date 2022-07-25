using System.Windows.Controls;
using FDM = FireDetect.AppModels;

namespace FireDetect.Views.Apartment
{
    class Detail : BaseView<DetailForm, FDM.IndexCollection>
    {
        protected override void RenderCore()
        {
            MainContent.DataContext = Model;
        }
    }
}