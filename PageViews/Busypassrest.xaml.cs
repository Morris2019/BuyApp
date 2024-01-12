using System;
using BusyZone.ViewModels;

namespace BusyZone.PageViews;

public partial class Busypassrest : ContentPage
{
	public Busypassrest(BusypassrestViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}

