using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using YoutubePlayer.Helpers;
using YoutubePlayer.Models;
using YoutubePlayer.RootModels;
using YoutubePlayer.YRootModel;

namespace YoutubePlayer.ViewModels
{
    public class MainPageViewModel
    {
        public List<string> videoIds = new List<string>();


        public async Task GetVideos()
        {
            using (var httpClient = new HttpClient())
            {
                var videoIds = new List<string>();
                var json = await httpClient.GetStringAsync(AppConstants.channelUrl);

                // Deserialize our data, this is in a simple List format
                var response = JsonConvert.DeserializeObject<RootModel>(json);

                // Add all the video id's we've found to our list.
                //videoIds.AddRange(response.items.Select(item1 =>
                //{
                //    return item1.id.videoId;
                //}));
                // Get the details for all our items

                foreach (var item1 in response.items)
                {
                    videoIds.Add(item1.id.videoId);
                }
                await GetVideoDetailsAsync(videoIds);
            }
        }

        private ObservableCollection<YouTubeItem> videosList=new ObservableCollection<YouTubeItem>();

        public ObservableCollection<YouTubeItem> VideosList
        {
            get { return videosList; }
            set { videosList = value; }
        }

        private async Task GetVideoDetailsAsync(List<string> videoIds)
        {
            var videoIdString = string.Join(",", videoIds);
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync(string.Format(AppConstants.detailsUrl, videoIdString));
                var response = JsonConvert.DeserializeObject<YoutubeRoot>(json);



                foreach (var item in response.items)
                {
                    var youTubeItem = new YouTubeItem()
                    {
                        Title = item.snippet.title,
                        Description = item.snippet.description,
                        ChannelTitle = item.snippet.channelTitle,
                        PublishedAt = item.snippet.publishedAt.ToString(),
                        VideoId = item.id,
                        DefaultThumbnailUrl = item.snippet?.thumbnails?.@default?.url,
                        MediumThumbnailUrl = item.snippet?.thumbnails?.medium?.url,
                        HighThumbnailUrl = item.snippet?.thumbnails?.high?.url,
                        StandardThumbnailUrl = item.snippet?.thumbnails?.standard?.url,
                        MaxResThumbnailUrl = item.snippet?.thumbnails?.maxres?.url,
                        ViewCount = item.statistics?.viewCount,
                        LikeCount = item.statistics?.likeCount,
                        DislikeCount = item.statistics?.dislikeCount,
                        FavoriteCount = item.statistics?.favoriteCount,
                        CommentCount = item.statistics?.commentCount,
                        VDLink = "https://www.youtube.com/embed/" + item.id+@"\"
                        //Tags = item.snippet?.tags
                    };

                    VideosList.Add(youTubeItem);
                }
            }
        }
    }
}

