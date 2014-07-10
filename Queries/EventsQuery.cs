/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Queries
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// </summary>
    public class EventsQuery
    {
        readonly QueryEncoder _qe = new QueryEncoder();
        internal string BuildUrlStringPolicyViolationsSFromApps(string baseUrl, string application, string eventTypes, string severities, long start, long end)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(_qe.Encode(application));
            builder.Append(Dictionary.UrlEvents);
            builder.Append(Dictionary.TimeBetween1).Append(Dictionary.TimeStartTime).Append(start);
            builder.Append(Dictionary.TimeEndTime).Append(end).Append(Dictionary.EventTypes).Append(eventTypes).Append(Dictionary.Severities);
            builder.Append(severities).Append(Dictionary.XmlOutput);
            return builder.ToString();
        }
    }
}