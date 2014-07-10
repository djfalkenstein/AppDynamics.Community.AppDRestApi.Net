using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Queries
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class TierQuery
    {
        readonly QueryEncoder _qe = new QueryEncoder();
        internal string BuildUrlStringTiersFromApps(string baseUrl, string application)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(_qe.Encode(application)).Append(Dictionary.UrlTiers);
            return builder.ToString();
        }

        internal string BuildUrlStringTiersFromApps(string baseUrl, int appId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(appId).Append(Dictionary.UrlTiers);
            return builder.ToString();
        }

        internal string BuildUrlStringTierFromApps(string baseUrl, string application, int tierId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(_qe.Encode(application)).Append(Dictionary.UrlTiers).Append(Dictionary.F).Append(tierId);
            return builder.ToString();
        }

        public string BuildUrlStringTierFromApps(string baseUrl, int appId, int tierId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(appId).Append(Dictionary.UrlTiers).Append(Dictionary.F).Append(tierId);
            return builder.ToString();
        }

        /*  * Going to add get nodes from tier * */

        public string BuildUrlStringNodesFromTier(string baseUrl, int appId, int tierId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(appId).Append(Dictionary.UrlTiers).Append(Dictionary.F).Append(tierId).Append(Dictionary.UrlNodes);
            return builder.ToString();
        }

        public string BuildUrlStringNodesFromTier(string baseUrl, int appId, string tierId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(appId).Append(Dictionary.UrlTiers).Append(Dictionary.F).Append(_qe.Encode(tierId)).Append(Dictionary.UrlNodes);
            return builder.ToString();
        }

        public string BuildUrlStringNodesFromTier(string baseUrl, string application, int tierId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(_qe.Encode(application)).Append(Dictionary.UrlTiers).Append(Dictionary.F).Append(tierId).Append(Dictionary.UrlNodes);
            return builder.ToString();
        }

        public string BuildUrlStringNodesFromTier(string baseUrl, string application, string tierId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(_qe.Encode(application)).Append(Dictionary.UrlTiers).Append(Dictionary.F).Append(_qe.Encode(tierId)).Append(Dictionary.UrlNodes);
            return builder.ToString();
        }
    }
}