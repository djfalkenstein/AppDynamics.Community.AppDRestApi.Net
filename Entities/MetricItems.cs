/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Collections.Generic;
using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// </summary>
    public class MetricItems
    {
        public List<MetricItem> Metrics = new List<MetricItem>();
        public virtual List<MetricItem> GetMetricItems()
        {
            return Metrics;
        }

        public virtual void SetMetricItems(List<MetricItem> metricItems)
        {
            Metrics = metricItems;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.MetricItems);
            foreach (MetricItem mi in Metrics)
            {
                builder.Append(mi);
            }
            return builder.ToString();
        }
    }
}