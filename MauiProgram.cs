using BusyZone.DataModel;
using BusyZone.PageViews;
using BusyZone.ViewModels;

namespace BusyZone;

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
				fonts.AddFont("Metropolis-Medium.otf", "Metropolis Medium");
               // fonts.AddFont("materialdesignicons-webfont.ttf", "Metropolis Medium");
            });
		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
		builder.Services.AddSingleton<AppShell>();
		builder.Services.AddTransient<Busyloginpage>();
		builder.Services.AddTransient<BusyloginpageViewModel>();
		builder.Services.AddTransient<Busynewuser>();
		builder.Services.AddTransient<BusynewuserViewModel>();
		builder.Services.AddTransient<BusypassrestViewModel>();
		builder.Services.AddTransient<Busypassrest>();
        builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainPageViewModel>();
		builder.Services.AddTransient<ProductDetailsPageViewModel>();
		builder.Services.AddTransient<BusyProductDetailsPage>();
        builder.Services.AddSingleton<AddProductsPage>();
        builder.Services.AddSingleton<AddProductsPageViewModel>();

       

        return builder.Build();
	}
}

