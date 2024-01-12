using System;
using BusyZone.ViewModels;

namespace BusyZone.PageViews;

public partial class Busyloginpage : ContentPage
{
	public Busyloginpage(BusyloginpageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}

