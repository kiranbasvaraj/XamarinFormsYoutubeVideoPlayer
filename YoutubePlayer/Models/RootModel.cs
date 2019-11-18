using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubePlayer.YRootModel
{
   public class RootModel
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public string regionCode { get; set; }
        public PageInfo pageInfo { get; set; }
        public List<Items> items { get; set; }
    }

    public class PageInfo
    {
        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }
    }

    public class Id1
    {
        public string kind { get; set; }
        public string videoId { get; set; }
    }

    public class Items
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public Id1 id { get; set; }
    }
}
