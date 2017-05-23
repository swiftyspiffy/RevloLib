using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevloLib.Models.Fans
{
    public class FansResponse
    {
        [JsonProperty(PropertyName = "fan")]
        public string Fan { get; protected set; }
        [JsonProperty(PropertyName = "total_points")]
        public int TotalPoints { get; protected set; }
        [JsonProperty(PropertyName = "current_points")]
        public int CurrentPoints { get; protected set; }
        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; protected set; }
    }
}
