using System.Collections.Generic;
using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// </summary>
    public class AffectedEntities
    {
        private List<EntityDefinition> _entityDefinition = new List<EntityDefinition>();

        public virtual List<EntityDefinition> EntityDefinition
        {
            get
            {
                return _entityDefinition;
            }
            set
            {
                _entityDefinition = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (EntityDefinition ed in _entityDefinition)
            {
                builder.Append(Dictionary.L2).Append(Dictionary.EntityDefinition).Append(ed);
            }
            return builder.ToString();
        }
    }
}