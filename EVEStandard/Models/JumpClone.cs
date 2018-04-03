﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EVEStandard.Models
{
    using EVEStandard.Enumerations;
    using Newtonsoft.Json;

    public class JumpClone : ModelBase<JumpClone>
    {
        /// <summary>
        /// jump_clone_id integer
        /// </summary>
        /// <value>jump_clone_id integer</value>
        [JsonProperty("jump_clone_id")]
        public int? JumpCloneId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// location_id integer
        /// </summary>
        /// <value>location_id integer</value>
        [JsonProperty("location_id")]
        public long? LocationId { get; set; }

        /// <summary>
        /// location_type string
        /// </summary>
        /// <value>location_type string</value>
        [JsonProperty("location_type")]
        public LocationType? LocationType { get; set; }

        /// <summary>
        /// implants array
        /// </summary>
        /// <value>implants array</value>
        [JsonProperty("implants")]
        public List<int?> Implants { get; set; }
    }
}
