/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class MetricItem
    {
        public string Type { get; internal set; }
        public string Name { get; internal set; }

        public MetricItem(string type, string name)
        {
            Type = type;
            Name = name;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.L1).Append(Dictionary.MetricItem);
            builder.Append(Dictionary.L2).Append(Dictionary.Name).Append(Dictionary.Ve).Append(Type);
            builder.Append(Dictionary.L2).Append(Dictionary.Type).Append(Dictionary.Ve).Append(Name);
            return builder.ToString();
        }
    }
}