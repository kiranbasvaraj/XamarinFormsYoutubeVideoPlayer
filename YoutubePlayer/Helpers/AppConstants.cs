using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubePlayer.Helpers
{
    public  class AppConstants
    {// Get your API Key @ https://console.developers.google.com/apis/api/youtube/
       public static string ApiKey = "AIzaSyAD4s5N9I6t86lTPYAZgE5fW4g-_dWEWrI";
        public static string ChannelId = "UC0m-80FnNY2Qb7obvTL_2fA";

        // Documentation @ https://developers.google.com/apis-explorer/#p/youtube/v3/youtube.videos.list 
        public static string channelUrl = $"https://www.googleapis.com/youtube/v3/search?part=id&maxResults=20&channelId={ChannelId}&key={ApiKey}";
        public static string detailsUrl = "https://www.googleapis.com/youtube/v3/videos?part=snippet,statistics&key=" + ApiKey + "&id={0}";
    }
}
