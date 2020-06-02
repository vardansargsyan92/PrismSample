using Prism.Mvvm;
using Prism.Navigation;

namespace PrismSample.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigatedAware
    {
        public string Title { get; set; } = "Welcome to Prism sample";

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}