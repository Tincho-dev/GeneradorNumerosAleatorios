using GeneradorNumerosAleatorios.BLazorMAUI.Services;
using Microsoft.AspNetCore.Components.WebView.Maui;
using NumerosAleatoriosIO.Services;

namespace GeneradorNumerosAleatorios.BLazorMAUI
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
                });

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            builder.Services.AddSingleton<IGeneradorService, GeneradorService>();
            builder.Services.AddSingleton<IPruebasEstadisticasService, PruebasEstadisticasService>();

            return builder.Build();
        }
    }
}