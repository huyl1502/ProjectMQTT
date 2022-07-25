namespace System.Windows
{
    public interface IAppView : IDisposable, System.Mvc.IView
    {
        object[] GetActions();
        string MainCaption { get; }
    }
}
