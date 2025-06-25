using System.Windows;
using System.Windows.Controls;

namespace fleet_manager_hmi.Components.FormFields
{
    /// <summary>
    /// Logica di interazione per text_box.xaml
    /// </summary>
    public partial class text_box : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(text_box));
        public static readonly DependencyProperty InputTextProperty = DependencyProperty.Register("InputText", typeof(string), typeof(text_box));
        public static readonly DependencyProperty MexOkProperty = DependencyProperty.Register("MexOk", typeof(string), typeof(text_box));
        public static readonly DependencyProperty MexFailProperty = DependencyProperty.Register("MexFail", typeof(string), typeof(text_box));
        
        public text_box()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public string InputText
        {
            get { return (string)GetValue(InputTextProperty); }
            set { SetValue(InputTextProperty, value); }
        }

        public string MexOk
        {
            get { return (string)GetValue(MexOkProperty); }
            set { SetValue(MexOkProperty, value); }
        }

        public string MexFail
        {
            get { return (string)GetValue(MexFailProperty); }
            set { SetValue(MexFailProperty, value); }
        }
    }
}
