using System;
using System.Windows.Input;
using BusyZone.PageViews;

namespace BusyZone.ViewModels;

public class BusyloginpageViewModel : BindableObject
{
	public BusyloginpageViewModel()
	{
		LoginCommand = new Command(BuzyUserlogin);
		BuzyNewUser = new Command(NewUserPage);
		Forgetpasscode = new Command(Userpassreset);
	}

    public ICommand LoginCommand { get; set; }
    public ICommand BuzyNewUser { get; set; }
    public ICommand Forgetpasscode { get; set; }

    string BuzyEmail;
    public string UserEmail
    {
        get => BuzyEmail;
        set
        {
            BuzyEmail = value;
            OnPropertyChanged(nameof(UserEmail));
        }
    }

    string BuzyPassword;
    public string UserPassword
    {
        get => BuzyPassword;
        set
        {
            BuzyPassword = value;
            OnPropertyChanged(nameof(UserPassword));
        }
    }

    public async void BuzyUserlogin()
    {
        if (string.IsNullOrEmpty(UserEmail))
        {
            await Application.Current.MainPage.DisplayAlert("Empty Field", $"Empty Email Field", "OK");
        }
        else if (string.IsNullOrEmpty(UserPassword))
        {
            await Application.Current.MainPage.DisplayAlert("Empty Field", $"Empty Passowrd Field", "OK");
        }
        else
        {

        }

    }
    private async void NewUserPage()
    {
        var newuser = $"{nameof(Busynewuser)}";
        await Shell.Current.GoToAsync(newuser);
    }

    private async void Userpassreset()
    {
        var passreset = $"{nameof(Busypassrest)}";
        await Shell.Current.GoToAsync(passreset);
    }

}

