using System;
using System.Windows.Input;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismSample.ViewModels
{
    public class Page4ViewModel : BindableBase, INavigatedAware
    {
        public Page4ViewModel(INavigationService navigationService)
        {
            NavigateCommand = new NavigateToPage5Command(navigationService);
        }

        public ICommand NavigateCommand { get; }

        #region Command

        private class NavigateToPage5Command : ICommand
        {
            private readonly INavigationService _navigationService;

            public NavigateToPage5Command(INavigationService navigationService)
            {
                _navigationService = navigationService;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public async void Execute(object parameter)
            {
                await _navigationService.NavigateAsync("Page5");
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