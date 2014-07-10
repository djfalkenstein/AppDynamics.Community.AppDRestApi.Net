using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Queries
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// </summary>
    public class BackendsQuery
    {
        readonly QueryEncoder _qe = new QueryEncoder();

        internal string BuildUrlStringBackendsFromApps(string baseUrl, string application)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(_qe.Encode(application));
            builder.Append(Dictionary.UrlBackends);
            return builder.ToString();
        }

        /*
         * metric-data?metric-path=Backends|<tier>|Average%20Response%20Time%20%28ms%29&time-range-type=BEFORE_NOW&duration-in-mins=15
         *
         * Backends|alerts|Average Response Time (ms)
         */

        internal string BuildUrlStringBackendAverageResponseTimeMs(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBackends1);
            builder.Append(tier).Append(Dictionary.AverageResponseTimeMs);
            val.Append(_qe.Encode(builder.ToString()));

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

        internal string BuildUrlStringBackendCallsPerMinute(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBackends1);
            builder.Append(tier).Append(Dictionary.CallsPerMinute);
            val.Append(_qe.Encode(builder.ToString()));

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

        internal string BuildUrlStringBackendErrorsPerMinute(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBackends1);
            builder.Append(tier).Append(Dictionary.ErrorsPerMinute);
            val.Append(_qe.Encode(builder.ToString()));

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