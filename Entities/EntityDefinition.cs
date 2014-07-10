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
    /// <affectedEntityDefinition>
    ///    <entityType>APPLICATION_COMPONENT_NODE</entityType>
    ///    <entityId>19903</entityId>
    ///  </affectedEntityDefinition>
    ///
    /// </summary>
    public class EntityDefinition
    {
        private string _entityType;
        private int _entityId;

        public virtual string EntityType
        {
            get
            {
                return _entityType;
            }
            internal set
            {
                _entityType = value;
            }
        }

        public virtual int EntityId
        {
            get
            {
                return _entityId;
            }
            internal set
            {
                _entityId = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.L3).Append("EntityType :: ").Append(_entityType);
            builder.Append(Dictionary.L3).Append("EntityId :: ").Append(_entityId);
            return builder.ToString();
        }
    }
}