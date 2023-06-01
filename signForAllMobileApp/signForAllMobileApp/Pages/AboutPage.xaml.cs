using Plugin.Share;
using signForAllMobileApp.Classes;
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
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //CrossShare.Current.OpenBrowser(member.members.ToString());
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
        private void cntStudent(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.linkedin.com/in/ahmed-alharthy/");
        }
        private void cntStudentR(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.linkedin.com/in/ruby-steegmans/");
        }
        private void cntStudentT(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.linkedin.com/in/thendo-ndhlovu-7b5351212/");
        }
        private void cntStudentW(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.linkedin.com/in/william-houy-b15975277/");
        }
        private void cntStudentK(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.linkedin.com/in/kagiso-kgobane-4a5a60269/");
        }
    }
}
