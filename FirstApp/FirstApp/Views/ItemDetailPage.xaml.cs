using System.ComponentModel;
using Xamarin.Forms;
using FirstApp.ViewModels;

namespace FirstApp.Views
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