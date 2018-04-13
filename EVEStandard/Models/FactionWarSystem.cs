﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EVEStandard.Models
{
    using Newtonsoft.Json;

    public class FactionWarSystem : ModelBase<FactionWarSystem>
    {
        /// <summary>
        /// solar_system_id integer
        /// </summary>
        /// <value>solar_system_id integer</value>
        [JsonProperty("solar_system_id")]
        public int? SolarSystemId { get; set; }

        /// <summary>
        /// owner_faction_id integer
        /// </summary>
        /// <value>owner_faction_id integer</value>
        [JsonProperty("owner_faction_id")]
        public int? OwnerFactionId { get; set; }

        /// <summary>
        /// occupier_faction_id integer
        /// </summary>
        /// <value>occupier_faction_id integer</value>
        [JsonProperty("occupier_faction_id")]
        public int? OccupierFactionId { get; set; }

        /// <summary>
        /// victory_points integer
        /// </summary>
        /// <value>victory_points integer</value>
        [JsonProperty("victory_points")]
        public int? VictoryPoints { get; set; }

        /// <summary>
        /// victory_points_threshold integer
        /// </summary>
        /// <value>victory_points_threshold integer</value>
        [JsonProperty("victory_points_threshold")]
        public int? VictoryPointsThreshold { get; set; }

        /// <summary>
        /// contested boolean
        /// </summary>
        /// <value>contested boolean</value>
        [JsonProperty("contested")]
        public bool? Contested { get; set; }
    }
}
