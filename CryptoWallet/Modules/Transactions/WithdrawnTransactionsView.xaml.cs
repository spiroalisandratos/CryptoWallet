using System;
using System.Collections.Generic;
using Autofac;
using Xamarin.Forms;

namespace CryptoWallet.Modules.Transactions
{
    public partial class WithdrawnTransactionsView : ContentPage
    {
        
        public WithdrawnTransactionsView()
        {
            BindingContext = App.Container.Resolve<TransactionsViewModel>();

            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await (BindingContext as TransactionsViewModel).InitializeAsync(Constants.TRANSACTION_WITHDRAWN);
        }
    }
}
