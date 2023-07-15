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
    public partial class InCall : ContentPage
    {
        public InCall()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            await Task.Delay(3200);
            PopupSuccess();
        }

        private async void ScriptClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Script());
        }

        private void PopupSuccess()
        {
            popupSuccessView.IsVisible = true;

        }
    }
}