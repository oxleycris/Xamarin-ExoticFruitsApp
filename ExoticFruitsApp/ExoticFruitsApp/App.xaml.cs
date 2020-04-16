using ExoticFruitsApp.Views;
using Xamarin.Forms;

namespace ExoticFruitsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MarketPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
