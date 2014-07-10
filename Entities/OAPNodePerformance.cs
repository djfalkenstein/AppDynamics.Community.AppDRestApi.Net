using System.Collections.Generic;
using AppDynamics.Community.AppDRestApi.Net.Objects;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// Overall Application Performance|activemq-instance-mytrees|Average Response Time (ms)
    ///    Overall Application Performance|activemq-instance-mytrees|Calls per Minute
    ///    Overall Application Performance|activemq-instance-mytrees|Error Page Redirects per Minute
    ///    Overall Application Performance|activemq-instance-mytrees|Errors per Minute
    ///    Overall Application Performance|activemq-instance-mytrees|Exceptions per Minute
    ///    Overall Application Performance|activemq-instance-mytrees|HTTP Error Codes per Minute
    ///    Overall Application Performance|activemq-instance-mytrees|Infrastructure Errors per Minute
    ///    Overall Application Performance|activemq-instance-mytrees|Number of Slow Calls
    ///    Overall Application Performance|activemq-instance-mytrees|Number of Very Slow Calls
    ///    Overall Application Performance|activemq-instance-mytrees|Stall Count
    /// </summary>
    public class OapNodePerformance
    {
        private List<NodePerformanceRange> _nodePerfRange = new List<NodePerformanceRange>();
        protected internal Node Node { get; set; }

        protected internal TimeRange TotalTimeRange { get; set; }

        public List<NodePerformanceRange> NodePerfRange
        {
            get { return _nodePerfRange; }
            set { _nodePerfRange = value; }
        }

        public OapNodePerformance(Node node)
        {
            Node = node;
        }

        protected OapNodePerformance()
        {
            throw new System.NotImplementedException();
        }
    }
}