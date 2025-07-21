using Microsoft.Extensions.Logging;
using MauiGameLibrary.Views;
using MauiGameLibrary.ViewModels;
using MauiGameLibrary.Services;

namespace MauiGameLibrary
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<ListOfGamesView>();
            builder.Services.AddTransient<ListOfGamesViewModel>();
            builder.Services.AddSingleton<GameDataService>();

            return builder.Build();
        }
    }
}
