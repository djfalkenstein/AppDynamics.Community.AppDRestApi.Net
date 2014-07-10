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
    /// @author david.falkenstein@appdynamics.com
    ///
    /// <name-value>
    ///        <id>0</id>
    ///        <name>MAJOR_VERSION</name>
    ///        <value>5.6</value>
    ///    </name-value>
    ///
    /// </summary>
    public class NameValue
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string Value { get; internal set; }

        public NameValue(int id, string name, string value)
        {
            Id = id;
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.L3).Append(Dictionary.NameValue);
            builder.Append(Dictionary.L4).Append(Dictionary.Id).Append(Dictionary.Ve).Append(Id);
            builder.Append(Dictionary.L4).Append(Dictionary.Name).Append(Dictionary.Ve).Append(Name);
            builder.Append(Dictionary.L4).Append(Dictionary.Value).Append(Dictionary.Ve).Append(Value);
            return builder.ToString();
        }
    }
}