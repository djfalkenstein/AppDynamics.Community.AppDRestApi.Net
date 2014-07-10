/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Collections.Generic;
using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// <tiers>
    /// <tier>
    ///  <id>443</id>
    ///  <name>volunteer-backend-stage</name>
    ///  <type>Application Server</type>
    ///  <agentType>APP_AGENT</agentType>
    ///  <NumberOfNodes>3</NumberOfNodes>
    /// </tier>
    /// </tiers>Dictionary
    /// </summary>

    public class Tiers
    {
        private List<Tier> _tiers = new List<Tier>();

        public virtual List<Tier> GetTiers()
        {
            return _tiers;
        }

        public virtual void SetTiers(List<Tier> tiers)
        {
            _tiers = tiers;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (Tier tier in _tiers)
            {
                builder.Append(tier);
            }
            return builder.ToString();
        }
    }
}