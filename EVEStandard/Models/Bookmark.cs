﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EVEStandard.Models
{
    public class Bookmark
    {
        [JsonProperty("bookmark_id")]
        public long BookmarkId { get; set; }
        [JsonProperty("location_id")]
        public long LocationId { get; set; }
        [JsonProperty("item")]
        public Item Item { get; set; }
        [JsonProperty("folder_id")]
        public long FolderId { get; set; }
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }
        [JsonProperty("created")]
        public DateTime Created { get; set; }
        [JsonProperty("creator_id")]
        public long CreatorId { get; set; }
        [JsonProperty("coordinates")]
        public Position Coordinates { get; set; }
    }
}
