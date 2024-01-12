using BusyZone.DataModel;
using BusyZone.ViewModels;

namespace BusyZone.PageViews;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}


