using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismSample.ViewModels
{
    public class StartupViewModel : BindableBase, INavigationAware
    {
        public StartupViewModel(INavigationService navigationService)
        {
            LoadCommand = new LoadAsyncCommand(navigationService);
        }

        public ICommand LoadCommand { get; }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            LoadCommand.Execute(null);
        }

        #region Command

        public class LoadAsyncCommand : ICommand
        {
            private readonly INavigationService _navigationService;

            public LoadAsyncCommand(INavigationService navigationService)
            {
                _navigationService = navigationService;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public async void Execute(object parameter)
            {
                await Task.Delay(2000);
                //Root is MasterDetail Page
                //await _navigationService.NavigateAsync("/MyMasterPage/NavigationPage/MainPage");
                
                //Root is TabbedPage which has a MasterDetailPage child 
                await _navigationService.NavigateAsync("RootTabbedPage");
            }

            public event EventHandler CanExecuteChanged;
        }

        #endregion
    }
}