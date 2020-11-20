using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Calling_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calling());
        }
        private async void AddressClicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HouseNumber());
        }

    }
}
