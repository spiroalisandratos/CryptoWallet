using System;
using System.Collections.Generic;
using Autofac;
using CryptoWallet.Common.Models;
using Xamarin.Forms;

namespace CryptoWallet.Modules.Transactions
{
    public partial class DepositedTransactionsView : ContentPage
    {
        public DepositedTransactionsView()
        {
            InitializeComponent();
            BindingContext = App.Container.Resolve<TransactionsViewModel>();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await (BindingContext as TransactionsViewModel).InitializeAsync(Constants.TRANSACTION_DEPOSITED);
        }
    }
}
