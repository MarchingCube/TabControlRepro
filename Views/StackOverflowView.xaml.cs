using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TabControlRepro.Views
{
    public class StackOverflowView : UserControl
    {
        public StackOverflowView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}