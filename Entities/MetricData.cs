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
    /// </summary>

    public class MetricData
    {
        private List<MetricValues> _metricValues = new List<MetricValues>();
        public string MetricPath { get; set; }
        public string Frequency { get; set; }

        public MetricData(string path, string freq, List<MetricValues> values)
        {
            MetricPath = path;
            Frequency = freq;
            _metricValues = values;
        }

        public virtual List<MetricValues> MetricValues
        {
            get
            {
                return _metricValues;
            }
            internal set
            {
                _metricValues = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\tFrequency :: ").Append(Frequency).Append("\n");
            builder.Append("\tMetricPath :: ").Append(MetricPath).Append("\n");
            builder.Append("\tMetrics :: ").Append(_metricValues.Count);
            foreach (MetricValues val in _metricValues)
            {
                builder.Append(val).Append("\n");
            }
            return builder.ToString();
        }
    }
}