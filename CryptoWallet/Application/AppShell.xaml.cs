using System;
using System.Collections.Generic;
using CryptoWallet.Modules.Wallet;
using CryptoWallet.Modules.Assets;
using CryptoWallet.Modules.Transactions;

using Xamarin.Forms;
using Autofac;
using CryptoWallet.Modules.AddTransaction;

namespace CryptoWallet
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = App.Container.Resolve<AppShellViewModel>();

            Routing.RegisterRoute("AddTransactionViewModel", typeof(AddTransactionView));
        }

    }
}
