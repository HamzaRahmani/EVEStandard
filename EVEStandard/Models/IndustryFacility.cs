﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EVEStandard.Models
{
    public class IndustryFacility : ModelBase<IndustryFacility>
    {
        /// <summary>
        /// ID of the facility
        /// </summary>
        /// <value>ID of the facility</value>
        [JsonProperty("facility_id")]
        public long? FacilityId { get; set; }

        /// <summary>
        /// Tax imposed by the facility
        /// </summary>
        /// <value>Tax imposed by the facility</value>
        [JsonProperty("tax")]
        public float? Tax { get; set; }

        /// <summary>
        /// Owner of the facility
        /// </summary>
        /// <value>Owner of the facility</value>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Type ID of the facility
        /// </summary>
        /// <value>Type ID of the facility</value>
        [JsonProperty("type_id")]
        public int? TypeId { get; set; }

        /// <summary>
        /// Solar system ID where the facility is
        /// </summary>
        /// <value>Solar system ID where the facility is</value>
        [JsonProperty("solar_system_id")]
        public int? SolarSystemId { get; set; }

        /// <summary>
        /// Region ID where the facility is
        /// </summary>
        /// <value>Region ID where the facility is</value>
        [JsonProperty("region_id")]
        public int? RegionId { get; set; }
    }
}
