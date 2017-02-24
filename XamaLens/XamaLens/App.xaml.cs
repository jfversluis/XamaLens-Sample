using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamaLens.Helpers;
using XamaLens.ViewModels;
using XamaLens.Views;
using Xamarin.Forms;

namespace XamaLens
{
    public static class ViewModelLocator
    {
        private static MonkeysViewModel monkeysVM;

        public static MonkeysViewModel MonkeysViewModel
        => monkeysVM ?? (monkeysVM = new MonkeysViewModel());

        private static DetailsViewModel detailsVM;

        public static DetailsViewModel DetailsViewModel
        => detailsVM ?? (detailsVM = new DetailsViewModel(MonkeyHelper.Monkeys[0]));
    }

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MonkeysPage())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.FromHex("#F2C500")
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}