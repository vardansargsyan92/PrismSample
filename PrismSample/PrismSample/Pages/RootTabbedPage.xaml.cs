using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace PrismSample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootTabbedPage
    {
        public RootTabbedPage()
        {
            InitializeComponent();

            //ChangeCurrentPage();
            
        }

        private async void ChangeCurrentPage()
        {
            var i = 5;
            while(true)
            {
                var index = i % 4;
                CurrentPage = Children[index];
                await Task.Delay(1000);
                i++;
            }
        }
    }
}