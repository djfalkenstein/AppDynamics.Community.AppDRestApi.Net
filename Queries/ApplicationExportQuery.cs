using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Queries
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// </summary>
    public class ApplicationExportQuery
    {
        internal string BuildUrlStringApplicationExportById(string baseUrl, int appId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerObj).Append(Dictionary.ApplicationExId).Append(appId);
            return builder.ToString();
        }
    }
}