using Prism.Mvvm;
using Prism.Navigation;

namespace PrismSample.ViewModels
{
    public class Page1ViewModel : BindableBase, INavigatedAware
    {
        
        public string PageTitle { get; set; } = "Page 1";

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}