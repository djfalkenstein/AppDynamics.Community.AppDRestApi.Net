using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Helpers;

namespace AppDynamics.Community.AppDRestApi.Net.Util
{
    public class JsonHandling
    {
        public HttpResponseMessage ReturnPureJson(object responseModel)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            string jsonClient = Json.Encode(responseModel);
            byte[] resultBytes = Encoding.UTF8.GetBytes(jsonClient);
            response.Content = new StreamContent(new MemoryStream(resultBytes));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");

            return response;
        }
    }
}
