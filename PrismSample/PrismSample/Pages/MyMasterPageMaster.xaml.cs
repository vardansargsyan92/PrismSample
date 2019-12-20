using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismSample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterPageMaster : ContentPage
    {
        public ListView ListView;

        public MyMasterPageMaster()
        {
            InitializeComponent();

            ListView = MenuItemsListView;
        }
    }
}