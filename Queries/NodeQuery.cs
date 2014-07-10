using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Queries
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class NodeQuery
    {
        readonly QueryEncoder _qe = new QueryEncoder();

        internal string BuildUrlStringNodesFromApps(string baseUrl, string application)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(_qe.Encode(application)).Append(Dictionary.UrlNodes);
            return builder.ToString();
        }

        internal string BuildUrlStringNodesFromApps(string baseUrl, int appId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(appId).Append(Dictionary.UrlNodes);
            return builder.ToString();
        }

        internal string BuildUrlStringNodeFromApps(string baseUrl, string application, int nodeId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(_qe.Encode(application)).Append(Dictionary.UrlNodes).Append(Dictionary.F).Append(nodeId);
            return builder.ToString();
        }

        internal string BuildUrlStringNodeFromApps(string baseUrl, int appId, int nodeId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(appId).Append(Dictionary.UrlNodes).Append(Dictionary.F).Append(nodeId);
            return builder.ToString();
        }
    }
}