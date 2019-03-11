using Newtonsoft.Json;

namespace ZomatoApiCall
{
    public class RestaurantRecord
    {
        [JsonProperty("restaurant")]
        public Restaurant Restaurant { get; set; }
    }
}