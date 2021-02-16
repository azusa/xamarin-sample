using System;
using System.Collections.Generic;
using Xamarin.Forms;
using xamarin_sample.ViewModels;
using xamarin_sample.Views;

namespace xamarin_sample
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
