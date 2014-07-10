using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// </summary>
    public class TriggeredEntityDefinition
    {
        public string EntityType { get; set; }
        public int EntityId { get; set; }

        public TriggeredEntityDefinition(int entitiyId, string entityType)
        {
            EntityId = entitiyId;
            EntityType = entityType;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.L2).Append(Dictionary.TriggeredEntityDefinition);

            builder.Append(Dictionary.L3).Append("EntityType").Append(Dictionary.Ve).Append(EntityType);
            builder.Append(Dictionary.L3).Append("EntityId").Append(Dictionary.Ve).Append(EntityId);
            return builder.ToString();
        }
    }
}