
using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Queries
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class AgentAvailabilityMetricQuery
    {
        readonly QueryEncoder _qe = new QueryEncoder();
        public string BuildUrlStringAgentNodeAppAgentAvailability(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.IndividualNodes);
            builder.Append(node).Append(Dictionary.AppAgentAvail1);
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

        public string BuildUrlStringAgentTierAppAgentAvailability(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.AppAgentAvail1);
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

        /*
         *
         *  This is going to grab the node availability
         */

        public string BuildUrlStringAgentNodeMachineAgentAvailability(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.IndividualNodes);
            builder.Append(node).Append(Dictionary.MachineAgentAvail2);
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

        /*
         *  This will grab the Tier availability, for the time period provided.
         *
         */

        public string BuildUrlStringAgentTierMachineAgentAvailability(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(_qe.Encode(tier)).Append(Dictionary.MachineAgentAvail2);
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