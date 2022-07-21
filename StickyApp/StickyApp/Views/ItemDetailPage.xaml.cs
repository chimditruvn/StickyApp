using StickyApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StickyApp.Views
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