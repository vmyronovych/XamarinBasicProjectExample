using Autofac;
using Myd.Client.App.Pages.Login;
using Xamarin.Forms;

namespace Myd.Client.App
{
    public class App : Application
    {
        public static IContainer DiContainer { get; private set; }
    
        public App()
        {
            InitDiContainer();

            // The root page of your application
            MainPage = DiContainer.Resolve<LoginPage>();
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

        private static void InitDiContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<AppModule>();
            DiContainer = builder.Build();
        }
    }
}
