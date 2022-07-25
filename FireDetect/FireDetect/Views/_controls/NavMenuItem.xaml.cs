namespace System.Windows.Controls
{
    /// <summary>
    /// Interaction logic for NavMenuItem.xaml
    /// </summary>
    public partial class NavMenuItem : UserControl
    {
        new UIElement Background => (UIElement)((Grid)this.Content).Children[0];
        public NavMenuItem()
        {
            InitializeComponent();

            this.MouseMove += (s, e) => Background.Visibility = Visibility.Visible;
            this.MouseLeave += (s, e) => Background.Visibility = Visibility.Hidden;

            this.MouseLeftButtonUp += (s, e) =>
            {
                if (string.IsNullOrEmpty(Url) == false)
                {
                    System.Mvc.Engine.Execute(Url);
                }
            };
        }

        public string Text
        {
            get => caption.Text;
            set => caption.Text = value;
        }

        public string Url { get; set; }
    }
}
