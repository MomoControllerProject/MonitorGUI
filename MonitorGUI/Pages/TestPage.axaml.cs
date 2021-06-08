using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MonitorGUI.Pages
{
    public partial class TestPage : UserControl
    {
        public TestPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
