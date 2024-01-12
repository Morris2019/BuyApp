
namespace BusyZone;

public partial class App : Application
{
    //public static Products_tab ProductRepo { get; private set; }

    //database = new ProductdataService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BusyZone.db"));

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

       // ProductRepo = repo;

    }
}

