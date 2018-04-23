﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EVEStandard.Models
{
    using Newtonsoft.Json;

    public class FactorySchematic : ModelBase<FactorySchematic>
    {
        /// <summary>
        /// schematic_name string
        /// </summary>
        /// <value>schematic_name string</value>
        [JsonProperty("schematic_name")]
        public string SchematicName { get; set; }

        /// <summary>
        /// Time in seconds to process a run
        /// </summary>
        /// <value>Time in seconds to process a run</value>
        [JsonProperty("cycle_time")]
        public int? CycleTime { get; set; }
    }
}
