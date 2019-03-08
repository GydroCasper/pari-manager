using System.Net;
using Newtonsoft.Json;

namespace PariService.Helpers
{
    public class PariResponse<T>
    {
        [JsonProperty("status")]
        public HttpStatusCode Status;

        [JsonProperty("body")]
        public T Body;

        [JsonProperty("message")]
        public string ErrorMessage;
    }
}