using System;
using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismSample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyOutPage
    {
        public MyFlyOutPage()
        {
            InitializeComponent();
            FlyOutMenuPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(!(e.SelectedItem is FlyOutItem item))
            {
                return;
            }

            var currentPage = (Page) Activator.CreateInstance(item.PageType);

            if(currentPage?.BindingContext is INavigatedAware viewModel)
            {
                viewModel.OnNavigatedTo(null);
            }
            Detail = new NavigationPage(currentPage);

            IsPresented = false;
        }
    }
}