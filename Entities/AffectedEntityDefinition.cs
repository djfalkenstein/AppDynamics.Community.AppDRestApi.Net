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
    /// </summary>
    public class AffectedEntityDefinition
    {
        public string EntityType { get; internal set; }
        public int EntityId { get; internal set; }

        public AffectedEntityDefinition(int entityId, string entityType)
        {
            EntityId = entityId;
            EntityType = entityType;
        }

        public new string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.L2).Append(Dictionary.AffectedEntityDefinition);
            builder.Append(Dictionary.L3).Append("EntityType").Append(Dictionary.Ve).Append(EntityType);
            builder.Append(Dictionary.L3).Append("EntityId").Append(Dictionary.Ve).Append(EntityId);
            return builder.ToString();
        }
    }
}