using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RFPS911App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HouseNumber : ContentPage
    {
        public HouseNumber()
        {
            InitializeComponent();
        }
        private async void NextClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StreetName());
        }
    }
}