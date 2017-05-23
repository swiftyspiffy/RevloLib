using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevloLib
{
    public static class Core
    {
        public static string APIKey { get { return Internal.Requests.APIKey; } set { Internal.Requests.APIKey = value; } }

        private static string base_url = "https://api.revlo.co/1";

        public static class Rewards
        {
            #region GetRewards
            public static async Task<Models.Rewards.RewardsResponse> GetRewards(int page = 1)
            {
                return await Internal.Requests.GetGeneric<Models.Rewards.RewardsResponse>($"{base_url}/rewards?page={page}");
            }
            #endregion
        }
        
        public static class Redemptions
        {
            #region GetRedemptions
            public static async Task<Models.Redemptions.RedemptionsResponse> GetRedemptions(int page = 1, bool? completed = null, bool? refunded = null, int? reward_id = null)
            {
                string paramsStr = "?page=" + page;
                if (completed != null)
                    paramsStr += "&completed=" + completed.ToString().ToLower();
                if (refunded != null)
                    paramsStr += "&refunded=" + refunded.ToString().ToLower();
                if (reward_id != null)
                    paramsStr += "&reward_id=" + reward_id;

                return await Internal.Requests.GetGeneric<Models.Redemptions.RedemptionsResponse>($"{base_url}/redemptions{paramsStr}");
            }
            #endregion
            #region GetRedemption
            public static async Task<Models.Redemptions.RedemptionResponse> GetRedemption(int redemption_id)
            {
                return await Internal.Requests.GetGeneric<Models.Redemptions.RedemptionResponse>($"{base_url}/redemptions/{redemption_id}");
            }
            #endregion
            #region PatchRedemption
            public static async Task<Models.Redemptions.RedemptionResponse> PatchRedemption(int redemption_id, bool completed)
            {
                return await Internal.Requests.PatchGeneric<Models.Redemptions.RedemptionResponse>($"{base_url}/redemptions/{redemption_id}", "{\"completed\": " + completed.ToString().ToLower() + "}");
            }
            #endregion
        }

        public static class Fans
        {
            #region GetFanPoints
            public static async Task<Models.Fans.FansResponse> GetFanPoints(string username)
            {
                return await Internal.Requests.GetGeneric<Models.Fans.FansResponse>($"{base_url}/fans/{username}/points");
            }
            #endregion
            #region ModifyFanPoints
            public static async Task<Models.Fans.FansResponse> ModifyFanPoints(string username, int points)
            {
                return await Internal.Requests.PostGeneric<Models.Fans.FansResponse>($"{username}/fans/{username}/bonus", "{\"amount\": " + points + "}");
            }
            #endregion
        }
        
    }
}
