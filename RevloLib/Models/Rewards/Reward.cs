using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevloLib.Models.Rewards
{
    public class Reward
    {
        [JsonProperty(PropertyName = "reward_id")]
        public int RewardId { get; protected set; }
        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; protected set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; protected set; }
        [JsonProperty(PropertyName = "bot_command")]
        public string BotCommand { get; protected set; }
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; protected set; }
        [JsonProperty(PropertyName = "points")]
        public int Points { get; protected set; }
        [JsonProperty(PropertyName = "sub_only")]
        public bool SubOnly { get; protected set; }
        //TODO: account for input_fields
    }
}
