using Newtonsoft.Json;

namespace PariService.Helpers
{
    public class Command
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("body")]
        public object Body;
    }
}