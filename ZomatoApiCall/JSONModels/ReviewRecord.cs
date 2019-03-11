using Newtonsoft.Json;

namespace ZomatoApiCall
{
    public class ReviewRecord
    {
        [JsonProperty("review")]
        public Review Review { get; set; }
    }
}