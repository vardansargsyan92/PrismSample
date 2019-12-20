using System;
using System.Windows.Input;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismSample.ViewModels
{
    public class Page5ViewModel : BindableBase
    {
        public Page5ViewModel(INavigationService navigationService)
        {
            NavigateCommand = new NavigateToPage6Command(navigationService);
        }

        public ICommand NavigateCommand { get; }

        #region Command

        private class NavigateToPage6Command : ICommand
        {
            private readonly INavigationService _navigationService;

            public NavigateToPage6Command(INavigationService navigationService)
            {
                _navigationService = navigationService;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public async void Execute(object parameter)
            {
                await _navigationService.NavigateAsync("Page6");
            }

            public event EventHandler CanExecuteChanged;
        }

        #endregion
    }
}