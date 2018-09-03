using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Demo
{
  
    
    using Views;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new Views.HomePage();
            MainPage = new NavigationPage(new OnBoardingPage());
           // MainPage = new NavigationPage(new Views.EventInformation.EventInformationPage());
           
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
