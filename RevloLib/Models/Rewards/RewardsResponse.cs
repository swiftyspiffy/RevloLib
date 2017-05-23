using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevloLib.Models.Rewards
{
    public class RewardsResponse
    {
        [JsonProperty(PropertyName = "rewards")]
        public Reward[] Rewards { get; protected set; }
        [JsonProperty(PropertyName = "total")]
        public int Total { get; protected set; }
        [JsonProperty(PropertyName = "page_size")]
        public int PageSize { get; protected set; }
    }
}
