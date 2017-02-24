using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaLens.Models;
using XamaLens.ViewModels;
using Xamarin.Forms;

namespace XamaLens.Views
{
    public partial class MonkeysPage : ContentPage
    {
        public MonkeysPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }

        private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        private void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var monkey = ((ListView)sender).SelectedItem as Monkey;
            if (monkey == null)
                return;

            Navigation.PushAsync(new DetailsPage(monkey));
        }
    }
}