using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using YoutubePlayer.Models;
using YoutubePlayer.ViewModels;
using YoutubePlayer.Views;

namespace YoutubePlayer
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm = new MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.GetVideos();
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           var x= list.SelectedItem as YouTubeItem;
            await Navigation.PushAsync(new PlayVideoPage(x.VDLink));

        }
    }
}
