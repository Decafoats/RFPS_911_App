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
    public partial class Calling : ContentPage
    {
        public Calling()
        {
            InitializeComponent();
        }

        private async void Dial_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dialing());
        }
    }
}