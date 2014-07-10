using System.Collections.Generic;
using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Entities;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// </summary>
    public class ApiProperties
    {
        private List<NameValue> _properties = new List<NameValue>();

        public virtual List<NameValue> GetProperties()
        {
            return _properties;
        }

        public virtual void SetProperties(List<NameValue> properties)
        {
            _properties = properties;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.L2).Append(Dictionary.Properties);
            foreach (NameValue nv in _properties)
            {
                builder.Append(nv);
            }

            return builder.ToString();
        }
    }
}
