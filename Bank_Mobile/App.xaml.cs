using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Bank_Mobile.Services;
using Bank_Mobile.Views;
using System.Diagnostics;
using System.IO;

namespace Bank_Mobile
{
    //https://elcamino.dev/xamarin-forms-splash-screen/
    //https://docs.microsoft.com/en-us/xamarin/android/user-interface/splash-screen
    public partial class App : Application
    {
        private static BankDataStore _database;
        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            DependencyService.Register<BankDataStore>();
            MainPage = new AppShell();
        }
        public static BankDataStore DataBase
        {
            get
            {
                //if (_database == null)
                //{
                //    _database = new MockDataStore();
                //}
                //return _database;
                if (_database == null)
                {
                    _database = new BankDataStore(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return _database;
            }
        }
        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }
    }
}
