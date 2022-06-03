using System;
using Xamarin.Forms;

namespace CarSelectionMobile
{
    public class StartPage : ContentPage
    {
        public StartPage()
        {
            Label header = new Label() {Text = "Hello in Xamarin Forms"};
            this.Content = header;
        }
    }
}