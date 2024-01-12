
namespace BusyZone.PageViews;

public partial class Userprofile : ContentPage
{
	public Userprofile()
    {
		InitializeComponent();

		Logingpages();
    }
	public async void Logingpages()
	{
		var loginpage = $"{nameof(Busyloginpage)}";
		await Shell.Current.GoToAsync(loginpage);
	}
}