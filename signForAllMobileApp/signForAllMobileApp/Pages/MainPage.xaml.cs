using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace signForAllMobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void GoToLearnPage(object obj, EventArgs args)
        {
            Navigation.PushAsync(new Pages.LearnPage());
        }
        public void GoToCameraPage(object obj, EventArgs args)
        {
            Navigation.PushAsync(new Pages.CameraPage());
        }
        public void GoToAboutPage(object obj, EventArgs args)
        {
            Navigation.PushAsync(new Pages.AboutPage());
        }
    }
}
