using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaLens.Models;
using Xamarin.Forms;

namespace XamaLens.Views
{
    public partial class DetailsPage : ContentPage
    {
        public Monkey Monkey { get; set; }

        public DetailsPage(Monkey monkey)
        {
            InitializeComponent();

            Monkey = monkey;
            BindingContext = this;
        }
    }
}