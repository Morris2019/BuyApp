using System;
using System.Windows.Input;
using BusyZone.PageViews;

namespace BusyZone.ViewModels;

public class BusynewuserViewModel : BindableObject
{
	public BusynewuserViewModel()
	{
		BuzyzoneSignup = new Command(CreateNewAccount);
		NaviBuzylogIn = new Command(LoginpageNavi);
	}
    public ICommand BuzyzoneSignup { get; set; }
    public ICommand NaviBuzylogIn { get; set; }


    string Buzyfirstname;
    public string Firstname
    {
        get => Buzyfirstname;
        set
        {
            Buzyfirstname = value;
            OnPropertyChanged(nameof(Firstname));
        }
    }

    string Buzylastname;
    public string Lastname
    {
        get => Buzylastname;
        set
        {
            Buzylastname = value;
            OnPropertyChanged(nameof(Lastname));
        }
    }

    string BuzyUserEmail;
    public string BuzUserEmail
    {
        get => BuzyUserEmail;
        set
        {
            BuzyUserEmail = value;
            OnPropertyChanged(nameof(BuzUserEmail));
        }
    }

    string BuzyTelephone;
    public string Telepnone
    {
        get => BuzyTelephone;
        set
        {
            BuzyTelephone = value;
            OnPropertyChanged(nameof(Telepnone));
        }
    }

    string BuzyUserpasscode;
    public string Userpasscode
    {
        get => BuzyUserpasscode;
        set
        {
            BuzyUserpasscode = value;
            OnPropertyChanged(nameof(Userpasscode));
        }
    }

    private async void CreateNewAccount()
    {
        if (string.IsNullOrEmpty(Firstname) ||
            string.IsNullOrEmpty(Lastname) ||
            string.IsNullOrEmpty(BuzUserEmail) ||
            string.IsNullOrEmpty(Telepnone) ||
            string.IsNullOrEmpty(Userpasscode))
        {
            await Application.Current.MainPage.DisplayAlert("Empty Field", $"Empty Email Field", "OK");
        }
        else if (!string.IsNullOrEmpty(BuzUserEmail))
        {

        }
        else if (!string.IsNullOrEmpty(Telepnone))
        {

        }
        else if (!string.IsNullOrEmpty(Userpasscode))
        {

        }
        else
        {

        }
        var profile = $"{nameof(Userprofile)}";
        await Shell.Current.GoToAsync(profile);
    }

    private async void LoginpageNavi()
    {
        var login = $"{nameof(Busyloginpage)}";
        await Shell.Current.GoToAsync(login);
    }
}
	

