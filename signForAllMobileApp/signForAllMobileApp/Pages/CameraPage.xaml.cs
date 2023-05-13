using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace signForAllMobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CameraPage : ContentPage
    {
        public CameraPage()
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

        private void CaptureImage(object sender, EventArgs e)
        {
            xctCameraView.Shutter();
        }
        private void RecordVideo(object sender, EventArgs e)
        {
            xctCameraView.Shutter();
        }
        private void StopVideo(object sender, EventArgs e)
        {
            xctCameraView.Shutter();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (xctCameraView.CaptureMode == CameraCaptureMode.Photo)
            {
                captureMode.Text = "Video";
                xctCameraView.CaptureMode = CameraCaptureMode.Video;

                captureBtn.IsEnabled = false;
                btnrecordVideo.IsEnabled = true;
                btnstopVideo.IsEnabled = false;
            }
            else
            {
                captureMode.Text = "Photo";
                xctCameraView.CaptureMode = CameraCaptureMode.Photo;

                captureBtn.IsEnabled = true;
                btnrecordVideo.IsEnabled = false;
                btnstopVideo.IsEnabled = false;
            }
        }
        private void MediaCaptured(object sender, MediaCapturedEventArgs e)
        {

            imgView.Source = e.Image;
            imgViewPanel.IsVisible = true;
        }

        private void CloseImageView(object sender, EventArgs e)
        {
            imgViewPanel.IsVisible = false;
        }
    }
}