using System;
using System.Collections.Generic;
using Autofac;
using Xamarin.Forms;

namespace CryptoWallet.Modules.Onboarding
{
    public partial class Onboardingview : ContentPage
    {
        public Onboardingview()
        {
            InitializeComponent();
            BindingContext = App.Container.Resolve<OnboardingViewModel>();
        }
    }
}
