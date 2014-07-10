using System;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    ///
    /// The key for this function is to find the name of the metric and be able to
    /// return the proper name, title or identification for the
    /// </summary>
    public class MetricNameUtil
    {
        public const string IndivNodes = "Individual Nodes";

        public string[] Parse(string metricPath)
        {
            if (metricPath == null) return null;
            return metricPath.Split(Convert.ToChar("|"));
        }

        public string GetMetricName(string metricPath)
        {
            string[] nameParts = Parse(metricPath);

            if (nameParts == null)
            {
                return "Default Name";
            }

            bool node = metricPath.Contains(Dictionary.IndividualNodes);

            // The problem, how can we determine which is the tier name because it will be hidden or will it?
            if (metricPath.StartsWith(Dictionary.ApplicationInfraPerf, StringComparison.Ordinal))
            {
                if (node)
                {
                    return nameParts[3];
                }
                return nameParts[1];
            }
            if (metricPath.StartsWith(Dictionary.BusinessTransactions, StringComparison.Ordinal))
            {
                return nameParts[3];
            }
            if (metricPath.StartsWith(Dictionary.EumUserExperience, StringComparison.Ordinal))
            {
                return nameParts[2];
            }
            if (metricPath.StartsWith(Dictionary.OverallApplicationPerf, StringComparison.Ordinal))
            {
                if (nameParts.Length == 3)
                {
                    return nameParts[1];
                }
                return nameParts[0];
            }
            // Need to add errors and information points

            return null;
        }
    }
}