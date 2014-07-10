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
    /// </summary>
    public class JvmMetricQuery
    {
        readonly QueryEncoder _qe = new QueryEncoder();
        internal string BuildUrlStringJvmTierProcessCpuBurntMsPerMin(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmProcessCpuBurntMsPerMin);
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

        internal string BuildUrlStringJvmNodeProcessCpuBurntMsPerMin(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmProcessCpuBurntMsPerMin);
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

        internal string BuildUrlStringJvmTierProcessCpuUsagePerc(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmProcessCpuUsagePerc);
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

        internal string BuildUrlStringJvmNodeProcessCpuUsagePerc(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmProcessCpuUsagePerc);
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

        internal string BuildUrlStringJvmTierGarbageCollectionGcTimeSpentPerMin(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmGarbageCollection).Append(Dictionary.JvmGarbageCollectionGcTimeSpentPerMinMs);
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

        internal string BuildUrlStringJvmNodeGarbageCollectionGcTimeSpentPerMin(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmGarbageCollection).Append(Dictionary.JvmGarbageCollectionGcTimeSpentPerMinMs);
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

        internal string BuildUrlStringJvmTierGarbageCollectionMajorCollectionTimeSpentPerMin(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmGarbageCollection).Append(Dictionary.JvmGarbageCollectionMajorCollectionTimeSpentPerMinMs);
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

        internal string BuildUrlStringJvmNodeGarbageCollectionMajorCollectionTimeSpentPerMin(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmGarbageCollection).Append(Dictionary.JvmGarbageCollectionMajorCollectionTimeSpentPerMinMs);
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

        internal string BuildUrlStringJvmTierGarbageCollectionMinorCollectionTimeSpentPerMin(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmGarbageCollection).Append(Dictionary.JvmGarbageCollectionMinorCollectionTimeSpentPerMinMs);
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

        internal string BuildUrlStringJvmNodeGarbageCollectionMinorCollectionTimeSpentPerMin(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmGarbageCollection).Append(Dictionary.JvmGarbageCollectionMinorCollectionTimeSpentPerMinMs);
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

        internal string BuildUrlStringJvmTierGarbageCollectionNumberOfMajorCollectionTimeSpentPerMin(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmGarbageCollection).Append(Dictionary.JvmGarbageCollectionNumberOfMajorCollectionPerMin);
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

        internal string BuildUrlStringJvmNodeGarbageCollectionNumberOfMajorCollectionTimeSpentPerMin(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmGarbageCollection).Append(Dictionary.JvmGarbageCollectionNumberOfMajorCollectionPerMin);
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

        internal string BuildUrlStringJvmTierGarbageCollectionNumberOfMinorCollectionTimeSpentPerMin(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmGarbageCollection).Append(Dictionary.JvmGarbageCollectionNumberOfMinorCollectionsPerMin);
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

        internal string BuildUrlStringJvmNodeGarbageCollectionNumberOfMinorCollectionTimeSpentPerMin(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmGarbageCollection).Append(Dictionary.JvmGarbageCollectionNumberOfMinorCollectionsPerMin);
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

        /* *************************** Memory ****************************** */

        internal string BuildUrlStringJvmTierMemoryHeapCommittedMb(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryHeap).Append(Dictionary.JvmMemoryHeapCommitedMb);
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

        internal string BuildUrlStringJvmNodeMemoryHeapCommittedMb(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryHeap).Append(Dictionary.JvmMemoryHeapCommitedMb);
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

        internal string BuildUrlStringJvmTierMemoryHeapCurrentUsageMb(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryHeap).Append(Dictionary.JvmMemoryHeapCurrentUsageMb);
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

        internal string BuildUrlStringJvmNodeMemoryHeapCurrentUsageMb(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryHeap).Append(Dictionary.JvmMemoryHeapCurrentUsageMb);
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

        internal string BuildUrlStringJvmTierMemoryHeapMaxAvailableMb(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryHeap).Append(Dictionary.JvmMemoryHeapMaxAvailableMb);
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

        internal string BuildUrlStringJvmNodeMemoryHeapMaxAvailableMb(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryHeap).Append(Dictionary.JvmMemoryHeapMaxAvailableMb);
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

        internal string BuildUrlStringJvmTierMemoryHeapUsedPerc(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryHeap).Append(Dictionary.JvmMemoryHeapUsedPerc);
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

        internal string BuildUrlStringJvmNodeMemoryHeapUsedPerc(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryHeap).Append(Dictionary.JvmMemoryHeapUsedPerc);
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

        /* **** Non-Heap ***** */

        internal string BuildUrlStringJvmTierMemoryNonHeapCommittedMb(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryNonHeap).Append(Dictionary.JvmMemoryHeapCommitedMb);
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

        internal string BuildUrlStringJvmNodeMemoryNonHeapCommittedMb(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryNonHeap).Append(Dictionary.JvmMemoryHeapCommitedMb);
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

        internal string BuildUrlStringJvmTierMemoryNonHeapCurrentUsageMb(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryNonHeap).Append(Dictionary.JvmMemoryHeapCurrentUsageMb);
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

        internal string BuildUrlStringJvmNodeMemoryNonHeapCurrentUsageMb(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryNonHeap).Append(Dictionary.JvmMemoryHeapCurrentUsageMb);
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

        internal string BuildUrlStringJvmTierMemoryNonHeapMaxAvailableMb(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryNonHeap).Append(Dictionary.JvmMemoryHeapMaxAvailableMb);
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

        internal string BuildUrlStringJvmNodeMemoryNonHeapMaxAvailableMb(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryNonHeap).Append(Dictionary.JvmMemoryHeapMaxAvailableMb);
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

        internal string BuildUrlStringJvmTierMemoryNonHeapUsedPerc(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryNonHeap).Append(Dictionary.JvmMemoryHeapUsedPerc);
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

        internal string BuildUrlStringJvmNodeMemoryNonHeapUsedPerc(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.HdJvmMemory).Append(Dictionary.JvmMemoryNonHeap).Append(Dictionary.JvmMemoryHeapUsedPerc);
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

        internal string BuildUrlStringJvmTierThreadsCurrentNoOfThreads(string baseUrl, string application, string tier, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmThreadsCurrentNoOfThreads);
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

        internal string BuildUrlStringJvmNodeCurrentNoOfThreads(string baseUrl, string application, string tier, string node, long start, long end, bool rollup)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.ApplicationInfraPerf);
            builder.Append(tier);
            builder.Append(Dictionary.IndividualNodes).Append(node).Append(Dictionary.Jvm);
            builder.Append(Dictionary.JvmThreadsCurrentNoOfThreads);
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