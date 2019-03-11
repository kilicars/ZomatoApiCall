using Newtonsoft.Json;

namespace ZomatoApiCall
{
    public class Review
    {
        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("review_text")]
        public string ReviewText { get; set; }
    }
}