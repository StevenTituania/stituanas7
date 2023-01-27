//using Capremci.Vistas;
using Capremci.VistasSQLite;
using Xamarin.Forms;

namespace Capremci
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = MainPage = new NavigationPage(new Login());
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
