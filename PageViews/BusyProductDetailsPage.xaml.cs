using System;
using BusyZone.ViewModels;

namespace BusyZone.PageViews;


public partial class BusyProductDetailsPage : ContentPage
{
    //public string productId { get; set; }
    public BusyProductDetailsPage(ProductDetailsPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

    }
   // protected override void OnAppearing()
   // {
   //     base.OnAppearing();
   //     int.TryParse(productId, out var result);

       // BindingContext = await coffeeService.GetCoffee(result);
   // }

}

