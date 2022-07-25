namespace System.Windows.Controls
{
    public abstract class BaseView<TView, TModel> : IAppView
        where TView : UIElement, new()
    {
        public virtual object[] GetActions() { return new object[] { }; }
        public System.Mvc.ViewDataDictionary ViewBag { get; set; }
        protected TView MainContent { get; private set; }
        protected TModel Model { get; private set; }
        protected TView CreateMainContent()
        {
            return new TView();
        }
        public object Content { get => MainContent; }
        public virtual void Dispose() { }

        public void Render(object model)
        {
            Model = (TModel)model;
            MainContent = CreateMainContent();

            RenderCore();
        }
        protected abstract void RenderCore();
        public virtual string MainCaption => null;
        public virtual string ControllerName => (string)ViewBag["controller"];
    }
    public class MyListView<TContent, TModel> : UserControl
        where TContent : UserControl, new()
    {
        public event Action<TModel> ItemSelected;
        public MyListView()
        {
            Content = new TContent();
            var lstView = (DataGrid)((TContent)Content).Content;
            lstView.MouseDoubleClick += (s, e) =>
            {
                var context = ((FrameworkElement)e.OriginalSource).DataContext;
                if (context != null) { ItemSelected?.Invoke((TModel)context); }
            };
        }
        public void Binding(object data)
        {
            var lstView = (DataGrid)((TContent)Content).Content;
            this.Dispatcher.InvokeAsync(() =>
            {
                lstView.ItemsSource = null;
                lstView.ItemsSource = (System.Collections.IEnumerable)data;
            });
        }
    }
}
