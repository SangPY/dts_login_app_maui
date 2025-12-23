using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace dts_login_app.MAUI.ViewModels
{
    public partial class AppShellViewModel : ObservableObject
    {
        [RelayCommand]
        async void SignOut()
        {
            //if (Preferences.ContainsKey(nameof(App.user)))
            //{
            //    Preferences.Remove(nameof(App.user));
            //}
            await Shell.Current.GoToAsync("..");
        }
    }
}
