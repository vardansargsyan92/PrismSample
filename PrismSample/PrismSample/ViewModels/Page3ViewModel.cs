using Prism.Mvvm;
using Prism.Navigation;

namespace PrismSample.ViewModels
{
    public class Page3ViewModel : BindableBase, INavigatedAware
    {
        public string PageTitle { get; set; } = "Page 3";

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}