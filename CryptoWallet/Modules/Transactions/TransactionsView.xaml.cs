using System;
using System.Collections.Generic;
using Autofac;
using Xamarin.Forms;

namespace CryptoWallet.Modules.Transactions
{
    public partial class TransactionsView : ContentPage
    {
        public TransactionsView()
        {
            InitializeComponent();
            BindingContext = App.Container.Resolve<TransactionsViewModel>();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await (BindingContext as TransactionsViewModel).InitializeAsync(string.Empty);
        }
    }
}
