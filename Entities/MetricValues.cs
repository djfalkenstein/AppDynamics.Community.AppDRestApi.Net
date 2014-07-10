/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Collections.Generic;
using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    ///
    /// <metricPath>Application Infrastructure Performance|activemq-instance-mytrees|JVM|Memory|Heap|Committed (Mb)</metricPath>
    ///  <frequency>ONE_MIN</frequency>
    ///  <metricValues/>
    ///    <metric-value/>
    ///
    /// </summary>
    public class MetricValues
    {
        private List<MetricValue> _metricValue = new List<MetricValue>();

        public virtual List<MetricValue> MetricValue
        {
            get
            {
                return _metricValue;
            }
        }

        public virtual void SetMetricValues(List<MetricValue> metricValue)
        {
            _metricValue = metricValue;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\t\tMetric Value Size : ").Append(_metricValue.Count).Append("\n");
            foreach (MetricValue val in _metricValue)
            {
                builder.Append(val);
            }
            return builder.ToString();
        }
    }
}