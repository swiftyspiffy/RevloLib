using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevloLib.Models.Redemptions
{
    public class RedemptionsResponse
    {
        [JsonProperty(PropertyName = "redemptions")]
        public Redemption[] Redemptions { get; protected set; }
        [JsonProperty(PropertyName = "total")]
        public int Total { get; protected set; }
        [JsonProperty(PropertyName = "page_size")]
        public int PageSize { get; protected set; }
    }
}
