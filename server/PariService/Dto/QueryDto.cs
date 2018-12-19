using Newtonsoft.Json;

namespace PariService.Dto
{
    public class QueryDto
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("payload")]
        public object Payload;
    }
}