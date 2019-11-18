using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YoutubePlayer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayVideoPage : ContentPage
    {
        string VDUrl;
        public PlayVideoPage(string url)
        {
            InitializeComponent();
            VDUrl = url;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            webview.HeightRequest = 300;
            webview.WidthRequest = 300;
            webview.Source = VDUrl;
        }
    }
}