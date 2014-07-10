/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Queries
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    ///
    /// This is going to provide all of the queries for hardware metrics
    ///
    ///
    /// </summary>
    public class HardwareResourcesMetricQuery
    {
        readonly QueryEncoder _qe = new QueryEncoder();
        // CPU Busy for the Tier
        internal string BuildUrlStringHdTierCpuBusy(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdCpu).Append(Dictionary.HdCpuBusy);
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

        internal string BuildUrlStringHdNodeCpuBusy(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdCpu).Append(Dictionary.HdCpuBusy);
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

        internal string BuildUrlStringHdTierCpuIdle(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdCpu).Append(Dictionary.HdCpuIdle);
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

        internal string BuildUrlStringHdNodeCpuIdle(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdCpu).Append(Dictionary.HdCpuIdle);
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

        internal string BuildUrlStringHdTierCpuStolen(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdCpu).Append(Dictionary.HdCpuStolen);
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

        internal string BuildUrlStringHdNodeCpuStolen(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdCpu).Append(Dictionary.HdCpuStolen);
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

        /* ***************** Disk ************************** */

        internal string BuildUrlStringHdTierDisksKbReadPerSec(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdDisks).Append(Dictionary.HdDisksKbReadPerSec);
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

        internal string BuildUrlStringHdNodeDisksKbReadPerSec(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdDisks).Append(Dictionary.HdDisksKbReadPerSec);
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

        internal string BuildUrlStringHdTierDisksKbWrittenPerSec(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdDisks).Append(Dictionary.HdDisksKbWritePerSec);
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

        internal string BuildUrlStringHdNodeDisksKbWrittenPerSec(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdDisks).Append(Dictionary.HdDisksKbWritePerSec);
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

        internal string BuildUrlStringHdTierDisksReadPerSec(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdDisks).Append(Dictionary.HdDisksReadPerSec);
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

        internal string BuildUrlStringHdNodeDisksReadPerSec(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdDisks).Append(Dictionary.HdDisksReadPerSec);
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

        internal string BuildUrlStringHdTierDisksWritesPerSec(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdDisks).Append(Dictionary.HdDisksWritesPerSec);
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

        internal string BuildUrlStringHdNodeDisksWritesPerSec(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdDisks).Append(Dictionary.HdDisksWritesPerSec);
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

        /* ***************** Memory ************************ */

        internal string BuildUrlStringHdTierMemoryFreePerc(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.HdMemoryFreePerc);
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

        internal string BuildUrlStringHdNodeMemoryFreePerc(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.HdMemoryFreePerc);
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

        internal string BuildUrlStringHdTierMemoryFreeMb(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.HdMemoryFreeMb);
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

        internal string BuildUrlStringHdNodeMemoryFreeMb(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.HdMemoryFreeMb);
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

        internal string BuildUrlStringHdTierMemoryTotalMb(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.HdMemoryTotalMb);
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

        internal string BuildUrlStringHdNodeMemoryTotalMb(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.HdMemoryTotalMb);
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

        internal string BuildUrlStringHdTierMemoryUsedPerc(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.HdMemoryUsedPerc);
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

        internal string BuildUrlStringHdNodeMemoryUsedPerc(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.HdMemoryUsedPerc);
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

        internal string BuildUrlStringHdTierMemoryUsedMb(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.HdMemoryUsedMb);
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

        internal string BuildUrlStringHdNodeMemoryUsedMb(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.HdMemoryUsedMb);
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

        /* ***************** Network *********************** */

        internal string BuildUrlStringHdTierNetworkIncomingKb(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkIncomingKb);
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

        internal string BuildUrlStringHdNodeNetworkIncomingKb(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkIncomingKb);
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

        internal string BuildUrlStringHdTierNetworkIncomingKbPerSec(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkIncomingKbPerSec);
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

        internal string BuildUrlStringHdNodeNetworkIncomingKbPerSec(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkIncomingKbPerSec);
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

        internal string BuildUrlStringHdTierNetworkIncomingPackets(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkIncomingPackets);
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

        internal string BuildUrlStringHdNodeNetworkIncomingPackets(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkIncomingPackets);
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

        internal string BuildUrlStringHdTierNetworkIncomingPacketsPerSec(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkIncomingPacketsPerSec);
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

        internal string BuildUrlStringHdNodeNetworkIncomingPacketsPerSec(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkIncomingPacketsPerSec);
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

        internal string BuildUrlStringHdTierNetworkOutgoingKb(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkOutgoingKb);
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

        internal string BuildUrlStringHdNodeNetworkOutgoingKb(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkOutgoingKb);
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

        internal string BuildUrlStringHdTierNetworkOutgoingKbPerSec(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkOutgoingKbPerSec);
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

        internal string BuildUrlStringHdNodeNetworkOutgoingKbPerSec(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkOutgoingKbPerSec);
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

        internal string BuildUrlStringHdTierNetworkOutgoingPackets(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkOutgoingPackets);
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

        internal string BuildUrlStringHdNodeNetworkOutgoingPackets(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkOutgoingPackets);
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

        internal string BuildUrlStringHdTierNetworkOutgoingPacketsPerSec(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkOutgoingPacketsPerSec);
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

        internal string BuildUrlStringHdNodeNetworkOutgoingPacketsPerSec(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.HardwareResources);
            builder.Append(Dictionary.HdNetwork).Append(Dictionary.HdNetworkOutgoingPacketsPerSec);
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