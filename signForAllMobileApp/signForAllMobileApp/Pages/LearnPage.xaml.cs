using Plugin.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace signForAllMobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnPage : ContentPage
    {
        public LearnPage()
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

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=_NuGZ6UTsYw");
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=_NuGZ6UTsYw");
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=bFv_mLwBvHc");
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=bFv_mLwBvHc");
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=MuQlADM6vyY");
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=MuQlADM6vyY");
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=VcfEtC1GHsc");
        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=VcfEtC1GHsc");
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=4v6OthkgyFk");
        }

        private void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=4v6OthkgyFk");
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=0FcwzMq4iWg");
        }

        private void ImageButton_Clicked_5(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=0FcwzMq4iWg");
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=bFv_mLwBvHc");
        }

        private void ImageButton_Clicked_6(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=bFv_mLwBvHc");
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=4Ll3OtqAzyw");
        }

        private void ImageButton_Clicked_7(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=4Ll3OtqAzyw");
        }
        private void OpenSourcebtn(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://sci-hub.hkvisa.net/10.1080/10228199908566144");
        }
        private void OpenSourcebtn2(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.eln.co.uk/blog/meet-charles-michel-de-lepee-the-inventor-of-sign-language#:~:text=The%20beginning%20of%20Sign%20Language,l'Eppe%20in%20the%201700's.");
        }
        private void OpenSourcebtn4(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://delabatskool.co.za/sign-language/");
        }
    }
}