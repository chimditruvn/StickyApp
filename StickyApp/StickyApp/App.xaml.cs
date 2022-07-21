using StickyApp.Services;
using StickyApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StickyApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            App.Current.MainPage = new MainView();
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
