using Newtonsoft.Json;

namespace ZomatoApiCall
{
    public class ReviewList
    {
        [JsonProperty("reviews_count")]
        public int ResultsFound { get; set; }

        [JsonProperty("reviews_shown")]
        public int ResultsShown { get; set; }

        [JsonProperty("user_reviews")]
        public ReviewRecord[] UserReviews { get; set; }
    }
}
