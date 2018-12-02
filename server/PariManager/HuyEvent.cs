using Newtonsoft.Json;

namespace PariManager
{
    public class HuyEvent
    {
        [JsonProperty("input")]
        public string Input;
    }
}