using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PariService.Dto
{
    public class Attitude
    {
        [JsonProperty("id")]
        public Guid Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("bettors")]
        public List<string> Bettors;
    }
}