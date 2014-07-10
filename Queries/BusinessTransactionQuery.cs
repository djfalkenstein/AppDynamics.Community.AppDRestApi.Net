using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Queries
{
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class BusinessTransactionQuery
    {
        readonly QueryEncoder _qe = new QueryEncoder();
        internal string BuildUrlStringGetAllBtsForApp(string baseUrl, string application)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(@"/").Append(_qe.Encode(application)).Append(Dictionary.F).Append(Dictionary.BusinessTransactions).Append(Dictionary.UseJson);
            return builder.ToString();
        }

        internal string BuildUrlStringGetAllBtsForApp(string baseUrl, int appId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(@"/").Append(appId).Append(Dictionary.F).Append(Dictionary.BusinessTransactions).Append(Dictionary.UseJson);
            return builder.ToString();
        }

        internal string QueryBtFromApps(string baseUrl, string application, int btId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(_qe.Encode(application)).Append(Dictionary.F).Append(Dictionary.BusinessTransactions).Append(Dictionary.F).Append(btId);
            return builder.ToString();
        }

        internal string QueryBtFromApps(string baseUrl, int appId, int btId)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(baseUrl).Append(Dictionary.ControllerApps).Append(appId).Append(Dictionary.F).Append(Dictionary.BusinessTransactions).Append(Dictionary.F).Append(btId);
            return builder.ToString();
        }

        internal string QueryBtAverageBlockTimeMs(string baseUrl, string application, string tier, string site, long start, long end, bool rollup)
        {
            //Business Transaction Performance|Business Transactions|tomcat-links|/links - Catchall|Average Block Time (Ms)
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?
            //metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7Ctomcat-links%7C/links%20-%20Catchall%7CAverage%20Block%20Time%20(Ms)
            //&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBusinessTransactionPerformance).Append(Dictionary.UrlBusinessTransactions);
            builder.Append(tier).Append(Dictionary.P).Append(site).Append(Dictionary.P).Append(Dictionary.AverageBlockTimeMs);
            val.Append(_qe.EncodeSpaces(builder.ToString()));

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

        internal string QueryBtAverageCpuUsedMs(string baseUrl, string application, string tier, string site, long start, long end, bool rollup)
        {
            //Business Transaction Performance|Business Transactions|tomcat-links|/links - Catchall|Average Block Time (Ms)
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?
            //metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7Ctomcat-links%7C/links%20-%20Catchall%7CAverage%20Block%20Time%20(Ms)
            //&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBusinessTransactionPerformance).Append(Dictionary.UrlBusinessTransactions);
            builder.Append(tier).Append(Dictionary.P).Append(site).Append(Dictionary.P).Append(Dictionary.AverageCpuUsedMs);
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

        internal string QueryBtAverageRequestSize(string baseUrl, string application, string tier, string site, long start, long end, bool rollup)
        {
            //Business Transaction Performance|Business Transactions|tomcat-links|/links - Catchall|Average Block Time (Ms)
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?
            //metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7Ctomcat-links%7C/links%20-%20Catchall%7CAverage%20Block%20Time%20(Ms)
            //&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBusinessTransactionPerformance).Append(Dictionary.UrlBusinessTransactions);
            builder.Append(tier).Append(Dictionary.P).Append(site).Append(Dictionary.P).Append(Dictionary.AverageRequestSize);
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

        internal string QueryBtAverageResponseTime(string baseUrl, string application, string tier, string site, long start, long end, bool rollup)
        {
            //Business Transaction Performance|Business Transactions|tomcat-links|/links - Catchall|Average Block Time (Ms)
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?
            //metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7Ctomcat-links%7C/links%20-%20Catchall%7CAverage%20Block%20Time%20(Ms)
            //&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBusinessTransactionPerformance).Append(Dictionary.UrlBusinessTransactions);
            builder.Append(tier).Append(Dictionary.P).Append(site).Append(Dictionary.P).Append(Dictionary.AverageResponseTime);
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

        internal string QueryBtAverageWaitTimeMs(string baseUrl, string application, string tier, string site, long start, long end, bool rollup)
        {
            //Business Transaction Performance|Business Transactions|tomcat-links|/links - Catchall|Average Block Time (Ms)
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?
            //metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7Ctomcat-links%7C/links%20-%20Catchall%7CAverage%20Block%20Time%20(Ms)
            //&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBusinessTransactionPerformance).Append(Dictionary.UrlBusinessTransactions);
            builder.Append(tier).Append(Dictionary.P).Append(site).Append(Dictionary.P).Append(Dictionary.AverageWaitTimeMs);
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

        internal string QueryBtCallPerMinute(string baseUrl, string application, string tier, string site, long start, long end, bool rollup)
        {
            //Business Transaction Performance|Business Transactions|tomcat-links|/links - Catchall|Average Block Time (Ms)
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?
            //metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7Ctomcat-links%7C/links%20-%20Catchall%7CAverage%20Block%20Time%20(Ms)
            //&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBusinessTransactionPerformance).Append(Dictionary.UrlBusinessTransactions);
            builder.Append(tier).Append(Dictionary.P).Append(site).Append(Dictionary.P).Append(Dictionary.CallPerMinute);
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

        internal string QueryBtErrorsPerMinute(string baseUrl, string application, string tier, string site, long start, long end, bool rollup)
        {
            //Business Transaction Performance|Business Transactions|tomcat-links|/links - Catchall|Average Block Time (Ms)
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?
            //metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7Ctomcat-links%7C/links%20-%20Catchall%7CAverage%20Block%20Time%20(Ms)
            //&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBusinessTransactionPerformance).Append(Dictionary.UrlBusinessTransactions);
            builder.Append(tier).Append(Dictionary.P).Append(site).Append(Dictionary.ErrorsPerMinute);
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

        internal string QueryBtNormalAverageResponseTimeMs(string baseUrl, string application, string tier, string site, long start, long end, bool rollup)
        {
            //Business Transaction Performance|Business Transactions|tomcat-links|/links - Catchall|Average Block Time (Ms)
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?
            //metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7Ctomcat-links%7C/links%20-%20Catchall%7CAverage%20Block%20Time%20(Ms)
            //&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBusinessTransactionPerformance).Append(Dictionary.UrlBusinessTransactions);
            builder.Append(tier).Append(Dictionary.P).Append(site).Append(Dictionary.P).Append(Dictionary.NormalAverageResponseTimeMs);
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

        internal string QueryBtNumberOfSlowCalls(string baseUrl, string application, string tier, string site, long start, long end, bool rollup)
        {
            //Business Transaction Performance|Business Transactions|tomcat-links|/links - Catchall|Average Block Time (Ms)
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?
            //metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7Ctomcat-links%7C/links%20-%20Catchall%7CAverage%20Block%20Time%20(Ms)
            //&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBusinessTransactionPerformance).Append(Dictionary.UrlBusinessTransactions);
            builder.Append(tier).Append(Dictionary.P).Append(site).Append(Dictionary.NumberOfSlowCalls);
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

        internal string QueryBtNumberOfVerySlowCalls(string baseUrl, string application, string tier, string site, long start, long end, bool rollup)
        {
            //Business Transaction Performance|Business Transactions|tomcat-links|/links - Catchall|Average Block Time (Ms)
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?
            //metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7Ctomcat-links%7C/links%20-%20Catchall%7CAverage%20Block%20Time%20(Ms)
            //&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBusinessTransactionPerformance).Append(Dictionary.UrlBusinessTransactions);
            builder.Append(tier).Append(Dictionary.P).Append(site).Append(Dictionary.NumberOfVerySlowCalls);
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

        internal string QueryBtStallCount(string baseUrl, string application, string tier, string site, long start, long end, bool rollup)
        {
            //Business Transaction Performance|Business Transactions|tomcat-links|/links - Catchall|Average Block Time (Ms)
            //https://familysearch.saas.AppDynamics.com/controller/rest/applications/FamilySearch-production/metric-data?
            //metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7Ctomcat-links%7C/links%20-%20Catchall%7CAverage%20Block%20Time%20(Ms)
            //&time-range-type=BEFORE_NOW&duration-in-mins=15
            StringBuilder val = new StringBuilder();
            val.Append(baseUrl).Append(Dictionary.ControllerApps);
            val.Append(_qe.Encode(application));
            val.Append(Dictionary.UrlMetricPath);

            // This has to be encoded otherwise the query will fail.
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.UrlBusinessTransactionPerformance).Append(Dictionary.UrlBusinessTransactions);
            builder.Append(tier).Append(Dictionary.P).Append(site).Append(Dictionary.StallCount);
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