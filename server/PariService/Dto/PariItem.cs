using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PariService.Dto
{
    public class PariItem
    {
        [JsonProperty("id")]
        public Guid Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("date")]
        public DateTime Date;

        [JsonProperty("judges")]
        public List<string> Judges;

        [JsonProperty("attitudes")]
        public List<Attitude> Attitudes;
    }
}