using Newtonsoft.Json;

namespace ZomatoApiCall
{
    public class Location
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("locality_verbose")]
        public string LocalityVerbose { get; set; }
    }
}