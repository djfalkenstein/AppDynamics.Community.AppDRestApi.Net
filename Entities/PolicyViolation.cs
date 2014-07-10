using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Entities

{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    ///
    /// Whether the call is for policy violations or health rule violation.
    ///
    /// <policy-violation>
    ///  <id>143518</id>
    ///  <name>JVM Heap utilization is too high</name>
    ///  <startTimeInMillis>1396925759376</startTimeInMillis>
    ///  <detectedTimeInMillis>0</detectedTimeInMillis>
    ///  <endTimeInMillis>0</endTimeInMillis>
    ///  <incidentStatus>OPEN</incidentStatus>
    ///  <severity>WARNING</severity>
    ///  <triggeredEntityDefinition>
    ///    <entityType>POLICY</entityType>
    ///    <entityId>373</entityId>
    ///  </triggeredEntityDefinition>
    ///  <affectedEntityDefinition>
    ///    <entityType>APPLICATION_COMPONENT_NODE</entityType>
    ///    <entityId>19903</entityId>
    ///  </affectedEntityDefinition>
    ///  <deepLinkUrl>https://paid1.saas.AppDynamics.com/controller/#location=APP_INCIDENT_DETAIL&amp;incident=143518</deepLinkUrl>
    ///  <description>JVM Heap utilization is too high</description>
    /// </policy-violation>
    ///
    /// </summary>
    public class PolicyViolation
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal long StartTimeInMillis { get; set; }
        internal long DetectedTimeInMillis { get; set; }
        internal long EndTimeInMillis { get; set; }
        internal string IncidentStatus { get; set; }
        internal string Severity { get; set; }
        internal TriggeredEntityDefinition TriggeredEntity { get; set; }
        internal AffectedEntityDefinition AffectedEntityDefinition { get; set; }
        internal string DeepUrl { get; set; }
        internal string Description { get; set; }

        public PolicyViolation(int id, string name, long starttime, long dettime, long endtime, string incstatus, string severity,
            TriggeredEntityDefinition trigentity, AffectedEntityDefinition afftectedentity, string deepurl,
            string description)
        {
            Id = id;
            Name = name;
            StartTimeInMillis = starttime;
            DetectedTimeInMillis = dettime;
            EndTimeInMillis = endtime;
            IncidentStatus = incstatus;
            Severity = severity;
            TriggeredEntity = trigentity;
            AffectedEntityDefinition = afftectedentity;
            DeepUrl = deepurl;
            Description = description;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.L1).Append(Dictionary.PolicyViolation);
            builder.Append(Dictionary.L2).Append(Dictionary.Id).Append(Dictionary.Ve).Append(Id);
            builder.Append(Dictionary.L2).Append(Dictionary.Name).Append(Dictionary.Ve).Append(Name);
            builder.Append(Dictionary.L2).Append(Dictionary.StartTimeInMillis).Append(Dictionary.Ve).Append(StartTimeInMillis);
            builder.Append(Dictionary.L2).Append(Dictionary.DetectedTimeInMillis).Append(Dictionary.Ve).Append(DetectedTimeInMillis);
            builder.Append(Dictionary.L2).Append(Dictionary.EndTimeInMillis).Append(Dictionary.Ve).Append(EndTimeInMillis);
            builder.Append(Dictionary.L2).Append(Dictionary.IncidentStatus).Append(Dictionary.Ve).Append(IncidentStatus);
            builder.Append(Dictionary.L2).Append(Dictionary.Severity).Append(Dictionary.Ve).Append(Severity);
            builder.Append(AffectedEntityDefinition);
            builder.Append(TriggeredEntity);
            builder.Append(Dictionary.L2).Append(Dictionary.DeepLinkUrl).Append(Dictionary.Ve).Append(DeepUrl);
            builder.Append(Dictionary.L2).Append(Dictionary.Description).Append(Dictionary.Ve).Append(Description);
            return builder.ToString();
        }
    }
}