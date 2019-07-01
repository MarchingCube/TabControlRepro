using Avalonia;
using Avalonia.Markup.Xaml;

namespace TabControlRepro
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}