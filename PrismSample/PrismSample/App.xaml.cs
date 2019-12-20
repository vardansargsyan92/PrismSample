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
            containerRegistry.RegisterForNavigation<MyMasterPage, MyMasterPageViewModel>();
            containerRegistry.RegisterForNavigation<MyMasterPageMaster, MyMasterPageMasterViewModel>();
            containerRegistry.RegisterForNavigation<RootTabbedPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<Page1>();
            containerRegistry.RegisterForNavigation<Page2>();
            containerRegistry.RegisterForNavigation<Page3>();
            containerRegistry.RegisterForNavigation<Page4, Page4ViewModel>();
            containerRegistry.RegisterForNavigation<Page5, Page5ViewModel>();
            containerRegistry.RegisterForNavigation<Page6, Page6ViewModel>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("RootTabbedPage");
        }
    }
}