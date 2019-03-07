using Newtonsoft.Json;

namespace PariService.Dto
{
    public class QueryDto
    {
        [JsonProperty("Name")]
        public string Name;

        [JsonProperty("payload")]
        public object Payload;
    }
}