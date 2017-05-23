using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevloLib.Models.Redemptions
{
    public class Redemption
    {
        [JsonProperty(PropertyName = "reward_id")]
        public int RewardId { get; protected set; }
        [JsonProperty(PropertyName = "redemption_id")]
        public int RedemptionId { get; protected set; }
        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; protected set; }
        [JsonProperty(PropertyName = "refunded")]
        public bool Refunded { get; protected set; }
        [JsonProperty(PropertyName = "completed")]
        public bool Completed { get; protected set; }
        [JsonProperty(PropertyName = "username")]
        public string Username { get; protected set; }
        //TODO: account for user_input object
    }
}
