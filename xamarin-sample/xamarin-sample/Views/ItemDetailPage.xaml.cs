using System.ComponentModel;
using Xamarin.Forms;
using xamarin_sample.ViewModels;

namespace xamarin_sample.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}