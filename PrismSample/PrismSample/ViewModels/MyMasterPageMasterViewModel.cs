using Prism.Mvvm;
using Prism.Navigation;

namespace PrismSample.ViewModels
{
    public class MyMasterPageMasterViewModel : BindableBase, INavigatedAware
    {
        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}