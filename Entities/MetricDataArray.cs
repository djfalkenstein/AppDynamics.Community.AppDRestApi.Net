using System.Collections.Generic;
using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class MetricDataArray
    {
        private List<MetricData> _metricData = new List<MetricData>();
        internal virtual List<MetricData> MetricData
        {
            get
            {
                return _metricData;
            }
            set
            {
                _metricData = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (MetricData data in _metricData)
            {
                builder.Append("\nMetric Datas --\n").Append(data);
            }
            return builder.ToString();
        }
    }
}
