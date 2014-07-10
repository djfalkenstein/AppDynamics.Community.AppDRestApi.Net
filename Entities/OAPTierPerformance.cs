using System.Collections.Generic;
using AppDynamics.Community.AppDRestApi.Net.Objects;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class OapTierPerformance : OapNodePerformance
    {
        private List<TierPerformanceRange>_tierPerfRange = new List<TierPerformanceRange>();
        private List<OapNodePerformance> _oapNodePerf = new List<OapNodePerformance>();

        internal string TpName { get; set; }
        internal int TpId { get; set; }

        public OapTierPerformance(string name)
        {
            TpName = name;
        }

        public OapTierPerformance(string name, int id)
        {
            TpName = name;
            TpId = id;
        }

        protected OapTierPerformance()
        {
            throw new System.NotImplementedException();
        }

        public virtual List<TierPerformanceRange> TierPerfRange
        {
            get
            {
                return _tierPerfRange;
            }
            set
            {
                _tierPerfRange = value;
            }
        }

        public virtual List<OapNodePerformance> OapNodePerf
        {
            get
            {
                return _oapNodePerf;
            }
            set
            {
                _oapNodePerf = value;
            }
        }

        /*
         *      case 38 : query=mq.QueryOapNodeStallCount(tier,node, start, end);
            case 39 : query=mq.QueryOapNodeNumberOfVerySlowCalls(tier,node, start, end);
            case 40 : query=mq.QueryOapNodeNumberOfSlowCalls(tier,node, start, end);
            case 41 : query=mq.QueryOapNodeInfrastructureErrorsPerMinute(tier,node, start, end);
            case 42 : query=mq.QueryOapNodeHttpErrorCodesPerMinute(tier,node, start, end);
            case 43 : query=mq.QueryOapNodeExceptionsPerMinute(tier,node, start, end);
            case 44 : query=mq.QueryOapNodeErrorsPerMinute(tier,node, start, end);
            case 45 : query=mq.QueryOapNodeErrorPageRedirectsPerMinute(tier,node, start, end);
            case 46 : query=mq.QueryOapNodeCallsPerMinute(tier,node, start, end);
            case 47 : query=mq.QueryOapNodeAvgResponseTimeMs(tier,node, start, end);
         *
         */

        public virtual void PopulatePerfMetrics(List<TimeRange> timeRanges, RestAccess.MetricQueries access, string app)
        {
            foreach (OapNodePerformance node in _oapNodePerf)
            {
                //ToDo: What is this doing?
                foreach (TimeRange tRange in timeRanges)
                {
                    NodePerformanceRange nodeRange = new NodePerformanceRange();
                    nodeRange.CreateName();
                    node.NodePerfRange.Add(nodeRange);
                }

                List<MetricValue> stallCount = GetMetricValues(access.GetRestMetricQuery(38, app, TpName, node.Node.TierName, TotalTimeRange.TrStart, TotalTimeRange.TrEnd));

                List<MetricValue> numberOfVerySlowCalls = GetMetricValues(access.GetRestMetricQuery(39, app, TpName, node.Node.TierName, TotalTimeRange.TrStart, TotalTimeRange.TrEnd));

                List<MetricValue> numberOfSlowCalls = GetMetricValues(access.GetRestMetricQuery(40, app, TpName, node.Node.TierName, TotalTimeRange.TrStart, TotalTimeRange.TrEnd));

                List<MetricValue> infraErrorsPerMinute = GetMetricValues(access.GetRestMetricQuery(41, app, TpName, node.Node.TierName, TotalTimeRange.TrStart, TotalTimeRange.TrEnd));

                List<MetricValue> httpErrorCodesPerMinute = GetMetricValues(access.GetRestMetricQuery(42, app, TpName, node.Node.TierName, TotalTimeRange.TrStart, TotalTimeRange.TrEnd));

                List<MetricValue> exceptionsPerMinute = GetMetricValues(access.GetRestMetricQuery(43, app, TpName, node.Node.TierName, TotalTimeRange.TrStart, TotalTimeRange.TrEnd));

                List<MetricValue> errorsPerMinute = GetMetricValues(access.GetRestMetricQuery(44, app, TpName, node.Node.TierName, TotalTimeRange.TrStart, TotalTimeRange.TrEnd));

                List<MetricValue> errorPageRedirectPerMinute = GetMetricValues(access.GetRestMetricQuery(45, app, TpName, node.Node.TierName, TotalTimeRange.TrStart, TotalTimeRange.TrEnd));

                List<MetricValue> callsPerMinute = GetMetricValues(access.GetRestMetricQuery(46, app, TpName, node.Node.TierName, TotalTimeRange.TrStart, TotalTimeRange.TrEnd));

                List<MetricValue> avgResponseTime = GetMetricValues(access.GetRestMetricQuery(47, app, TpName, node.Node.TierName, TotalTimeRange.TrStart, TotalTimeRange.TrEnd));

                foreach (NodePerformanceRange nodeRange in node.NodePerfRange)
                {
                    foreach (MetricValue val in stallCount)
                    {
                        if (nodeRange.IsWithIn(val.StartTimeInMillis))
                        {
                            nodeRange.StallCountValues.Add(val);
                        }
                    }

                    foreach (MetricValue val in numberOfVerySlowCalls)
                    {
                        if (nodeRange.IsWithIn(val.StartTimeInMillis))
                        {
                            nodeRange.NumberOfVerySlowCallsValues.Add(val);
                        }
                    }

                    foreach (MetricValue val in numberOfSlowCalls)
                    {
                        if (nodeRange.IsWithIn(val.StartTimeInMillis))
                        {
                            nodeRange.NumberOfSlowCallsValues.Add(val);
                        }
                    }

                    foreach (MetricValue val in infraErrorsPerMinute)
                    {
                        if (nodeRange.IsWithIn(val.StartTimeInMillis))
                        {
                            nodeRange.InfrastructureErrorsPerMinuteValues.Add(val);
                        }
                    }

                    foreach (MetricValue val in httpErrorCodesPerMinute)
                    {
                        if (nodeRange.IsWithIn(val.StartTimeInMillis))
                        {
                            nodeRange.HttpErrorCodesPerMinuteValues.Add(val);
                        }
                    }

                    foreach (MetricValue val in exceptionsPerMinute)
                    {
                        if (nodeRange.IsWithIn(val.StartTimeInMillis))
                        {
                            nodeRange.ExceptionsPerMinuteValues.Add(val);
                        }
                    }

                    foreach (MetricValue val in errorsPerMinute)
                    {
                        if (nodeRange.IsWithIn(val.StartTimeInMillis))
                        {
                            nodeRange.ErrorsPerMinuteValues.Add(val);
                        }
                    }

                    foreach (MetricValue val in errorPageRedirectPerMinute)
                    {
                        if (nodeRange.IsWithIn(val.StartTimeInMillis))
                        {
                            nodeRange.ErrorPageRedirectsPerMinuteValues.Add(val);
                        }
                    }

                    foreach (MetricValue val in callsPerMinute)
                    {
                        if (nodeRange.IsWithIn(val.StartTimeInMillis))
                        {
                            nodeRange.CallsPerMinuteValues.Add(val);
                        }
                    }

                    foreach (MetricValue val in avgResponseTime)
                    {
                        if (nodeRange.IsWithIn(val.StartTimeInMillis))
                        {
                            nodeRange.AvgResponseTimeValues.Add(val);
                        }
                    }
                    nodeRange.UpdateCounts();
                }
            }
        }

        public virtual List<MetricValue> GetMetricValues(List<MetricData> mds)
        {
            List<MetricValue> values = new List<MetricValue>();
            //if (mds != null && mds.MetricData.Count > 0)
            //{
            //    if (mds.MetricData[0].MetricValues.size() > 0)
            //    {
            //        values = mds.MetricData[0].MetricValues.get(0).MetricValue;
            //    }
            //}
            return values;
        }
    }
}