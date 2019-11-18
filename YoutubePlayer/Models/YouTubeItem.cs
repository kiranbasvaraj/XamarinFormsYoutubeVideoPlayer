using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubePlayer.Models
{
   public class YouTubeItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ChannelTitle { get; set; }
        public string PublishedAt { get; set; }
        public string VideoId { get; set; }
        public string DefaultThumbnailUrl { get; set; }
        public string MediumThumbnailUrl { get; set; }
        public string HighThumbnailUrl { get; set; }
        public string StandardThumbnailUrl { get; set; }
        public string MaxResThumbnailUrl { get; set; }
        public string ViewCount { get; set; }
        public string LikeCount { get; set; }
        public string DislikeCount { get; set; }
        public string FavoriteCount  { get; set; }
        public string CommentCount { get; set; }
        public string Tags { get; set; }
        public string VDLink { get; set; }
        //{
        //    get { return vdLink; }
        //    set {
        //        vdLink = "https://www.youtube.com/watch?v="+value;
        //    }
        //}


    }
}
