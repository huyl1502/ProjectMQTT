using System.Windows.Media;
using System.Threading;

namespace System.Windows.Controls
{
    /// <summary>
    /// Interaction logic for MainLayout.xaml
    /// </summary>
    public partial class MainLayout : UserControl
    {
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();

        public MainLayout()
        {
            InitializeComponent();

            FontFamily = new FontFamily("Calibri");

            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();

            btnMenu.MouseLeftButtonUp += (s, e) =>
            {
                var col = splitPanel.ColumnDefinitions[0];
                col.Width = new GridLength(col.Width.Value == 0 ? col.MaxWidth : 0);
            };

            simulation.PreviewMouseLeftButtonUp += (s, e) =>
            {
                simulation.caption.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#990000");
                simulation.IsEnabled = false;
            };
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;

            Clock.Content = String.Format("{0:MM/dd/yyyy HH:mm:ss}", d);
        }

        public bool UpdateView(IAppView view)
        {
            var content = (UIElement)view.Content;
            if (content == null) { return false; }

            main_caption.Dispatcher.InvokeAsync(() =>
            {
                string caption = view.MainCaption?.ToUpper();
                if (!string.IsNullOrEmpty(caption))
                {
                    main_caption.Content = caption;
                }
            });

            actionMenu.Dispatcher.InvokeAsync(() =>
            {
                actionMenu.Children.Clear();
                foreach (UIElement e in view.GetActions())
                {
                    actionMenu.Children.Add(e);
                }
            });

            main_content.Dispatcher.InvokeAsync(() => {
                main_content.Child = content;
            });
            return true;
        }
    }
}
