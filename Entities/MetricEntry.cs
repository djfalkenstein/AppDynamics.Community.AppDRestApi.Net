using System.Collections.Generic;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// This is going to contain a name so that we can get the name of the metric.
    /// </summary>
    public class MetricEntry
    {
        public string MeName { get; set; }

        private List<MetricValue> _getMetrics = new List<MetricValue>();
        public MetricEntry(string name)
        {
            MeName = name;
        }

        public MetricEntry(string name, List<MetricValue> getMetrics)
        {
            MeName = name;
            _getMetrics = getMetrics;
        }

        public virtual List<MetricValue> GetMetrics
        {
            get
            {
                return _getMetrics;
            }
            set
            {
                _getMetrics = value;
            }
        }
    }
}