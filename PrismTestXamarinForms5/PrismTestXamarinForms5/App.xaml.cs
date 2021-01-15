using PrismTestXamarinForms5.Views;
using Xamarin.Forms;

namespace PrismTestXamarinForms5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TestPage();
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
