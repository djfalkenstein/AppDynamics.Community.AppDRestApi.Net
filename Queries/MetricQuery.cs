namespace AppDynamics.Community.AppDRestApi.Net.Queries
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class MetricQuery
    {
        protected internal string BaseUrl;
        protected internal string Application;
        readonly AgentAvailabilityMetricQuery _amq = new AgentAvailabilityMetricQuery();
        readonly HardwareResourcesMetricQuery _hrmq = new HardwareResourcesMetricQuery();
        readonly JvmMetricQuery _jmq = new JvmMetricQuery();
        readonly OverAllPerformanceMetricQuery _oapq = new OverAllPerformanceMetricQuery();
        readonly EumMetricQuery _emq = new EumMetricQuery();
        readonly BusinessTransactionQuery _btq = new BusinessTransactionQuery();
        readonly BackendsQuery _bq = new BackendsQuery();
        public MetricQuery(string baseUrl, string application)
        {
            BaseUrl = baseUrl;
            Application = application;
        }

        public virtual string BuildUrlStringAgentTierAppAgentAvailability(string tier, long start, long end, bool rollup)
        {
            return _amq.BuildUrlStringAgentTierAppAgentAvailability(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringAgentNodeAppAgentAvailability(string tier, string node, long start, long end, bool rollup)
        {
            return _amq.BuildUrlStringAgentNodeAppAgentAvailability(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringAgentTierMachineAgentAvailability(string tier, long start, long end, bool rollup)
        {
            return _amq.BuildUrlStringAgentTierMachineAgentAvailability(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringAgentNodeMachineAgentAvailability(string tier, string node, long start, long end, bool rollup)
        {
            return _amq.BuildUrlStringAgentNodeMachineAgentAvailability(BaseUrl, Application, tier, node, start, end, rollup);
        }

        /* ************************* Hardware Resources CPU *******************************  */

        public virtual string BuildUrlStringHdTierCpuBusy(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierCpuBusy(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeCpuBusy(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeCpuBusy(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierCpuIdle(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierCpuIdle(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeCpuIdle(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeCpuIdle(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierCpuStolen(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierCpuStolen(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeCpuStolen(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeCpuStolen(BaseUrl, Application, tier, node, start, end, rollup);
        }

        /* ************************* Hardware Resources Disk *******************************   */

        public virtual string BuildUrlStringHdTierDisksKbReadPerSec(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierDisksKbReadPerSec(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeDisksKbReadPerSec(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeDisksKbReadPerSec(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierDisksKbWrittenPerSec(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierDisksKbWrittenPerSec(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeDisksKbWrittenPerSec(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeDisksKbWrittenPerSec(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierDisksReadPerSec(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierDisksReadPerSec(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeDisksReadPerSec(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeDisksReadPerSec(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierDisksWritesPerSec(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierDisksWritesPerSec(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeDisksWritesPerSec(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeDisksWritesPerSec(BaseUrl, Application, tier, node, start, end, rollup);
        }

        /* ************************* Hardware Resources Memory *******************************   */

        public virtual string BuildUrlStringHdTierMemoryFreePerc(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierMemoryFreePerc(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeMemoryFreePerc(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeMemoryFreePerc(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierMemoryFreeMb(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierMemoryFreeMb(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeMemoryFreeMb(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeMemoryFreeMb(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierMemoryTotalMb(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierMemoryTotalMb(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeMemoryTotalMb(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeMemoryTotalMb(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierMemoryUsedPerc(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierMemoryUsedPerc(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeMemoryUsedPerc(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeMemoryUsedPerc(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierMemoryUsedMb(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierMemoryUsedMb(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeMemoryUsedMb(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeMemoryUsedMb(BaseUrl, Application, tier, node, start, end, rollup);
        }

        /* ************************* Hardware Resources Network *******************************   */

        public virtual string BuildUrlStringHdTierNetworkIncomingKb(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierNetworkIncomingKb(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeNetworkIncomingKb(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeNetworkIncomingKb(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierNetworkIncomingKbPerSec(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierNetworkIncomingKbPerSec(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeNetworkIncomingKbPerSec(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeNetworkIncomingKbPerSec(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierNetworkIncomingPackets(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierNetworkIncomingPackets(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeNetworkIncomingPackets(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeNetworkIncomingPackets(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierNetworkIncomingPacketsPerSec(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierNetworkIncomingPacketsPerSec(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeNetworkIncomingPacketsPerSec(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeNetworkIncomingPacketsPerSec(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierNetworkOutgoingKb(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierNetworkOutgoingKb(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeNetworkOutgoingKb(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeNetworkOutgoingKb(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierNetworkOutgoingKbPerSec(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierNetworkOutgoingKbPerSec(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeNetworkOutgoingKbPerSec(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeNetworkOutgoingKbPerSec(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierNetworkOutgoingPackets(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierNetworkOutgoingPackets(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeNetworkOutgoingPackets(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeNetworkOutgoingPackets(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string BuildUrlStringHdTierNetworkOutgoingPacketsPerSec(string tier, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdTierNetworkOutgoingPacketsPerSec(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string BuildUrlStringHdNodeNetworkOutgoingPacketsPerSec(string tier, string node, long start, long end, bool rollup)
        {
            return _hrmq.BuildUrlStringHdNodeNetworkOutgoingPacketsPerSec(BaseUrl, Application, tier, node, start, end, rollup);
        }

        /*  JVM metrics */

        public virtual string QueryJvmTierProcessCpuBurntMsPerMin(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierProcessCpuBurntMsPerMin(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeProcessCpuBurntMsPerMin(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeProcessCpuBurntMsPerMin(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierProcessCpuUsagePerc(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierProcessCpuUsagePerc(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeProcessCpuUsagePerc(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeProcessCpuUsagePerc(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierGarbageCollectionGcTimeSpentPerMin(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierGarbageCollectionGcTimeSpentPerMin(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeGarbageCollectionGcTimeSpentPerMin(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeGarbageCollectionGcTimeSpentPerMin(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierGarbageCollectionMajorCollectionTimeSpentPerMin(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierGarbageCollectionMajorCollectionTimeSpentPerMin(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeGarbageCollectionMajorCollectionTimeSpentPerMin(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeGarbageCollectionMajorCollectionTimeSpentPerMin(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierGarbageCollectionMinorCollectionTimeSpentPerMin(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierGarbageCollectionMinorCollectionTimeSpentPerMin(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeGarbageCollectionMinorCollectionTimeSpentPerMin(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeGarbageCollectionMinorCollectionTimeSpentPerMin(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierGarbageCollectionNumberOfMajorCollectionTimeSpentPerMin(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierGarbageCollectionNumberOfMajorCollectionTimeSpentPerMin(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeGarbageCollectionNumberOfMajorCollectionTimeSpentPerMin(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeGarbageCollectionNumberOfMajorCollectionTimeSpentPerMin(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierGarbageCollectionNumberOfMinorCollectionTimeSpentPerMin(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierGarbageCollectionNumberOfMinorCollectionTimeSpentPerMin(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeGarbageCollectionNumberOfMinorCollectionTimeSpentPerMin(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeGarbageCollectionNumberOfMinorCollectionTimeSpentPerMin(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierMemoryHeapCommittedMb(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierMemoryHeapCommittedMb(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeMemoryHeapCommittedMb(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeMemoryHeapCommittedMb(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierMemoryHeapCurrentUsageMb(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierMemoryHeapCurrentUsageMb(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeMemoryHeapCurrentUsageMb(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeMemoryHeapCurrentUsageMb(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierMemoryHeapMaxAvailableMb(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierMemoryHeapMaxAvailableMb(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeMemoryHeapMaxAvailableMb(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeMemoryHeapMaxAvailableMb(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierMemoryHeapUsedPerc(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierMemoryHeapUsedPerc(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeMemoryHeapUsedPerc(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeMemoryHeapUsedPerc(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierMemoryNonHeapCommittedMb(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierMemoryNonHeapCommittedMb(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeMemoryNonHeapCommittedMb(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeMemoryNonHeapCommittedMb(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierMemoryNonHeapCurrentUsageMb(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierMemoryNonHeapCurrentUsageMb(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeMemoryNonHeapCurrentUsageMb(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeMemoryNonHeapCurrentUsageMb(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierMemoryNonHeapMaxAvailableMb(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierMemoryNonHeapMaxAvailableMb(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeMemoryNonHeapMaxAvailableMb(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeMemoryNonHeapMaxAvailableMb(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierMemoryNonHeapUsedPerc(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierMemoryNonHeapUsedPerc(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeMemoryNonHeapUsedPerc(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeMemoryNonHeapUsedPerc(BaseUrl, Application, tier, node, start, end, rollup);
        }

        public virtual string QueryJvmTierThreadsCurrentNoOfThreads(string tier, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmTierMemoryNonHeapCurrentUsageMb(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryJvmNodeThreadsCurrentNoOfThreads(string tier, string node, long start, long end, bool rollup)
        {
            return _jmq.BuildUrlStringJvmNodeMemoryNonHeapCurrentUsageMb(BaseUrl, Application, tier, node, start, end, rollup);
        }

        /*  Overall Application Performance */

        //Stall Count
        public virtual string QueryOapAppStallCount(long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapAppStallCount(BaseUrl, Application, start, end, rollup);
        }

        public virtual string QueryOapTierStallCount(string tier, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapTierStallCount(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryOapNodeStallCount(string tier, string node, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapNodeStallCount(BaseUrl, Application, tier, node, start, end, rollup);
        }

        //Number of Very Slow Call
        public virtual string QueryOapAppNumberOfVerySlowCalls(long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapAppNumberOfVerySlowCalls(BaseUrl, Application, start, end, rollup);
        }

        public virtual string QueryOapTierNumberOfVerySlowCalls(string tier, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapTierNumberOfVerySlowCalls(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryOapNodeNumberOfVerySlowCalls(string tier, string node, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapNodeStallCount(BaseUrl, Application, tier, node, start, end, rollup);
        }

        //Number of Slow Calls
        public virtual string QueryOapAppNumberOfSlowCalls(long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapAppNumberOfSlowCalls(BaseUrl, Application, start, end, rollup);
        }

        public virtual string QueryOapTierNumberOfSlowCalls(string tier, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapTierNumberOfSlowCalls(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryOapNodeNumberOfSlowCalls(string tier, string node, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapNodeNumberOfSlowCalls(BaseUrl, Application, tier, node, start, end, rollup);
        }

        //Infrastructure Errors per Minute
        public virtual string QueryOapAppInfrastructureErrorsPerMinute(string tier, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapAppInfrastructureErrorsPerMinute(BaseUrl, Application, start, end, rollup);
        }

        public virtual string QueryOapTierInfrastructureErrorsPerMinute(string tier, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapTierInfrastructureErrorsPerMinute(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryOapNodeInfrastructureErrorsPerMinute(string tier, string node, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapNodeInfrastructureErrorsPerMinute(BaseUrl, Application, tier, node, start, end, rollup);
        }

        //HTTP Error Codes per Minute
        public virtual string QueryOapAppHttpErrorCodesPerMinute(long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapAppHttpErrorCodesPerMinute(BaseUrl, Application, start, end, rollup);
        }

        public virtual string QueryOapTierHttpErrorCodesPerMinute(string tier, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapTierHttpErrorCodesPerMinute(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryOapNodeHttpErrorCodesPerMinute(string tier, string node, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapNodeHttpErrorCodesPerMinute(BaseUrl, Application, tier, node, start, end, rollup);
        }

        //Exceptions per Minute
        public virtual string QueryOapAppExceptionsPerMinute(long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapAppExceptionsPerMinute(BaseUrl, Application, start, end, rollup);
        }

        public virtual string QueryOapTierExceptionsPerMinute(string tier, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapTierExceptionsPerMinute(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryOapNodeExceptionsPerMinute(string tier, string node, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapNodeExceptionsPerMinute(BaseUrl, Application, tier, node, start, end, rollup);
        }

        //Errors per Minute
        public virtual string QueryOapAppErrorsPerMinute(string tier, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapAppErrorsPerMinute(BaseUrl, Application, start, end, rollup);
        }

        public virtual string QueryOapTierErrorsPerMinute(string tier, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapTierErrorsPerMinute(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryOapNodeErrorsPerMinute(string tier, string node, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapNodeErrorsPerMinute(BaseUrl, Application, tier, node, start, end, rollup);
        }

        //Error Page Redirects per Minute
        public virtual string QueryOapAppErrorPageRedirectsPerMinute(string tier, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapAppErrorPageRedirectsPerMinute(BaseUrl, Application, start, end, rollup);
        }

        public virtual string QueryOapTierErrorPageRedirectsPerMinute(string tier, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapTierErrorPageRedirectsPerMinute(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryOapNodeErrorPageRedirectsPerMinute(string tier, string node, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapNodeErrorPageRedirectsPerMinute(BaseUrl, Application, tier, node, start, end, rollup);
        }

        //CallsPerMinute
        public virtual string QueryOapAppCallsPerMinute(long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapAppCallsPerMinute(BaseUrl, Application, start, end, rollup);
        }

        public virtual string QueryOapTierCallsPerMinute(string tier, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapTierCallsPerMinute(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryOapNodeCallsPerMinute(string tier, string node, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapNodeCallsPerMinute(BaseUrl, Application, tier, node, start, end, rollup);
        }

        // Avg Response Time
        public virtual string QueryOapAppAvgResponseTimeMs(long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapAppAvgResponseTimeMs(BaseUrl, Application, start, end, rollup);
        }

        public virtual string QueryOapTierAvgResponseTimeMs(string tier, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapTierAvgResponseTimeMs(BaseUrl, Application, tier, start, end, rollup);
        }

        public virtual string QueryOapNodeAvgResponseTimeMs(string tier, string node, long start, long end, bool rollup)
        {
            return _oapq.BuildUrlStringOapNodeAvgResponseTimeMs(BaseUrl, Application, tier, node, start, end, rollup);
        }

        /* Eum AJAX */

        public virtual string QueryEumAjaxRequestsPerMin(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumAjaxRequestsPerMin(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumAjaxRequestsErrorsPerMin(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumAjaxRequestsErrorsPerMin(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumAjaxDocDownloadTime(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumAjaxDocDownloadTime(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumAjaxDocProcessingTime(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumAjaxDocProcessingTime(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumAjaxEndUserResponseTime(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumAjaxEndUserResponseTime(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumAjaxFirstByteTimeMs(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumAjaxFirstByteTimeMs(BaseUrl, Application, urlPath, start, end, rollup);
        }

        /* Eum BASE PAGES */

        public virtual string QueryEumBasePagesRequestsPerMin(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumBasePagesRequestsPerMin(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumBasePagesDocReadyTimeMs(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumBasePagesDocReadyTimeMs(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumBasePagesDocDownloadTime(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumBasePagesDocDownloadTime(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumBasePagesDocProcessingTime(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumBasePagesDocProcessingTime(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumBasePagesEndUserResponseTime(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumBasePagesEndUserResponseTime(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumBasePagesFirstByteTimeMs(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumBasePagesFirstByteTimeMs(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumBasePagesFrontEndTimeMs(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumBasePagesFrontEndTimeMs(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumBasePagesPageRenderTimeMs(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumBasePagesPageRenderTimeMs(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumBasePagesPageViewsWithJavascriptErrorsPerMinute(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumBasePagesPageViewsWithJavascriptErrorsPerMinute(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumBasePagesResponseAvailableTimeMs(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumBasePagesResponseAvailableTimeMs(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumBasePagesServerConnectionTimeMs(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumBasePagesServerConnectionTimeMs(BaseUrl, Application, urlPath, start, end, rollup);
        }

        public virtual string QueryEumBasePagesSyntheticRequestsPerMinute(string urlPath, long start, long end, bool rollup)
        {
            return _emq.BuildUrlStringEumBasePagesSyntheticRequestsPerMinute(BaseUrl, Application, urlPath, start, end, rollup);
        }

        /*
         *  ***********************************************************************
         *    Business Transaction Metric Querys
         */

        public virtual string QueryBtAverageBlockTimeMs(string application, string tier, string site, long start, long end, bool rollup)
        {
            return _btq.QueryBtAverageBlockTimeMs(BaseUrl, application, tier, site, start, end, rollup);
        }

        public virtual string QueryBtAverageCpuUsedMs(string application, string tier, string site, long start, long end, bool rollup)
        {
            return _btq.QueryBtAverageCpuUsedMs(BaseUrl, application, tier, site, start, end, rollup);
        }

        public virtual string QueryBtAverageRequestSize(string application, string tier, string site, long start, long end, bool rollup)
        {
            return _btq.QueryBtAverageRequestSize(BaseUrl, application, tier, site, start, end, rollup);
        }

        public virtual string QueryBtAverageResponseTime(string application, string tier, string site, long start, long end, bool rollup)
        {
            return _btq.QueryBtAverageResponseTime(BaseUrl, application, tier, site, start, end, rollup);
        }

        public virtual string QueryBtAverageWaitTimeMs(string application, string tier, string site, long start, long end, bool rollup)
        {
            return _btq.QueryBtAverageWaitTimeMs(BaseUrl, application, tier, site, start, end, rollup);
        }

        public virtual string QueryBtCallPerMinute(string application, string tier, string site, long start, long end, bool rollup)
        {
            return _btq.QueryBtCallPerMinute(BaseUrl, application, tier, site, start, end, rollup);
        }

        public virtual string QueryBtErrorsPerMinute(string application, string tier, string site, long start, long end, bool rollup)
        {
            return _btq.QueryBtErrorsPerMinute(BaseUrl, application, tier, site, start, end, rollup);
        }

        public virtual string QueryBtNormalAverageResponseTimeMs(string application, string tier, string site, long start, long end, bool rollup)
        {
            return _btq.QueryBtNormalAverageResponseTimeMs(BaseUrl, application, tier, site, start, end, rollup);
        }

        public virtual string QueryBtNumberOfSlowCalls(string application, string tier, string site, long start, long end, bool rollup)
        {
            return _btq.QueryBtNumberOfSlowCalls(BaseUrl, application, tier, site, start, end, rollup);
        }

        public virtual string QueryBtNumberOfVerySlowCalls(string application, string tier, string site, long start, long end, bool rollup)
        {
            return _btq.QueryBtNumberOfVerySlowCalls(BaseUrl, application, tier, site, start, end, rollup);
        }

        public virtual string QueryBtStallCount(string application, string tier, string site, long start, long end, bool rollup)
        {
            return _btq.QueryBtStallCount(BaseUrl, application, tier, site, start, end, rollup);
        }

        /*
         * *************************************************************************
         *              Backends
         */

        public virtual string QueryBackendAverageResponseTimeMs(string application, string tier, long start, long end, bool rollup)
        {
            return _bq.BuildUrlStringBackendAverageResponseTimeMs(BaseUrl, application, tier, start, end, rollup);
        }

        public virtual string QueryBackendCallsPerMinute(string application, string tier, long start, long end, bool rollup)
        {
            return _bq.BuildUrlStringBackendCallsPerMinute(BaseUrl, application, tier, start, end, rollup);
        }

        public virtual string QueryBackendErrorsPerMinute(string application, string tier, long start, long end, bool rollup)
        {
            return _bq.BuildUrlStringBackendErrorsPerMinute(BaseUrl, application, tier, start, end, rollup);
        }
    }
}