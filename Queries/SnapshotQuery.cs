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
    public class SnapshotQuery
    {
        readonly QueryEncoder _qe = new QueryEncoder();
        internal string BuildUrlStringRequestSnapshot(string baseUrl, string application, long start, long end)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlRequestSnapshots);

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);

            return val.ToString();
        }

        internal string BuildUrlStringRequestSnapshot(string baseUrl, int application, long start, long end)
        {
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(application);
            val.Append(Dictionary.UrlRequestSnapshots);

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);

            return val.ToString();
        }
    }
}