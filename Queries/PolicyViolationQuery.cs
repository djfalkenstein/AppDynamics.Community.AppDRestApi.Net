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
    public class PolicyViolationQuery
    {
        readonly QueryEncoder _qe = new QueryEncoder();
        internal string BuildUrlStringPolicyViolationsFromApps(string baseUrl, string application, long start, long end)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(_qe.Encode(application)).Append(Dictionary.UrlProblems);
            builder.Append(Dictionary.UrlPolicyViolations);
            builder.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            builder.Append(Dictionary.TimeEndTime).Append(end).Append(Dictionary.XmlOutput);
            return builder.ToString();
        }

        internal string BuildUrlStringHealthRuleViolationsFromApps(string baseUrl, string application, long start, long end)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(_qe.Encode(application)).Append(Dictionary.UrlProblems);
            builder.Append(Dictionary.UrlHealthRuleViolations).Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            builder.Append(Dictionary.TimeEndTime).Append(end).Append(Dictionary.XmlOutput);
            return builder.ToString();
        }
    }
}