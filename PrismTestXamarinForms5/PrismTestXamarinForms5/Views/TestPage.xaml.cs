using System;
using Xamarin.Forms;

namespace PrismTestXamarinForms5.Views
{
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
        }

        private void Button1_OnClicked(object sender, EventArgs e)
        {
            Button1.IsVisible = false;
            Button2.IsVisible = true;
        }

        private void Button2_OnClicked(object sender, EventArgs e)
        {
            Button2.IsVisible = false;
            Button1.IsVisible = true;
        }
    }
}
