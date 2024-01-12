using BusyZone.PageViews;

namespace BusyZone;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(Userprofile), typeof(Userprofile));
        Routing.RegisterRoute(nameof(Busyloginpage), typeof(Busyloginpage));
        Routing.RegisterRoute(nameof(Busynewuser), typeof(Busynewuser));
        Routing.RegisterRoute(nameof(Busypassrest), typeof(Busypassrest));
        Routing.RegisterRoute(nameof(AddProductsPage), typeof(AddProductsPage));

        Routing.RegisterRoute(nameof(BusyProductDetailsPage), typeof(BusyProductDetailsPage));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
    }
}

