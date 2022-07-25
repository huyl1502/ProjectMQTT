using System.Collections.Generic;
using System.Windows.Controls;
using FDM = FireDetect.AppModels;
using System;

namespace FireDetect.Views.Index
{
    public class DrawChart : BaseView<DrawChartForm, FDM.IndexCollection>
    {
        protected override void RenderCore()
        {
            MainContent.DataContext = Model;
        }
    }
}
