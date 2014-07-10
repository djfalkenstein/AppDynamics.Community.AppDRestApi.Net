using System.Web;

namespace AppDynamics.Community.AppDRestApi.Net.Queries
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class QueryEncoder
    {
        public string Decode(string url)
        {
            return HttpUtility.UrlDecode(url); 
        }

        public string Encode(string url)
        {
            var urlEncode = HttpUtility.UrlEncode(url);
            return urlEncode != null ? urlEncode.Replace("\\+", "%20") : null;
        }

        public string EncodeSpaces(string url)
        {
            //return url.replaceAll(" ", "%20").replace("|", "%7C");
            var urlEncode = HttpUtility.UrlEncode(url);
            if (urlEncode == null) return null;
            urlEncode.Replace(" ", "%20");
            urlEncode.Replace("|", "%7C");
            return urlEncode;
        }
    }
}