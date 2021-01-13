using Prism.Navigation;
using PrismSample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismSample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterPage : IMasterDetailPageOptions
    {
        private readonly MyMasterPageViewModel _viewModel;

        public MyMasterPage()
        {
            InitializeComponent();
            _viewModel = (MyMasterPageViewModel) BindingContext;
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        public bool IsPresentedAfterNavigation => Device.Idiom != TargetIdiom.Phone;

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (!(e.SelectedItem is MyMasterPageMasterMenuItem item))
            {
                return;
            }

            _viewModel.NavigateCommand.Execute(item.Title);
            IsPresented = false;
        }
    }
}