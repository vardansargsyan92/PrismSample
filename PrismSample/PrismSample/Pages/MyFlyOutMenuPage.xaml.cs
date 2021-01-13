using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismSample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyOutMenuPage
    {
        public ListView ListView;

        public MyFlyOutMenuPage()
        {
            InitializeComponent();

            ListView = MenuItemsListView;
        }
    }
}