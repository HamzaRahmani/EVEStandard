﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EVEStandard.Models
{
    public class Asset
    {
        [JsonProperty("location_flag")]
        public string LocationFlag { get; set; }
        [JsonProperty("location_id")]
        public long LocationId { get; set; }
        [JsonProperty("is_singleton")]
        public bool IsSingleton { get; set; }
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
        [JsonProperty("item_id")]
        public long ItemId { get; set; }
        [JsonProperty("location_type")]
        public string LocationType { get; set; }
        [JsonProperty("quantity")]
        public long Quantity { get; set; }
    }
}
