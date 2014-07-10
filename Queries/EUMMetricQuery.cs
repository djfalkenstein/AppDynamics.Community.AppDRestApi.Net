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
    public class EumMetricQuery
    {
        readonly QueryEncoder _qe = new QueryEncoder();
        internal string BuildUrlStringEumAjaxRequestsPerMin(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumAjaxRequests);
            builder.Append(urlPath).Append(Dictionary.EumRequestsPerMin);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumAjaxRequestsErrorsPerMin(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumAjaxRequests);
            builder.Append(urlPath).Append(Dictionary.EumAjaxRequestErrorsPerMinute);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumAjaxDocDownloadTime(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumAjaxRequests);
            builder.Append(urlPath).Append(Dictionary.EumDocumentDownloadTimeMs);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumAjaxDocProcessingTime(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumAjaxRequests);
            builder.Append(urlPath).Append(Dictionary.EumDocumentProcessingTimeMs);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumAjaxEndUserResponseTime(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumAjaxRequests);
            builder.Append(urlPath).Append(Dictionary.EumEndUserResponseTime);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumAjaxFirstByteTimeMs(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumAjaxRequests);
            builder.Append(urlPath).Append(Dictionary.EumFirstByteTimeMs);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        /*
         * public final String Eum_DOCUEMENT_READY_TIME_MS="|Document Ready Time (ms)";
        public final String Eum_FRONT_END_TIME_MS="|Front End Time (ms)";
        public final String Eum_PAGE_RENDER_TIME_MS="|Page Render Time (ms)";
        public final String Eum_PAGE_VIEWS_WITH_JAVASCRIPT_ERRORS_PER_MINUTE="|Page views with JavaScript Errors per Minute";
        public final String Eum_RESPONSE_AVAILABLE_TIME_MS="|Response Available Time (ms)";
        public final String Eum_SERVER_CONNECTION_TIME_MS="|Server Connection Time (ms)";
        public final String Eum_SYNTHETIC_REQUESTS_PER_MINUTE="|Synthetic Requests per Minute"
         */

        internal string BuildUrlStringEumBasePagesRequestsPerMin(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumBasePages);
            builder.Append(urlPath).Append(Dictionary.EumRequestsPerMin);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumBasePagesDocReadyTimeMs(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumBasePages);
            builder.Append(urlPath).Append(Dictionary.EumDocuementReadyTimeMs);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumBasePagesDocDownloadTime(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumBasePages);
            builder.Append(urlPath).Append(Dictionary.EumDocumentDownloadTimeMs);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumBasePagesDocProcessingTime(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumBasePages);
            builder.Append(urlPath).Append(Dictionary.EumDocumentProcessingTimeMs);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumBasePagesEndUserResponseTime(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumBasePages);
            builder.Append(urlPath).Append(Dictionary.EumEndUserResponseTime);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumBasePagesFirstByteTimeMs(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumBasePages);
            builder.Append(urlPath).Append(Dictionary.EumFirstByteTimeMs);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumBasePagesFrontEndTimeMs(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumBasePages);
            builder.Append(urlPath).Append(Dictionary.EumFrontEndTimeMs);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumBasePagesPageRenderTimeMs(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumBasePages);
            builder.Append(urlPath).Append(Dictionary.EumPageRenderTimeMs);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumBasePagesPageViewsWithJavascriptErrorsPerMinute(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumBasePages);
            builder.Append(urlPath).Append(Dictionary.EumPageViewsWithJavascriptErrorsPerMinute);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumBasePagesResponseAvailableTimeMs(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumBasePages);
            builder.Append(urlPath).Append(Dictionary.EumResponseAvailableTimeMs);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumBasePagesServerConnectionTimeMs(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumBasePages);
            builder.Append(urlPath).Append(Dictionary.EumServerConnectionTimeMs);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }

        internal string BuildUrlStringEumBasePagesSyntheticRequestsPerMinute(string baseUrl, string application, string urlPath, long start, long end, bool rollup)
        {
            //End User Experience|AJAX Requests|/|Requests per Minute
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?metric-path=
            //End%20User%20Experience%7CAJAX%20Requests%7C/%7CRequests%20per%20Minute&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.EumUserExperience).Append(Dictionary.EumBasePages);
            builder.Append(urlPath).Append(Dictionary.EumSyntheticRequestsPerMinute);
            val.Append(_qe.Encode(builder.ToString()));

            //val.append(Dictionary.LAST_15_MINUTES);
            val.Append(Dictionary.TimeBetween).Append(Dictionary.TimeStartTime).Append(start);
            val.Append(Dictionary.TimeEndTime).Append(end);
            if (!rollup)
            {
                val.Append(Dictionary.NoRollUp);
            }
            val.Append(Dictionary.UseJson);
            return val.ToString();
        }
    }
}