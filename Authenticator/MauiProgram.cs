using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace Authenticator;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("BrandRegularFA.otf", "FAB");
                fonts.AddFont("RegularFA.otf", "FAR");
                fonts.AddFont("SolidFA.otf", "FAS");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
