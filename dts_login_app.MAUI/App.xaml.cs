using dts_login_app.MAUI.Models;
using dts_login_app.MAUI.Views;
using Microsoft.Extensions.DependencyInjection;

namespace dts_login_app.MAUI
{
    public partial class App : Application
    {
        public static User user;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //MainPage = new NavigationPage(new LoginPage());
        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        //    return new Window(new AppShell());
        //}
    }
}