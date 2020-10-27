using System;

using System.Collections.Generic;
using Bank_Mobile.ViewModels;
using Bank_Mobile.Views;
using Xamarin.Forms;

namespace Bank_Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(AddClientPage), typeof(AddClientPage));
            Routing.RegisterRoute(nameof(DepositPage), typeof(DepositPage));
            Routing.RegisterRoute(nameof(WithdrawPage), typeof(WithdrawPage));
            Routing.RegisterRoute(nameof(BankAccountPage), typeof(BankAccountPage));
        }
    }
}
