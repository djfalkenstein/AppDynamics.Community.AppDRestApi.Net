using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    ///
    /// <request-segment-datas/>
    /// <request-segment-data>
    ///        <id>0</id>
    ///        <archived>false</archived>
    ///        <requestGUID>103b98e6-4b33-4a8d-9511-d572e9c828c8</requestGUID>
    ///        <businessTransactionId>7204</businessTransactionId>
    ///        <applicationId>81</applicationId>
    ///        <applicationComponentId>650</applicationComponentId>
    ///        <applicationComponentNodeId>19155</applicationComponentNodeId>
    ///        <async>false</async>
    ///        <threadID>59</threadID>
    ///        <threadName>http-8080-19</threadName>
    ///        <localStartTime>1398266842227</localStartTime>
    ///        <serverStartTime>1398266842227</serverStartTime>
    ///        <firstInChain>true</firstInChain>
    ///        <callChain>Component:650</callChain>
    ///        <localID>0</localID>
    ///        <errorOccured>false</errorOccured>
    ///        <hasDeepDiveData>true</hasDeepDiveData>
    ///        <userExperience>VERY_SLOW</userExperience>
    ///        <timeTakenInMilliSecs>2005</timeTakenInMilliSecs>
    ///        <cpuTimeTakenInMilliSecs>0</cpuTimeTakenInMilliSecs>
    ///        <warningThreshold>3.0 standard deviations = 666 ms. (For the last 120 mins, the moving average was 42 ms and the standard deviation was 222 ms)3.0x of standard deviation [222.07039] for moving average [42.759327] for the last [120] minutes.</warningThreshold>
    ///        <criticalThreshold>4.0 standard deviations = 888 ms. (For the last 120 mins, the moving average was 42 ms and the standard deviation was 222 ms)4.0x of standard deviation [222.07039] for moving average [42.759327] for the last [120] minutes.</criticalThreshold>
    ///        <summary>Request was slower than the average by one of the thresholds below - </summary>
    ///        <errorSummary></errorSummary>
    ///        <diagnosticSessionGUID></diagnosticSessionGUID>
    ///        <deepDivePolicy>INFLIGHT_SLOW_SESSION</deepDivePolicy>
    ///        <delayedDeepDive>true</delayedDeepDive>
    ///        <delayedDeepDiveOffSet>868</delayedDeepDiveOffSet>
    ///        <exitCallsDataTruncated>false</exitCallsDataTruncated>
    ///        <URL>/patron/v2/apid:TH-303-44951-93-50/original.txt</URL>
    ///        <errorIDs/>
    ///        <errorDetails/>
    ///        <httpParameters/>
    ///        <businessData/>
    ///        <cookies/>
    ///        <httpHeaders/>
    ///        <sessionKeys/>
    ///        <responseHeaders/>
    ///        <logMessages/>
    ///        <transactionProperties/>
    ///        <transactionEvents/>
    ///        <unresolvedCallInCallChain>false</unresolvedCallInCallChain>
    ///        <dotnetProperty/>
    /// </request-segment-data>
    ///
    /// </summary>
    public class Snapshot
    {
        public int Id { get; set; }
        public bool Archived { get; set; }
        public string RequestGuid { get; set; }
        public int BusinessTransactionId { get; set; }
        public int ApplicationId { get; set; }
        public int ApplicationComponentId { get; set; }
        public int ApplicationComponentNodeId { get; set; }
        public bool Async { get; set; }
        public int ThreadId { get; set; }
        public string ThreadName { get; set; }
        public long LocalStartTime { get; set; }
        public long ServerStartTime { get; set; }
        public bool FirstInChain { get; set; }
        public string CallChain { get; set; }
        public int LocalId { get; set; }
        public bool ErrorOccured { get; set; }
        public bool HasDeepDiveData { get; set; }
        public string UserExperience { get; set; }
        public long TimeTakenInMilliSecs { get; set; }
        public long CpuTimeTakenInMilliSecs { get; set; }
        public string WarningThreshold { get; set; }
        public string CriticalThreshold { get; set; }
        public string Summary { get; set; }
        public string ErrorSummary { get; set; }
        public string DiagnosticSessionGuid { get; set; }
        public string DeepDivePolicy { get; set; }
        public bool DelayedDeepDive { get; set; }
        public long DelayedDeepDiveOffSet { get; set; }
        public bool ExitCallsDataTruncated { get; set; }
        public string Url { get; set; }
        public string ErrorIDs { get; set; }
        public string ErrorDetails { get; set; }
        public string HttpParameters { get; set; }
        public string BusinessData { get; set; }
        public string Cookies { get; set; }
        public string HttpHeaders { get; set; }
        public string SessionKeys { get; set; }
        public string ResponseHeaders { get; set; }
        public string LogMessages { get; set; }
        public string TransactionProperties { get; set; }
        public string TransactionEvents  { get; set; }
        public bool UnresolvedCallInCallChain { get; set; }
        public string DotnetProperty { get; set; }

        public Snapshot(int id, bool archived, string requestGuid,int businessTransactionId,
                        int applicationId, int applicationComponentId, int applicationComponentNodeId,
                        bool async, int threadId, string threadName, long localStartTime,
                        long serverStartTime, bool firstInChain, string callChain, int localId, 
                        bool errorOccured, bool hasDeepDiveData, string userExperience, long timeTakenInMilliSecs,
                        long cpuTimeTakenInMilliSecs, string warningThreshold, string criticalThreshold, 
                        string summary, string errorSummary, string diagnosticSessionGuid, string deepDivePolicy,
                        bool delayedDeepDive, long delayedDeepDiveOffSet, bool exitCallsDataTruncated,
                        string url, string errorIDs, string errorDetails, string httpParameters,
                        string businessData, string cookies, string httpHeaders, string sessionKeys, string responseHeaders, 
                        string logMessages, string transactionProperties, string transactionEvents,
                        bool unresolvedCallInCallChain, string dotnetProperty)
        {
            Id = id;
            Archived = archived;
            RequestGuid = requestGuid;
            BusinessTransactionId = businessTransactionId;
            ApplicationId = ApplicationId;
            ApplicationComponentId  = applicationComponentId;
            ApplicationComponentNodeId = applicationComponentNodeId;
            Async = async;
            ThreadId = threadId;
            ThreadName = threadName;
            LocalStartTime = localStartTime;
            ServerStartTime = serverStartTime;
            FirstInChain = firstInChain;
            CallChain = callChain;
            LocalId = localId;
            ErrorOccured = errorOccured;
            HasDeepDiveData = hasDeepDiveData;
            UserExperience = userExperience;
            TimeTakenInMilliSecs = timeTakenInMilliSecs;
            CpuTimeTakenInMilliSecs = cpuTimeTakenInMilliSecs;
            WarningThreshold = warningThreshold;
            CriticalThreshold = criticalThreshold;
            Summary = summary;
            ErrorSummary = errorSummary;
            DiagnosticSessionGuid = diagnosticSessionGuid;
            DeepDivePolicy = deepDivePolicy;
            DelayedDeepDive = delayedDeepDive;
            DelayedDeepDiveOffSet = delayedDeepDiveOffSet;
            ExitCallsDataTruncated = exitCallsDataTruncated;
            Url = url;
            ErrorIDs = errorIDs;
            ErrorDetails = errorDetails;
            HttpParameters = httpParameters;
            BusinessData = businessData;
            Cookies = cookies;
            HttpHeaders = httpHeaders;
            SessionKeys = sessionKeys;
            ResponseHeaders = responseHeaders;
            LogMessages = logMessages;
            TransactionProperties  = transactionProperties;
            TransactionEvents  = transactionEvents;
            UnresolvedCallInCallChain = unresolvedCallInCallChain;
            DotnetProperty = dotnetProperty;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.L1).Append(Dictionary.RequestSegmentData);
            builder.Append(Dictionary.L2).Append(Dictionary.Id).Append(Dictionary.Ve).Append(Id);
            builder.Append(Dictionary.L2).Append(Dictionary.Archived).Append(Dictionary.Ve).Append(Archived);
            builder.Append(Dictionary.L2).Append(Dictionary.RequestGuid).Append(Dictionary.Ve).Append(RequestGuid);
            builder.Append(Dictionary.L2).Append(Dictionary.BusinessTransactionId).Append(Dictionary.Ve).Append(BusinessTransactionId);
            builder.Append(Dictionary.L2).Append(Dictionary.ApplicationId).Append(Dictionary.Ve).Append(ApplicationId);
            builder.Append(Dictionary.L2).Append(Dictionary.ApplicationComponentId).Append(Dictionary.Ve).Append(ApplicationComponentId);
            builder.Append(Dictionary.L2).Append(Dictionary.ApplicationComponentNodeId).Append(Dictionary.Ve).Append(ApplicationComponentNodeId);
            builder.Append(Dictionary.L2).Append(Dictionary.Async).Append(Dictionary.Ve).Append(Async);
            builder.Append(Dictionary.L2).Append(Dictionary.ThreadId).Append(Dictionary.Ve).Append(ThreadId);
            builder.Append(Dictionary.L2).Append(Dictionary.ThreadName).Append(Dictionary.Ve).Append(ThreadName);
            builder.Append(Dictionary.L2).Append(Dictionary.LocalStartTime).Append(Dictionary.Ve).Append(LocalStartTime);
            builder.Append(Dictionary.L2).Append(Dictionary.ServerStartTime).Append(Dictionary.Ve).Append(ServerStartTime);
            builder.Append(Dictionary.L2).Append(Dictionary.FirstInChain).Append(Dictionary.Ve).Append(FirstInChain);
            builder.Append(Dictionary.L2).Append(Dictionary.CallChain).Append(Dictionary.Ve).Append(CallChain);
            builder.Append(Dictionary.L2).Append(Dictionary.LocalId).Append(Dictionary.Ve).Append(LocalId);
            builder.Append(Dictionary.L2).Append(Dictionary.ErrorOccurred).Append(Dictionary.Ve).Append(ErrorOccured);
            builder.Append(Dictionary.L2).Append(Dictionary.HasDeepDiveData).Append(Dictionary.Ve).Append(HasDeepDiveData);
            builder.Append(Dictionary.L2).Append(Dictionary.UserExperience).Append(Dictionary.Ve).Append(UserExperience);
            builder.Append(Dictionary.L2).Append(Dictionary.TimeTakenInMillisecs).Append(Dictionary.Ve).Append(TimeTakenInMilliSecs);
            builder.Append(Dictionary.L2).Append(Dictionary.CpuTimeTakenInMillissecs).Append(Dictionary.Ve).Append(CpuTimeTakenInMilliSecs);
            builder.Append(Dictionary.L2).Append(Dictionary.WarningThreshold).Append(Dictionary.Ve).Append(WarningThreshold);
            builder.Append(Dictionary.L2).Append(Dictionary.CriticalThreshold).Append(Dictionary.Ve).Append(CriticalThreshold);
            builder.Append(Dictionary.L2).Append(Dictionary.Summary).Append(Dictionary.Ve).Append(Summary);
            builder.Append(Dictionary.L2).Append(Dictionary.ErrorSummary).Append(Dictionary.Ve).Append(ErrorSummary);
            builder.Append(Dictionary.L2).Append(Dictionary.DiagnosticSessionGuid).Append(Dictionary.Ve).Append(DiagnosticSessionGuid);
            builder.Append(Dictionary.L2).Append(Dictionary.DeepDivePolicy).Append(Dictionary.Ve).Append(DeepDivePolicy);
            builder.Append(Dictionary.L2).Append(Dictionary.DelayDeepDive).Append(Dictionary.Ve).Append(DelayedDeepDive);
            builder.Append(Dictionary.L2).Append(Dictionary.DelayDeepDiveOffset).Append(Dictionary.Ve).Append(DelayedDeepDiveOffSet);
            builder.Append(Dictionary.L2).Append(Dictionary.ExitCallsDataTruncated).Append(Dictionary.Ve).Append(ExitCallsDataTruncated);
            builder.Append(Dictionary.L2).Append(Dictionary.Url).Append(Dictionary.Ve).Append(Url);
            builder.Append(Dictionary.L2).Append(Dictionary.ErrorIds).Append(Dictionary.Ve).Append(ErrorIDs);
            builder.Append(Dictionary.L2).Append(Dictionary.ErrorDetails).Append(Dictionary.Ve).Append(ErrorDetails);
            builder.Append(Dictionary.L2).Append(Dictionary.HttpParameters).Append(Dictionary.Ve).Append(HttpParameters);
            builder.Append(Dictionary.L2).Append(Dictionary.BusinessData).Append(Dictionary.Ve).Append(BusinessData);
            builder.Append(Dictionary.L2).Append(Dictionary.Cookies).Append(Dictionary.Ve).Append(Cookies);
            builder.Append(Dictionary.L2).Append(Dictionary.HttpHeaders).Append(Dictionary.Ve).Append(HttpHeaders);
            builder.Append(Dictionary.L2).Append(Dictionary.SessionKeys).Append(Dictionary.Ve).Append(SessionKeys);
            builder.Append(Dictionary.L2).Append(Dictionary.ResponseHeaders).Append(Dictionary.Ve).Append(ResponseHeaders);
            builder.Append(Dictionary.L2).Append(Dictionary.LogMessages).Append(Dictionary.Ve).Append(LogMessages);
            builder.Append(Dictionary.L2).Append(Dictionary.TransactionProperties).Append(Dictionary.Ve).Append(TransactionProperties);
            builder.Append(Dictionary.L2).Append(Dictionary.TransactionEvents).Append(Dictionary.Ve).Append(TransactionEvents);
            builder.Append(Dictionary.L2).Append(Dictionary.UnresolvedCallInCallChain).Append(Dictionary.Ve).Append(UnresolvedCallInCallChain);
            builder.Append(Dictionary.L2).Append(Dictionary.DotNetProperty).Append(Dictionary.Ve).Append(DotnetProperty);

            return builder.ToString();
        }
    }

}
