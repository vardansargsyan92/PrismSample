using System;
using System.Windows.Input;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismSample.ViewModels
{
    public class Page6ViewModel : BindableBase
    {
        public Page6ViewModel(INavigationService navigationService)
        {
            NavigateCommand = new NavigateToRootCommand(navigationService);
        }

        public ICommand NavigateCommand { get; }

        #region Command

        private class NavigateToRootCommand : ICommand
        {
            private readonly INavigationService _navigationService;

            public NavigateToRootCommand(INavigationService navigationService)
            {
                _navigationService = navigationService;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public async void Execute(object parameter)
            {
                await _navigationService.GoBackToRootAsync();
            }

            public event EventHandler CanExecuteChanged;
        }

        #endregion
    }
}