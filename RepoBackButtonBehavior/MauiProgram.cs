using RepoBackButtonBehavior.Viewmodels;

namespace RepoBackButtonBehavior;

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


        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<DetailsViewModel>();
        builder.Services.AddTransient<DetailsPage>();

        return builder.Build();
	}
}
