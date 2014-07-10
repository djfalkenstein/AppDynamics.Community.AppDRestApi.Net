/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// <tier>
    ///  <id>6</id>
    ///  <name>2ndTier</name>
    ///  <type>Application Server</type>
    ///  <agentType>APP_AGENT</agentType>
    ///  <NumberOfNodes>2</NumberOfNodes>
    /// </tier>
    ///
    /// </summary>
    public class Tier
    {
        public int TierId { get; internal set; }
        public string TierName { get; internal set; }
        public string TierType { get; internal set; }
        public string AgentType { get; internal set; }
        public int NumberOfNodes { get; internal set; }

        public Tier(int tierid, string tierName, string tierType, string agentType, int numNodes)
        {
            TierId = tierid;
            TierName = tierName;
            TierType = tierType;
            AgentType = agentType;
            NumberOfNodes = numNodes;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\tTier Name: ").Append(TierName).Append("\n");
            builder.Append("\tTier ID: ").Append(TierId).Append("\n");
            builder.Append("\tTier Type: ").Append(TierType).Append("\n");
            builder.Append("\tTier Agent Type : ").Append(AgentType).Append("\n");
            builder.Append("\t ***************** End of tier *********************\n");
            return builder.ToString();
        }
    }
}