namespace TabControlRepro.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public StackOverflowViewModel StackOverflow { get; } = new StackOverflowViewModel();
    }
}
