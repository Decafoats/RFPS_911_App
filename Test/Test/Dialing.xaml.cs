using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dialing : ContentPage
    {
        string numberText = "";
        public Dialing()
        {
            InitializeComponent();
        }
    void OneClicked(object sender, EventArgs e)
        {
                if (numberText == "9" || numberText == "91")
                {              
                    char newNum = '1';
                    numberText += newNum;
                    number.Text = $"{numberText}";
                    buttonOne.BorderColor = Color.Green;
            }
                else
                {
                    buttonOne.BorderColor = Color.Red;
                }
        }

        void NineClicked(object sender, EventArgs e)
        {
            char newNum = '9';
            if (numberText == "")
            {
                numberText += newNum;
                number.Text = $"{numberText}";
                buttonNine.BorderColor = Color.Green;
            }
            else
            {
                buttonNine.BorderColor = Color.Red;
            }
        }
        void TwoClicked(object sender, EventArgs e)
        {
            buttonTwo.BorderColor = Color.Red;
        }
        void ThreeClicked(object sender, EventArgs e)
        {
            buttonThree.BorderColor = Color.Red;
        }
        void FourClicked(object sender, EventArgs e)
        {
            buttonFour.BorderColor = Color.Red;
        }
        void FiveClicked(object sender, EventArgs e)
        {
            buttonFive.BorderColor = Color.Red;
        }
        void SixClicked(object sender, EventArgs e)
        {
            buttonSix.BorderColor = Color.Red;
        }
        void SevenClicked(object sender, EventArgs e)
        {
            buttonSeven.BorderColor = Color.Red;
        }
        void EightClicked(object sender, EventArgs e)
        {
            buttonEight.BorderColor = Color.Red;
        }
        void ZeroClicked(object sender, EventArgs e)
        {
            buttonZero.BorderColor = Color.Red;
        }
        void StarClicked(object sender, EventArgs e)
        {
            buttonStar.BorderColor = Color.Red;
        }
        //void HashClicked(object sender, EventArgs e)
        //{
        //    buttonHash.BorderColor = Color.Red;
        //}
        private async void PhoneClicked(object sender, EventArgs e)
        {
            if (numberText == "911")
            {
                await Navigation.PushAsync(new InCall());
            }
            else
            {
                buttonPhone.BorderColor = Color.Red;
            }

        }
        private void HashClicked(object sender, EventArgs e)
        {
            popupLoadingView.IsVisible = true;
            activityIndicator.IsRunning = true;

        }
    }
}