/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System;
using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class MetricValue
    {
        public long Current { get; set; }
        public long Max { get; set; }
        public long Min { get; set; }
        public long StartTimeInMillis { get; set; }
        public long Value { get; set; }

        public MetricValue(long current, long max, long min, long starttime, long value )
        {
            Current = current;
            Max = max;
            Min = min;
            StartTimeInMillis = starttime;
            Value = value;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\tCurrent ::").Append(Current).Append("\n");
            builder.Append("\tValue :: ").Append(Value).Append("\n");
            builder.Append("\tMin :: ").Append(Min).Append("\n");
            builder.Append("\tMax :: ").Append(Max).Append("\n");
            builder.Append("\tTimestamp :: ").Append(StartTimeInMillis).Append("\n");
            builder.Append("\tDateTime :: ").Append((new DateTime(StartTimeInMillis))).Append("\n");
            builder.Append("\t ------------------------- End ------------------------------\n");

            return builder.ToString();
        }
    }
}