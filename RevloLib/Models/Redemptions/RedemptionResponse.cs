using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevloLib.Models.Redemptions
{
    public class RedemptionResponse
    {
        [JsonProperty(PropertyName = "redemption")]
        public Redemption Redemption { get; protected set; }
    }
}
