using System.Collections.ObjectModel;
using Prism.Mvvm;
using Prism.Navigation;
using PrismSample.Pages;

namespace PrismSample.ViewModels
{
    public class MyMasterPageMasterViewModel : BindableBase, INavigatedAware
    {
        public MyMasterPageMasterViewModel()
        {
            MenuItems = new ObservableCollection<MyMasterPageMasterMenuItem>(new[]
                                                                             {
                                                                                 new MyMasterPageMasterMenuItem {Id = 0, Title = "MainPage"},
                                                                                 new MyMasterPageMasterMenuItem {Id = 1, Title = "Page4"},
                                                                                 new MyMasterPageMasterMenuItem {Id = 2, Title = "Page5"},
                                                                                 new MyMasterPageMasterMenuItem {Id = 3, Title = "Page6"}
                                                                             });
        }

        public ObservableCollection<MyMasterPageMasterMenuItem> MenuItems { get; }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}