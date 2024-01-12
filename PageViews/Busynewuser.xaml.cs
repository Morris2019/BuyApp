using System;
using BusyZone.ViewModels;

namespace BusyZone.PageViews;

public partial class Busynewuser : ContentPage
{
	public Busynewuser(BusynewuserViewModel newViewModel)
	{
		InitializeComponent();
		BindingContext = newViewModel;
	}
}

