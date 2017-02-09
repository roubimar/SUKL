using SUKL.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SUKL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RootPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MobileCenter.Start(typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
