/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Collections.Generic;
using AppDynamics.Community.AppDRestApi.Net.Objects;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    ///
    /// There might be additional metrics for this object, for now there will not be.
    /// </summary>
    public class OapAppPerformance : OapTierPerformance
    {
        public string Name { get; internal set; }
        public int Id { get; internal set; }
        private List<ApplicationPerformanceRange> _appRange = new List<ApplicationPerformanceRange>();
        private List<OapTierPerformance> _oapTiers = new List<OapTierPerformance>();
        public OapAppPerformance(string name)
        {
            Name = name;

        }

        public OapAppPerformance(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public virtual List<ApplicationPerformanceRange> AppRange
        {
            get
            {
                return _appRange;
            }
            set
            {
                _appRange = value;
            }
        }

        public virtual List<OapTierPerformance> OapTiers
        {
            get
            {
                return _oapTiers;
            }
            set
            {
                _oapTiers = value;
            }
        }

        public virtual void PopulatePerfMetrics(List<TimeRange> timeRanges, RestAccess.NodeFunctions access)
        {
            List<Node> nodes = access.GetNodesForApplication(TpId);
            foreach (Node node in nodes)
            {
                OapTierPerformance tier = null;
                foreach (OapTierPerformance oapTier in _oapTiers)
                {
                    if (oapTier.TpId == node.TierId)
                    {
                        tier = oapTier;
                    }
                }

                if (tier == null)
                {
                    tier = new OapTierPerformance(node.TierName, node.TierId);
                    _oapTiers.Add(tier);
                }

                tier.OapNodePerf.Add(new OapNodePerformance(node));
            }
        }
    }
}