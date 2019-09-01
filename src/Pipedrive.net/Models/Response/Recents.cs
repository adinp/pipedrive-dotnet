﻿using Newtonsoft.Json;
using Pipedrive.Internal;

namespace Pipedrive
{
    [JsonConverter(typeof(RecentsConverter))]
    public class Recents
    {
        public long Id { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonIgnore]
        public IRecentsEntity Data { get; set; }


    }
}