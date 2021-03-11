using System;
using System.Threading.Tasks;
using System.Windows.Input;
using CryptoWallet.Common.Navigation;
using CryptoWallet.Modules.Login;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CryptoWallet
{
    public class AppShellViewModel
    {
       public ICommand SignOutCommand { get => new Command(async () => await signOut());}
        public INavigationService _navigationService;

        public AppShellViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private async Task signOut()
        {
            Preferences.Remove(Constants.IS_USER_LOGGED_IN);
            _navigationService.GoToLoginFlow();
            //await Shell.Current.DisplayAlert("todo","implement logout","Ok");
            await _navigationService.InsertAsRoot<LoginViewModel>();
        }
    }
}
