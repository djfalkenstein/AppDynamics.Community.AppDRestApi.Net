using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// <event>
    ///  <id>390707767</id>
    ///  <type>APPLICATION_ERROR</type>
    ///  <eventTime>1397173474210</eventTime>
    ///  <severity>ERROR</severity>
    ///  <summary>com.sun.jersey.core.impl.provider.xml.SAXParserContextProvider::JAXP feature XMLConstants.FEATURE_SECURE_PROCESSING cannot be set on a SAXParserFactory. External general entity processing is disabled but other potential security related features will not be enabled. : SAXNotRecognizedException: Feature &apos;http://javax.xml.XMLConstants/feature/secure-processing&apos; is not recognized.</summary>
    ///  <affectedEntities>
    ///    <entity-definition>
    ///      <entityType>APPLICATION_COMPONENT_NODE</entityType>
    ///      <entityId>17948</entityId>
    ///    </entity-definition>
    ///    <entity-definition>
    ///      <entityType>APPLICATION</entityType>
    ///      <entityId>53</entityId>
    ///    </entity-definition>
    ///    <entity-definition>
    ///      <entityType>MACHINE_INSTANCE</entityType>
    ///      <entityId>5212</entityId>
    ///    </entity-definition>
    ///    <entity-definition>
    ///      <entityType>APPLICATION_COMPONENT</entityType>
    ///      <entityId>179</entityId>
    ///    </entity-definition>
    ///  </affectedEntities>
    ///  <markedAsRead>false</markedAsRead>
    ///  <markedAsResolved>false</markedAsResolved>
    ///  <archived>false</archived>
    ///  <deepLinkUrl>https://paid1.saas.AppDynamics.com/controller/#location=APP_EVENT_VIEWER_MODAL&amp;eventSummary=390707767</deepLinkUrl>
    /// </event>
    ///
    /// </summary>
    public class Event
    {
        public int Id { get; internal set; }
        public string Type { get; internal set; }
        public long EventTime { get; internal set; }
        public string Severity { get; internal set; }
        public string Summary { get; internal set; }
        public AffectedEntities AffectedEntities { get; internal set; }
        public bool MarkedAsRead { get; internal set; }
        public bool MarkedAsResolved { get; internal set; }
        public bool Archived { get; internal set; }
        public string DeepUrl { get; internal set; }

        public Event(int id, string type, long eventtime, string severity, string summary, AffectedEntities entities,
            bool markread, bool markresolved, bool archived, string deepurl)
        {
            Id = id;
            Type = type;
            EventTime = eventtime;
            Severity = severity;
            Summary = summary;
            AffectedEntities = entities;
            MarkedAsRead = markread;
            MarkedAsResolved = markresolved;
            Archived = archived;
            DeepUrl = deepurl;
        }
       
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.L1).Append(Dictionary.Event);
            builder.Append(Dictionary.L2).Append(Dictionary.Id).Append(Dictionary.Ve).Append(Id);
            builder.Append(Dictionary.L2).Append(Dictionary.Type).Append(Dictionary.Ve).Append(Type);
            builder.Append(Dictionary.L2).Append(Dictionary.EventTime).Append(Dictionary.Ve).Append(EventTime);
            builder.Append(Dictionary.L2).Append(Dictionary.Severity).Append(Dictionary.Ve).Append(Severity);
            builder.Append(Dictionary.L2).Append(Dictionary.Summary).Append(Dictionary.Ve).Append(Summary);
            builder.Append(Dictionary.L2).Append(Dictionary.AffectedEntities);
            builder.Append(Dictionary.L2).Append(Dictionary.MarkedAsRead).Append(Dictionary.Ve).Append(MarkedAsRead);
            builder.Append(Dictionary.L2).Append(Dictionary.MarkedAsResolved).Append(Dictionary.Ve).Append(MarkedAsResolved);
            builder.Append(Dictionary.L2).Append(Dictionary.Archived).Append(Dictionary.Ve).Append(Archived);
            builder.Append(Dictionary.L2).Append(Dictionary.DeepLinkUrl).Append(Dictionary.Ve).Append(DeepUrl);
            return builder.ToString();
        }
    }
}
