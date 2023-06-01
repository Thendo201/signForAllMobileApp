using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace signForAllMobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CameraPage : ContentPage
    {
        //Keeping track of translation
        bool capturing = false;

        public CameraPage()
        {
            InitializeComponent();
            imgViewPanel.IsVisible = false;
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

        //Use this method to capture an image
        private async void StartCapture(object sender, EventArgs e)
        {
            capturing = true;
            //Capture image every 1 second
            while(capturing == true)
            {
                xctCameraView.Shutter();

                await Task.Delay(1000);
            }
        }
        //Use this method to operate on the most recent image
        private void MediaCaptured(object sender, MediaCapturedEventArgs e)
        {
            //e.Image is the most recent image
            imgView.Source = e.Image;
            imgViewPanel.IsVisible = true;
        }
       
        private async void StopCapture(object sender, EventArgs e)
        {
            capturing = false;
            imgViewPanel.IsVisible = false;
        }

        private void CloseImageView(object sender, EventArgs e)
        {
            imgViewPanel.IsVisible = false;
        }
    }
}
