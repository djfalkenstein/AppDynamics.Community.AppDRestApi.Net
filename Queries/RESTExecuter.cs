using System;
using System.Collections.Generic;
using System.Net;
using AppDynamics.Community.AppDRestApi.Net.Entities;
using AppDynamics.Community.AppDRestApi.Net.Objects;
using Newtonsoft.Json;

namespace AppDynamics.Community.AppDRestApi.Net.Queries
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class RestExecuter
    {
        internal List<MetricData> ExecuteMetricQuery(RestAuth auth, string query)
        {
            WebClient proxy = new WebClient();
            NetworkCredential credential = new NetworkCredential(auth.UserNameForAuth, auth.Password);
            proxy.Credentials = credential;
            string result;
            try
            {
                result = proxy.DownloadString(new Uri(query));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            List<MetricData> md = JsonConvert.DeserializeObject<List<MetricData>>(result);
            return md;
        }

        internal List<Application> ExecuteApplicationExportByIdQuery(RestAuth auth, string query)
        {
            WebClient proxy = new WebClient();
            NetworkCredential credential = new NetworkCredential(auth.UserNameForAuth, auth.Password);
            proxy.Credentials = credential;
            string result;
            try
            {
                result = proxy.DownloadString(new Uri(query));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            List<Application> a = JsonConvert.DeserializeObject<List<Application>>(result);
            return a;
        }

        internal List<BusinessTransaction> ExecuteBusinessTransactionQuery(RestAuth auth, string query)
        {
            WebClient proxy = new WebClient();
            NetworkCredential credential = new NetworkCredential(auth.UserNameForAuth, auth.Password);
            proxy.Credentials = credential;
            string result;
            try
            {
                result = proxy.DownloadString(new Uri(query));
                result = result.Replace("\n", "");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            //
            List<BusinessTransaction>  bt = JsonConvert.DeserializeObject<List<BusinessTransaction>>(result);
            return bt;
        }

        internal List<Application> ExecuteApplicationQuery(RestAuth auth, string query)
        {
            WebClient proxy = new WebClient();
            NetworkCredential credential = new NetworkCredential(auth.UserNameForAuth, auth.Password);
            proxy.Credentials = credential;
            string result;
            try
            {
                result = proxy.DownloadString(new Uri(query));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            result = result.Replace("\"\"", "\"NULL\"");//Change empty to "null"

            List<Application> aq = JsonConvert.DeserializeObject<List<Application>>(result);
            return aq;
        }

        internal List<Tier> ExecuteTierQuery(RestAuth auth, string query)
        {
            WebClient proxy = new WebClient();
            NetworkCredential credential = new NetworkCredential(auth.UserNameForAuth, auth.Password);
            proxy.Credentials = credential;
            string result;
            try
            {
                result = proxy.DownloadString(new Uri(query));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            List<Tier> t = JsonConvert.DeserializeObject<List<Tier>>(result);
            return t;
        }

        internal List<Node> ExecuteNodeQuery(RestAuth auth, string query)
        {
            WebClient proxy = new WebClient();
            NetworkCredential credential = new NetworkCredential(auth.UserNameForAuth, auth.Password);
            proxy.Credentials = credential;
            string result;
            try
            {
                result = proxy.DownloadString(new Uri(query));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            List<Node> n = JsonConvert.DeserializeObject<List<Node>>(result);
            return n;
        }

        internal List<PolicyViolation> ExecutePolicyViolationsQuery(RestAuth auth, string query)
        {
            WebClient proxy = new WebClient();
            NetworkCredential credential = new NetworkCredential(auth.UserNameForAuth, auth.Password);
            proxy.Credentials = credential;
            string result;
            try
            {
                result = proxy.DownloadString(new Uri(query));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            List<PolicyViolation> pv = JsonConvert.DeserializeObject<List<PolicyViolation>>(result);
            return pv;
        }

        internal List<Event> ExecuteEventsQuery(RestAuth auth, string query)
        {
            WebClient proxy = new WebClient();
            NetworkCredential credential = new NetworkCredential(auth.UserNameForAuth, auth.Password);
            proxy.Credentials = credential;
            string result;
            try
            {
                result = proxy.DownloadString(new Uri(query));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            List<Event> e = JsonConvert.DeserializeObject<List<Event>>(result);
            return e;

        }

        internal List<Backend> ExecuteBackendsQuery(RestAuth auth, string query)
        {
            WebClient proxy = new WebClient();
            NetworkCredential credential = new NetworkCredential(auth.UserNameForAuth, auth.Password);
            proxy.Credentials = credential;
            string result;
            try
            {
                result = proxy.DownloadString(new Uri(query));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            List<Backend> b = JsonConvert.DeserializeObject<List<Backend>>(result);
            return b;
            
        }

        internal List<Snapshot> ExecuteSnapshotsQuery(RestAuth auth, string query)
        {
            WebClient proxy = new WebClient();
            NetworkCredential credential = new NetworkCredential(auth.UserNameForAuth, auth.Password);
            proxy.Credentials = credential;
            string result;
            try
            {
                result = proxy.DownloadString(new Uri(query));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            List<Snapshot> s = JsonConvert.DeserializeObject<List<Snapshot>>(result);
            return s;
        }

        internal List<MetricItem> ExecuteMetricItemsQuery(RestAuth auth, string query)
        {
            WebClient proxy = new WebClient();
            NetworkCredential credential = new NetworkCredential(auth.UserNameForAuth, auth.Password);
            proxy.Credentials = credential;
            string result;
            try
            {
                result = proxy.DownloadString(new Uri(query));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            List<MetricItem> mi = JsonConvert.DeserializeObject<List<MetricItem>>(result);
            return mi;
        }
    }
}
