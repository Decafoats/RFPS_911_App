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
    public partial class Script : ContentPage
    {
        public Script()
        {
            InitializeComponent();
        }
        private async void BackClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }

}