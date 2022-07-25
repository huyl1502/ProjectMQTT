using System.Windows.Media;

namespace System.Windows.Controls
{
    /// <summary>
    /// Interaction logic for ActionButton.xaml
    /// </summary>
    public partial class ActionButton : UserControl
    {
        public string Url { get; set; }
        public string Text
        {
            get => caption.Text;
            set => caption.Text = value;
        }
        public Border content => (Border)base.Content;
        new public Brush Background
        {
            get => content.Background;
            set => content.Background = value;
        }
        new public Brush Foreground
        {
            get => base.Foreground;
            set
            {
                base.Foreground = value;

                content.BorderBrush = value;
                caption.Foreground = value;
            }
        }
        new public double Width
        {
            get => content.Width;
            set => content.Width = value;
        }
        public event EventHandler Click;
        public void Request(string url, params object[] args)
        {
            System.Mvc.Engine.Execute(url, args);
        }
        public ActionButton()
        {
            InitializeComponent();

            this.MouseLeftButtonUp += (s, e) =>
            {
                Click?.Invoke(this, null);
                if (Url != null) { Request(Url); }
            };
        }
    }

    public class CancelAction : ActionButton
    {
        public CancelAction()
        {
            Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#34344b");
            Text = "Đóng";
            caption.Padding = new Thickness(0, 10, 0, 10);
        }
    }

    public class LoginButton : ActionButton
    {
        public LoginButton()
        {
            Text = "Đăng nhập";
            Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#333399");
            caption.Padding = new Thickness(0, 10, 0, 10);
        }
    }

    public class RefreshAction : ActionButton
    {
        public RefreshAction()
        {
            Text = "Làm mới";
            Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#3c4043");
            caption.Padding = new Thickness(0, 10, 0, 10);
        }
    }

    public class CreateAction : ActionButton
    {
        public CreateAction()
        {
            Text = "Tạo mới";
            Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#00802b");
            caption.Padding = new Thickness(0, 10, 0, 10);
        }
    }

    public class PasteAction : ActionButton
    {
        public PasteAction(string actionName)
        {
            Text = "Clipboard";
            Foreground = Brushes.Orange;

            Click += (s, e) => Request("Import/" + actionName);
        }
    }
    public class DeleteAction : ActionButton
    {
        public DeleteAction()
        {
            Text = "Xóa";
            Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#990000");
            caption.Padding = new Thickness(0, 10, 0, 10);
            //Click += (s, e) => {
            //    if (MyMessageBox.Confirm("Chắc chắn xóa bản ghi?") == true)
            //    {
            //        Request(controllerName + "/Delete");
            //    }
            //};
        }
    }
    public class DeleteAllAction : ActionButton
    {
        public DeleteAllAction(string controllerName)
        {
            Text = "Xóa toàn bộ";
            Foreground = Brushes.Red;

            Click += (s, e) =>
            {
                if (MyMessageBox.Confirm("Chắc chắn xóa toàn bộ dữ liệu?") == true)
                {
                    Request(controllerName + "/clear");
                }
            };
        }
    }
}
