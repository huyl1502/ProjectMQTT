using System.Collections.Generic;
using System.Windows.Controls;
using FDM = FireDetect.AppModels;

namespace FireDetect.Views.Apartment
{
    class Manage : BaseView<ManageForm, List<FDM.Apartment>>
    {
        protected override void RenderCore()
        {
            MainContent.DataContext = Model;
        }
    }
}
