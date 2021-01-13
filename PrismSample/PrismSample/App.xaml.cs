using Prism;
using Prism.Ioc;
using PrismSample.Pages;
using PrismSample.ViewModels;
using Xamarin.Forms;

namespace PrismSample
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<StartupPage, StartupViewModel>();
            containerRegistry.RegisterForNavigation<MyFlyOutPage, MyMasterPageViewModel>();
            containerRegistry.RegisterForNavigation<MyFlyOutMenuPage, MyMasterPageMasterViewModel>();
            containerRegistry.RegisterForNavigation<RootTabbedPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<Page1, Page1ViewModel>();
            containerRegistry.RegisterForNavigation<Page2, Page2ViewModel>();
            containerRegistry.RegisterForNavigation<Page3, Page3ViewModel>();
            containerRegistry.RegisterForNavigation<Page4, Page4ViewModel>();
            containerRegistry.RegisterForNavigation<Page5, Page5ViewModel>();
            containerRegistry.RegisterForNavigation<Page6, Page6ViewModel>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("StartupPage");
        }
    }
}