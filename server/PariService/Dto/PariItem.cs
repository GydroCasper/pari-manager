﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PariService.Dto
{
    public class PariItem
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("id")]
        public Guid Id;

        [JsonProperty("date")]
        public DateTime Date;

        [JsonProperty("judges")]
        public List<string> Judges;

        [JsonProperty("attitudes")]
        public List<string> Attitudes;
    }
}