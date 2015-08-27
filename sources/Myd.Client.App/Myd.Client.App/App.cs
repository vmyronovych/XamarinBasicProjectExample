using Autofac;
using Myd.Client.App.Infrastructure;
using Myd.Client.App.Pages.Login;
using Myd.Client.App.Services;
using Xamarin.Forms;

namespace Myd.Client.App
{
    public class App : Application
    {
        public App()
        {
            var container = Bootstraper.Bootstrap();
            // The root page of your application
            MainPage = container.Resolve<LoginPage>();
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
