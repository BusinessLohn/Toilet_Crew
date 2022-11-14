using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Create_devices
{
    public class Post
    {
        [JsonProperty("dispenser_id")]
        public int Disid { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("battery_level")]
        public int Battery { get; set; }

        [JsonProperty("bathroom_id")]
        public int Bathid { get; set; }

        [JsonProperty("dispenser_type")]
        public string Distype { get; set; }

        [JsonProperty("last_updated")]
        public string Update { get; set; }

        [JsonProperty("mac_address")]
        public string Addr { get; set; }
    }
}