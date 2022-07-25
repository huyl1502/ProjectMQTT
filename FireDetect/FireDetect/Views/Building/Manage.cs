using System.Collections.Generic;
using System.Windows.Controls;
using FDM = FireDetect.AppModels;

namespace FireDetect.Views.Building
{
    class Manage : BaseView<ManageForm, List<FDM.Building>>
    {
        protected override void RenderCore()
        {
            MainContent.DataContext = Model;
        }
    }
}