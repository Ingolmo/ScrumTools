
using FreshMvvm;
using ScrumTools.PageModels;
using Xamarin.Forms;

namespace ScrumTools
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();


        }

        /* Private Methods */

        private void SetMainPage()
        {
            var detail = FreshPageModelResolver.ResolvePageModel<MainPageModel>();

            MainPage = new FreshNavigationContainer(detail);
        }
    }
}
