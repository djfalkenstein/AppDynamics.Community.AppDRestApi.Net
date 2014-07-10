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
    /// @author david.falkenstein@AppDynamics.com
    /// /controller/rest/applications   XML
    /// /controller/rest/applications?output=JSON   JSON
    /// </summary>
    public class ApplicationQuery
    {
        internal string BuildUrlStringAllApplications(string baseUrl)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps);
            return builder.ToString();
        }
    }
}