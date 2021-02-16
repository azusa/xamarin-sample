using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin_sample.Services;
using xamarin_sample.Views;

namespace xamarin_sample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
