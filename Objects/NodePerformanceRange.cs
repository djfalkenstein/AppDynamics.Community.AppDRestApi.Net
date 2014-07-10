using System.Collections.Generic;
using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Entities;

namespace AppDynamics.Community.AppDRestApi.Net.Objects
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class NodePerformanceRange : TimeRange
    {
        public List<MetricValue> AvgResponseTimeValues { get; set; }

        public List<MetricValue> CallsPerMinuteValues { get; set; }

        public List<MetricValue> ErrorPageRedirectsPerMinuteValues { get; set; }

        public List<MetricValue> ErrorsPerMinuteValues { get; set; }

        public List<MetricValue> ExceptionsPerMinuteValues { get; set; }

        public List<MetricValue> HttpErrorCodesPerMinuteValues { get; set; }

        public List<MetricValue> InfrastructureErrorsPerMinuteValues { get; set; }

        public List<MetricValue> NumberOfSlowCallsValues { get; set; }

        public List<MetricValue> NumberOfVerySlowCallsValues { get; set; }

        public List<MetricValue> StallCountValues { get; set; }

        public int AvgResponseTime { get; set; }

        public int CallsPerMinute { get; set; }

        public int ErrorPageRedirectsPerMinute { get; set; }

        public int ErrorsPerMinute { get; set; }

        public int ExceptionsPerMinute { get; set; }

        public int HttpErrorCodesPerMinute { get; set; }

        public int InfrastructureErrorsPerMinute { get; set; }

        public int NumberOfSlowCalls { get; set; }

        public int NumberOfVerySlowCalls { get; set; }

        public int StallCount { get; set; }

        //public NodePerformanceRange() : base()
        //{
        //}

        //public NodePerformanceRange(TimeRange timeR) : base()
        //{
        //    Start = timeR.trStart;
        //    End = timeR.trEnd;
        //}

        public virtual void UpdateCounts()
        {
            foreach (MetricValue val in StallCountValues)
            {
                StallCount += (int)val.Value;
            }
            if (StallCountValues.Count > 0)
            {
                StallCount = StallCount / StallCountValues.Count;
            }

            foreach (MetricValue val in NumberOfVerySlowCallsValues)
            {
                NumberOfVerySlowCalls += (int)val.Value;
            }
            if (NumberOfVerySlowCallsValues.Count > 0)
            {
                NumberOfVerySlowCalls = NumberOfVerySlowCalls / NumberOfVerySlowCallsValues.Count;
            }

            foreach (MetricValue val in NumberOfSlowCallsValues)
            {
                NumberOfSlowCalls += (int)val.Value;
            }
            if (NumberOfSlowCallsValues.Count > 0)
            {
                NumberOfSlowCalls = NumberOfSlowCalls / NumberOfSlowCallsValues.Count;
            }

            foreach (MetricValue val in InfrastructureErrorsPerMinuteValues)
            {
                InfrastructureErrorsPerMinute += (int)val.Value;
            }
            if (InfrastructureErrorsPerMinuteValues.Count > 0)
            {
                InfrastructureErrorsPerMinute = InfrastructureErrorsPerMinute / InfrastructureErrorsPerMinuteValues.Count;
            }

            foreach (MetricValue val in HttpErrorCodesPerMinuteValues)
            {
                HttpErrorCodesPerMinute += (int)val.Value;
            }
            if (HttpErrorCodesPerMinuteValues.Count > 0)
            {
                HttpErrorCodesPerMinute = HttpErrorCodesPerMinute / HttpErrorCodesPerMinuteValues.Count;
            }

            foreach (MetricValue val in ExceptionsPerMinuteValues)
            {
                ExceptionsPerMinute += (int)val.Value;
            }
            if (ExceptionsPerMinuteValues.Count > 0)
            {
                ExceptionsPerMinute = ExceptionsPerMinute / ExceptionsPerMinuteValues.Count;
            }

            foreach (MetricValue val in ErrorsPerMinuteValues)
            {
                ErrorsPerMinute += (int)val.Value;
            }
            if (ErrorsPerMinuteValues.Count > 0)
            {
                ErrorsPerMinute = ErrorsPerMinute / ErrorsPerMinuteValues.Count;
            }

            foreach (MetricValue val in ErrorPageRedirectsPerMinuteValues)
            {
                ErrorPageRedirectsPerMinute += (int)val.Value;
            }
            if (ErrorPageRedirectsPerMinuteValues.Count > 0)
            {
                ErrorPageRedirectsPerMinute = ErrorPageRedirectsPerMinute / ErrorPageRedirectsPerMinuteValues.Count;
            }

            foreach (MetricValue val in CallsPerMinuteValues)
            {
                CallsPerMinute += (int)val.Value;
            }

            foreach (MetricValue val in AvgResponseTimeValues)
            {
                AvgResponseTime += (int)val.Value;
            }
            if (AvgResponseTimeValues.Count > 0)
            {
                AvgResponseTime = AvgResponseTime / AvgResponseTimeValues.Count;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\tTime Range: ").Append(TrName).Append("\n");
            builder.Append("\t").Append(AvgResponseTime).Append("\n");
            builder.Append("\t").Append(CallsPerMinute).Append("\n");
            builder.Append("\t").Append(ErrorPageRedirectsPerMinute).Append("\n");
            builder.Append("\t").Append(ErrorsPerMinute).Append("\n");
            builder.Append("\t").Append(ExceptionsPerMinute).Append("\n");
            builder.Append("\t").Append(HttpErrorCodesPerMinute).Append("\n");
            builder.Append("\t").Append(InfrastructureErrorsPerMinute).Append("\n");
            builder.Append("\t").Append(NumberOfSlowCalls).Append("\n");
            builder.Append("\t").Append(NumberOfVerySlowCalls).Append("\n");
            builder.Append("\t").Append(StallCount).Append("\n");
            return builder.ToString();
        }
    }
}