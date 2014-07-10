using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Queries
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// </summary>
    public class MetricItemQuery
    {
        readonly QueryEncoder _qe = new QueryEncoder();
        internal string BuildUrlStringMetricList(string baseUrl, string application)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(_qe.Encode(application)).Append(Dictionary.UrlMetricList);
            return builder.ToString();
        }

        internal string BuildUrlStringMetricListForPath(string baseUrl, string application, string path)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(_qe.Encode(application)).Append(Dictionary.UrlMetricList);
            builder.Append(Dictionary.UrlMetricPathList).Append(_qe.Encode(path));
            return builder.ToString();
        }

        internal string BuildUrlStringGeneralMetricQuery(string baseUrl, string application, string path, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            val.Append(_qe.Encode(path));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }
    }
}