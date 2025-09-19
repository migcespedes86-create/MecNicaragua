using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace MecNicaMauiLogin;

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

#if ANDROID
        Microsoft.Maui.Handlers.WebViewHandler.Mapper.AppendToMapping("AndroidSettings", (handler, view) =>
        {
            var ctrl = handler.PlatformView;
            ctrl.Settings.DomStorageEnabled = true;
            ctrl.Settings.JavaScriptEnabled = true;
        });
#endif

        return builder.Build();
    }
}
