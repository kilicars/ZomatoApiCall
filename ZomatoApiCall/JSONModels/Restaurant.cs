using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomatoApiCall
{

    public class Restaurant
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("cuisines")]
        public string Cuisines { get; set; }

        [JsonProperty("average_cost_for_two")]
        public int AverageCostForTwo { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
