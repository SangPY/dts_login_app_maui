using dts_login_app.MAUI.Services;
using dts_login_app.MAUI.ViewModels;
using dts_login_app.MAUI.Views;
using Microsoft.Extensions.Logging;

namespace dts_login_app.MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }); 
            //builder.Services.AddSingleton<HomePage>();
            //builder.Services.AddSingleton<LoginPage>();
            //builder.Services.AddSingleton<ContactPage>();
            //builder.Services.AddSingleton<AboutPage>();
            //builder.Services.AddSingleton<LoginPageViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
