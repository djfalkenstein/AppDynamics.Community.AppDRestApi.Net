using System.Collections.Generic;
using AppDynamics.Community.AppDRestApi.Net.Objects;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// </summary>
    public class OapCustomerPerformance : OapTierPerformance
    {
        private List<CustomerPerformanceRange> _cusRange = new List<CustomerPerformanceRange>();
        private readonly List<OapAppPerformance> _oapApps = new List<OapAppPerformance>();

        public OapCustomerPerformance(string name) : base(name)
        {
        }

        public OapCustomerPerformance(string name, int id) : base(name, id)
        {
        }

        internal List<CustomerPerformanceRange> CusRange
        {
            get
            {
                return _cusRange;
            }
            set
            {
                _cusRange = value;
            }
        }

        private void PopulatePerfMetrics(List<TimeRange> timeRanges, RestAccess.NodeFunctions access)
        {
            foreach (OapAppPerformance oapApp in _oapApps)
            {
                oapApp.PopulatePerfMetrics(timeRanges, access);
            }
        }
    }
}