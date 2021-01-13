using System;
using System.Windows.Input;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismSample.ViewModels
{
    public class MyMasterPageViewModel : BindableBase,INavigatedAware
    {
        public MyMasterPageViewModel(INavigationService navigationService)
        {
            NavigateCommand = new NavigateToCommand(navigationService);
        }

        public ICommand NavigateCommand { get; }

        #region Command

        private class NavigateToCommand : ICommand
        {
            private readonly INavigationService _navigationService;


            public NavigateToCommand(INavigationService navigationService)
            {
                _navigationService = navigationService;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public async void Execute(object parameter)
            {
                await _navigationService.NavigateAsync(new Uri($"NavigationPage/{parameter}", UriKind.Relative));
            }

            public event EventHandler CanExecuteChanged;
        }

        #endregion

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}