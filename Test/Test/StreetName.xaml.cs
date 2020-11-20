using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StreetName : ContentPage
    {
        public StreetName()
        {
            InitializeComponent();
        }
        private async void PreviousClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void HomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}