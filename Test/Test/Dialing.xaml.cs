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
        public string numberText = "";
        public int failCount = 0;
        public int numCount = 0;
        public Dialing()
        {
            InitializeComponent();
        }
        private void OneClicked(object sender, EventArgs e)
        {
                if (numberText == "9" || numberText == "91")
                {              
                    char newNum = '1';
                    numberText += newNum;
                    number.Text = $"{numberText}";
                    buttonOne.BorderColor = Color.Green;
                    numCount += 1;
                    Failed(failCount, numCount, e);
            }
                else
                {
                    buttonOne.BorderColor = Color.Red;
                    failCount += 1;
                    numCount += 1;
                    Failed(failCount, numCount,e);
            }
        }

        private void NineClicked(object sender, EventArgs e)
        {
            char newNum = '9';
            if (numberText == "")
            {
                numberText += newNum;
                number.Text = $"{numberText}";
                buttonNine.BorderColor = Color.Green;
                numCount += 1;
                Failed(failCount, numCount, e);
            }
            else
            {
                buttonNine.BorderColor = Color.Red;
                failCount += 1;
                numCount += 1;
                Failed(failCount, numCount, e);
            }
        }
        private void TwoClicked(object sender, EventArgs e)
        {
            buttonTwo.BorderColor = Color.Red;
            failCount += 1;
            numCount += 1;
            Failed(failCount, numCount, e);
        }
        private void ThreeClicked(object sender, EventArgs e)
        {
            buttonThree.BorderColor = Color.Red;
            failCount += 1;
            numCount += 1;
            Failed(failCount, numCount, e);
        }
        private void FourClicked(object sender, EventArgs e)
        {
            buttonFour.BorderColor = Color.Red;
            failCount += 1;
            numCount += 1;
            Failed(failCount, numCount, e);
        }
        private void FiveClicked(object sender, EventArgs e)
        {
            buttonFive.BorderColor = Color.Red;
            failCount += 1;
            numCount += 1;
            Failed(failCount, numCount, e);
        }
        private void SixClicked(object sender, EventArgs e)
        {
            buttonSix.BorderColor = Color.Red;
            failCount += 1;
            numCount += 1;
            Failed(failCount, numCount, e);
        }
        private void SevenClicked(object sender, EventArgs e)
        {
            buttonSeven.BorderColor = Color.Red;
            failCount += 1;
            numCount += 1;
            Failed(failCount, numCount, e);
        }
        private void EightClicked(object sender, EventArgs e)
        {
            buttonEight.BorderColor = Color.Red;
            failCount += 1;
            numCount += 1;
            Failed(failCount, numCount, e);
        }
        private void ZeroClicked(object sender, EventArgs e)
        {
            buttonZero.BorderColor = Color.Red;
            failCount += 1;
            numCount += 1;
            Failed(failCount, numCount, e);
        }
        private void StarClicked(object sender, EventArgs e)
        {
            buttonStar.BorderColor = Color.Red;
            failCount += 1;
            numCount += 1;
            Failed(failCount, numCount, e);
        }
        private void HashClicked(object sender, EventArgs e)
        {
            buttonHash.BorderColor = Color.Red;
            failCount += 1;
            numCount += 1;
            Failed(failCount, numCount, e);
        }
        private void PhoneClicked(object sender, EventArgs e)
        {
            if (numberText == "911")
            {
                Calling(sender,e);
            }
            else
            {
                buttonPhone.BorderColor = Color.Red;
                PopupFail(e);
            }

        }
        private void Failed( int newCount1, int newCount2, EventArgs e)
        {
            int newFailCount = newCount1;
            int newNumCount = newCount2;
            if (newFailCount == 3 || (newNumCount == 3 && numberText != "911"))
            {
                PopupFail(e);
            }
        }

        private void PopupFail(EventArgs e)
        {
            popupFailedView.IsVisible = true;
        }

        private void TryAgain(object sender, EventArgs e)
        {
            var vUpdatedPage = new Dialing(); 
            Navigation.InsertPageBefore(vUpdatedPage, this); 
            Navigation.PopAsync();
        }

        private async void CancelClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Calling(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InCall());
        }
    }
}