using System;
using System.Windows.Input;
using BusyZone.PageViews;

namespace BusyZone.ViewModels;

public class BusypassrestViewModel : BindableObject
{
	public BusypassrestViewModel()
	{
        PasswordResetComm = new Command(ResetPasscode);
    }
    public ICommand PasswordResetComm { get; set; }


    string _passcodereset;
    public string Passcodereset
    {
        get => _passcodereset;
        set
        {
            _passcodereset = value;
            OnPropertyChanged(nameof(Passcodereset));
        }

    }

    private async void ResetPasscode()
    {
        var login = $"{nameof(Busyloginpage)}";
        await Shell.Current.GoToAsync(login);
    }
}

