using BusyZone.ViewModels;

namespace BusyZone.PageViews;

public partial class AddProductsPage : ContentPage
{
	public AddProductsPage(AddProductsPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
