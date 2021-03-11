﻿using System;
using System.Collections.Generic;
using Autofac;
using Xamarin.Forms;

namespace CryptoWallet.Modules.Wallet
{
    public partial class WalletView : ContentPage
    {
        public WalletView()
        {
            InitializeComponent();
            BindingContext = App.Container.Resolve<WalletViewModel>();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await (BindingContext as WalletViewModel).InitializeAsync(false);
        }
    }
    
}
