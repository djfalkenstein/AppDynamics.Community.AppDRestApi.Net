using System.Collections.Generic;

namespace AppDynamics.Community.AppDRestApi.Net.Resources
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class Dictionary
    {
        public const string RestApiVersion = "1.0.1";
        public int DebugLevel = 0;
        public int DetailLevel = 0;
        public double PercentageThreshold = 0.25;
        public const int MaxTries = 3;
        public const string UseJson = @"?output=JSON";
        public const string Https = @"https://";
        public const string Http = @"http://";
        public const string ControllerApps = @"/controller/rest/applications";
        public const string ControllerObj = @"/controller/";
        public const string Colon = ":";
        public const string P = @"|";
        public const string F = @"/";
        public const string Q = @"?";
        public const string UrlTiers = @"/tiers";
        public const string UrlNodes = @"/nodes";
        public const string UrlProblems = @"/problems";
        public const string UrlEvents = @"/events";
        public const string UrlPolicyViolations = @"/policy-violations?";
        public const string UrlHealthRuleViolations = @"/healthrule-violations?";
        public const string UrlRequestSnapshots = @"/request-snapshots?";
        public const string UrlBackends = @"/backends";
        public const string UrlBackends1 = @"Backends|";
        public const string UrlMetricList = @"/metrics";

        // App Agent Path
        // BDR Big Deal Retail/metric-data?metric-path=Application Infrastructure Performance|1stTier|Agent|App|Availability&time-range-type=BEFORE_NOW&duration-in-mins=15
        // {Application_Name}/metric-data?metric-path=Application Infrastructure Performance|{tier}|Agent|App|Availability&time-rante-type={type}&duration-in-mins={time}
        public const string UrlMetricPath = "/metric-data?metric-path=";

        public const string ApplicationInfraPerf = @"Application Infrastructure Performance|"; //Tier comes afterwards
        public const string AppAgentAvail1 = @"|Agent|App|Availability";
        public const string MachineAgentAvail2 = @"|Agent|Machine|Availability";
        public const string HardwareResources = @"|Hardware Resources|";
        public const string IndividualNodes = @"|Individual Nodes|";
        public const string HdCpu = @"CPU|";
        public const string HdCpuBusy = @"%Busy";
        public const string HdCpuIdle = @"%Idle";
        public const string HdCpuStolen = @"%Stolen";
        public const string HdDisks = @"Disks|";
        public const string HdDisksKbReadPerSec = @"KB read/sec";
        public const string HdDisksKbWritePerSec = @"KB written/sec";
        public const string HdDisksReadPerSec = @"Reads/sec";
        public const string HdDisksWritesPerSec = @"Writes/sec";
        public const string HdJvmMemory = @"Memory|";
        public const string HdMemoryFreePerc = @"Free %";
        public const string HdMemoryFreeMb = @"Free (Mb)";
        public const string HdMemoryTotalMb = @"Total (Mb)";
        public const string HdMemoryUsedPerc = @"Used %";
        public const string HdMemoryUsedMb = @"Used (Mb)";
        public const string HdNetwork = @"Network|";
        public const string HdNetworkIncomingKb = @"Incoming KB";
        public const string HdNetworkIncomingKbPerSec = @"Incoming KB/sec";
        public const string HdNetworkIncomingPackets = @"Incoming packets";
        public const string HdNetworkIncomingPacketsPerSec = @"Incoming packets/sec";
        public const string HdNetworkOutgoingKb = @"Outgoing KB";
        public const string HdNetworkOutgoingKbPerSec = @"Outgoing KB/sec";
        public const string HdNetworkOutgoingPackets = @"Outgoing packets";
        public const string HdNetworkOutgoingPacketsPerSec = @"Outgoing packets/sec";

        public const string Jvm = @"|JVM|";
        public const string JvmProcessCpuBurntMsPerMin = @"Process CPU Burnt (ms/min)";
        public const string JvmProcessCpuUsagePerc = @"Process CPU Usage %";
        public const string JvmGarbageCollection = @"Garbage Collection|";
        public const string JvmGarbageCollectionGcTimeSpentPerMinMs = @"GC Time Spent Per Min (ms)";
        public const string JvmGarbageCollectionMajorCollectionTimeSpentPerMinMs = @"Major Collection Time Spent Per Min (ms)";
        public const string JvmGarbageCollectionMinorCollectionTimeSpentPerMinMs = @"Minor Collection Time Spent Per Min (ms)";
        public const string JvmGarbageCollectionNumberOfMajorCollectionPerMin = @"Number of Major Collections Per Min";
        public const string JvmGarbageCollectionNumberOfMinorCollectionsPerMin = @"Number of Minor Collections Per Min";
        public const string JvmMemoryHeap = @"Heap|";
        public const string JvmMemoryNonHeap = @"Non-Heap|";
        public const string JvmMemoryHeapCommitedMb = @"Committed (Mb)";
        public const string JvmMemoryHeapCurrentUsageMb = @"Current Usage (Mb)";
        public const string JvmMemoryHeapMaxAvailableMb = @"Max Available (Mb)";
        public const string JvmMemoryHeapUsedPerc = @"Used %";
        public const string JvmThreadsCurrentNoOfThreads = @"Threads|Current No. of Threads";

        public const string Last15Minutes = "&time-range-type=BEFORE_NOW&duration-in-mins=15";
        public const string TimeBetween = "&time-range-type=BETWEEN_TIMES";
        public const string TimeBetween1 = "?time-range-type=BETWEEN_TIMES";
        public const string TimeStartTime = "&start-time=";
        public const string TimeEndTime = "&end-time=";
        public const string NoRollUp = "&rollup=false";
        public const string XmlOutput = "&output=XML'";

        public const string EventTypes = "&event-types=";
        public const string Severities = "&severities=";

        public const string Id = "id";

        //public const string Name = "name";
        //public const string Description = "description";
        public const string Applications = "applications";

        //public const string Application = "application";
        public const string MetricDatas = "metric-datas";

        public const string MetricData = "metric-data";
        public const string MetricPath = "metricPath";
        public const string Frequency = "frequency";
        public const string MetricItem = "metric-item";
        public const string MetricItems = "metric-items";
        public const string UrlMetricPathList = "?metric-path=";

        public const string MetricValues = "metricValues";
        public const string MetricValue = "metric-value";

        //public const string StartTimeInMillis = "startTimeInMillis";
        //public const string Value = "value";
        public const string Min = "min";

        public const string Max = "max";
        public const string Current = "current";

        public const string Tiers = "tiers";
        public const string Tier = "tier";
        public const string NumberOfNodes = "NumberOfNodes";
        //public const string AgentType = "agentType";
        //public const string Type = "type";

        public const string Node = "node";
        public const string Nodes = "nodes";
        public const string IpAddress = "ipAddress";
        public const string IpAddresses = "ipAddresses";
        public const string TierName = "BtTierName";

        //public const string TierId = "BtTierId";
        public const string MachineId = "machineId";

        public const string MachineName = "machineName";
        public const string MachineOsType = "machineOSType";
        public const string MachineAgentPresent = "machineAgentPresent";
        public const string MachineAgentVersion = "machineAgentVersion";
        public const string AppAgentPresent = "appAgentPresent";
        public const string AppAgentVersion = "appAgentVersion";

        public const string BusinessTransactions = "business-transactions";
        public const string BusinessTransaction = "business-transaction";
        public const string EntryPointType = "entryPointType";
        public const string InternalName = "internalName";
        public const string Background = "BtBackground";

        public const string ApplicationExId = "/ConfigObjectImControllerPortExportServlet?applicationId=";

        public const string AgentTypeChkPhp = "PHP";
        public const string AgentTypeChkIis = "IIS";
        public const string AgentTypeChkNodeJs = "NodeJs";

        public const string AgentNameJava = "Java Agent";
        public const string AgentNamePhp = "PHP Agent";
        public const string AgentNameNodejs = "NodeJs Agent";
        public const string AgentNameDotnet = "DotNet Agent";
        public const string AgentNameMachineAgent = "Machine Agent";

        /*
         *  Overall performance
        */
        public const string OverallApplicationPerf = "Overall Application Performance|"; //Tier comes afterwards
        public const string AverageResponseTimeMs = "|Average Response Time (ms)";
        public const string CallsPerMinute = "|Calls per Minute";
        public const string ErrorPageRedirectsPerMinute = "|Error Page Redirects per Minute";
        public const string ErrorsPerMinute = "|Errors per Minute";
        public const string ExceptionsPerMinute = "|Exceptions per Minute";
        public const string HttpErrorCodesPerMinute = "|HTTP Error Codes per Minute";
        public const string InfrastructureErrorsPerMinute = "|Infrastructure Errors per Minute";
        public const string NumberOfSlowCalls = "|Number of Slow Calls";
        public const string NumberOfVerySlowCalls = "|Number of Very Slow Calls";
        public const string StallCount = "|Stall Count";

        /*
         *  BT Performance
         */
        public const string UrlBusinessTransactionPerformance = "Business Transaction Performance|";
        public const string UrlBusinessTransactions = "Business Transactions|";
        public const string AverageBlockTimeMs = "Average Block Time (ms)";
        public const string AverageCpuUsedMs = "Average CPU Used (ms)";
        public const string AverageRequestSize = "Average Request Size";
        public const string AverageResponseTime = "Average Response Time (ms)";
        public const string AverageWaitTimeMs = "Average Wait Time (ms)";
        public const string CallPerMinute = "Calls per Minute";

        //public final String ERRORS_PER_MINUTE="Errors per Minute";
        public const string NormalAverageResponseTimeMs = "Normal Average Response Time (ms)";

        //public final String Number_OF_SLOW_CALLS="";
        //public final String Number_OF_VERY_SLOW_CALLS="";
        //public final String STALL_COUNT="Stall Count";

        public const string EumUserExperience = "End User Experience|";
        public const string EumAjaxRequests = "AJAX Requests|";

        public const string EumRequestsPerMin = "|Requests per Minute";
        public const string EumAjaxRequestErrorsPerMinute = "|AJAX Request Errors per Minute";
        public const string EumDocumentDownloadTimeMs = "|Document Download Time (ms)";
        public const string EumDocumentProcessingTimeMs = "|Document Processing Time (ms)";
        public const string EumEndUserResponseTime = "|End User Response Time (ms)";
        public const string EumFirstByteTimeMs = "|First Byte Time (ms)";

        public const string EumBasePages = "Base Pages|";
        public const string EumDocuementReadyTimeMs = "|Document Ready Time (ms)";
        public const string EumFrontEndTimeMs = "|Front End Time (ms)";
        public const string EumPageRenderTimeMs = "|Page Render Time (ms)";
        public const string EumPageViewsWithJavascriptErrorsPerMinute = "|Page views with JavaScript Errors per Minute";
        public const string EumResponseAvailableTimeMs = "|Response Available Time (ms)";
        public const string EumServerConnectionTimeMs = "|Server Connection Time (ms)";
        public const string EumSyntheticRequestsPerMinute = "|Synthetic Requests per Minute";

        public const string DotNetProperty = "dotnetProperty";
        public const string UnresolvedCallInCallChain = "unresolvedCallInCallChain";
        public const string TransactionEvents = "transactionEvents";
        public const string TransactionProperties = "transactionProperties";
        public const string LogMessages = "logMessages";
        public const string ResponseHeaders = "responseHeaders";
        public const string SessionKeys = "sessionKeys";
        public const string ServerStartTime = "serverStartTime";
        public const string HttpHeaders = "httpHeaders";
        public const string Cookies = "cookies";
        public const string BusinessData = "businessData";
        public const string HttpParameters = "httpParameters";
        public const string ErrorDetails = "errorDetails";
        public const string ErrorIds = "errorIDs";
        public const string Url = "URL";
        public const string ExitCallsDataTruncated = "exitCallsDataTruncated";
        public const string DelayDeepDiveOffset = "delayedDeepDiveOffSet";
        public const string DelayDeepDive = "delayedDeepDive";
        public const string DeepDivePolicy = "deepDivePolicy";
        public const string DiagnosticSessionGuid = "diagnosticSessionGUID";
        public const string ErrorSummary = "errorSummary";

        //public const string Summary = "summary";
        public const string CriticalThreshold = "criticalThreshold";

        public const string WarningThreshold = "warningThreshold";
        public const string CpuTimeTakenInMillissecs = "cpuTimeTakenInMilliSecs";
        public const string TimeTakenInMillisecs = "timeTakenInMilliSecs";
        public const string UserExperience = "userExperience";
        public const string HasDeepDiveData = "hasDeepDiveData";
        public const string ErrorOccurred = "errorOccured";
        public const string LocalId = "localID";
        public const string CallChain = "callChain";
        public const string FirstInChain = "firstInChain";
        public const string LocalStartTime = "localStartTime";
        public const string ThreadName = "threadName";
        public const string ThreadId = "threadID";
        public const string Async = "async";

        //public const string ApplicationComponentNodeId = "applicationComponentNodeId";
        public const string ApplicationComponentId = "applicationComponentId";

        public const string ApplicationId = "applicationId";
        public const string BusinessTransactionId = "businessTransactionId";
        public const string RequestGuid = "requestGUID";

        //public const string Archived = "archived";
        public const string RequestSegmentData = "request-segment-data";

        public const string RequestSegmentDatas = "request-segment-datas";

        /* * SNAPSHOTS *

     * <request-segment-datas>
     * <request-segment-data>
            <id>0</id>
            <archived>false</archived>
            <requestGUID>103b98e6-4b33-4a8d-9511-d572e9c828c8</requestGUID>
            <businessTransactionId>7204</businessTransactionId>
            <applicationId>81</applicationId>
            <applicationComponentId>650</applicationComponentId>
            <applicationComponentNodeId>19155</applicationComponentNodeId>
            <async>false</async>
            <threadID>59</threadID>
            <threadName>http-8080-19</threadName>
            <localStartTime>1398266842227</localStartTime>
            <serverStartTime>1398266842227</serverStartTime>
            <firstInChain>true</firstInChain>
            <callChain>Component:650</callChain>
            <localID>0</localID>
            <errorOccured>false</errorOccured>
            <hasDeepDiveData>true</hasDeepDiveData>
            <userExperience>VERY_SLOW</userExperience>
    </request-segment-data>
     *
         */

        /*

      <appAgentPresent>true</appAgentPresent>
      <appAgentVersion>Server Agent v3.7.11.0 GA #2013-09-27_11-05-45 re280bc92c2f193d92459c97836bba1297e1057cb 7</appAgentVersion>
         */

        public const bool QueryDebug = true;
        public const bool UiDebug = false;

        public const string Ve = " = ";
        public const string Vs = " :: ";
        public const string L1 = "\n\t";
        public const string L2 = "\n\t\t";
        public const string L3 = "\n\t\t\t";
        public const string L4 = "\n\t\t\t\t";
        public const string L5 = "\n\t\t\t\t\t";
        public const string L6 = "\n\t\t\t\t\t\t";

        public const string Application = "application";
        public const string ControllerVersion = "controller-version";
        public const string Name = "name";
        public const string Description = "description";
        public const string EnvProperties = "env-properties";

        public const string Configuration = "configuration";
        public const string ApplicationInstrumentationLevel = "application-instrumentation-level";
        public const string SnapshotEvaluationInterval = "snapshot-evaluation-interval";
        public const string SnapshotQuietTimePostSlaFailure = "snaphost-quiet-time-post-sla-failure";
        public const string PolicyEngineEnabled = "policy-engine-enabled";
        public const string CallGraph = "call-graph";
        public const string SamplingRate = "sampling-rate";
        public const string RawSql = "raw-sql";
        public const string ExcludePackages = "exclude-packages";
        public const string IncludePackages = "include-packages";
        public const string MinDurationForDbCalls = "min-duration-for-db-calls";
        public const string HotspotsEnabled = "hotspots-enabled";
        public const string Sla = "sla";
        public const string Art = "art";
        public const string Epm = "epm";
        public const string Enabled = "enabled";
        public const string Critical = "critical";
        public const string Warning = "warning";
        public const string BackgroundBusinessTransactionConfig = "BtBackground-transaction-config";
        public const string SnapshotCollectionPolicy = "snapshot-collection-policy";
        public const string MinuteFrequency = "minute-frequency";
        public const string NthOccurance = "nth-occurance";
        public const string SlaViolation = "sla-violation";
        public const string CollectOutliersOnly = "collect-outliers-only";
        public const string Duration = "duration";
        public const string MaxAttemptsForOutliers = "max-attempts-for-outliers";
        public const string WarningViolation = "warning-violation";
        public const string AutomaticCollectionEnabled = "automatic-collection-enabled";
        public const string AutomaticSlowVolumePercentageThreshold = "automatic-slow-volume-percentage-threshold";
        public const string AutomaticErrorVolumePercentageThreshold = "automatic-error-volume-percentage-threshold";
        public const string BtRequestThreshold = "bt-request-threshold";
        public const string StartingNodeSlowThreshold = "starting-node-slow-threshold";
        public const string EvaluationType = "evaluation-type";
        public const string EvaluationMins = "evaluation-mins";
        public const string StandardDeviationThreshold = "standard-deviation-threshold";
        public const string ContinuingSegmentSlowThreshold = "continuing-segment-slow-threshold";
        public const string ExitCallSlowThreshold = "exit-call-slow-threshold";
        public const string StartingNodeExtremelySlowThreshold = "starting-node-extremely-slow-threshold";
        public const string StallConfiguration = "stall-configuration";
        public const string Absolute = "absolute";
        public const string AbsoluteTimeInSecs = "absolute-time-in-secs";
        public const string BtSlaViolationMultiplier = "bt-sla-violation-multiplier";
        public const string BusinessTransactionConfig = "business-transaction-config";
        public const string ErrorConfiguration = "error-configuration";
        public const string DetectPhpErrors = "detect-php-errors";
        public const string PhpErrorLevel = "php-error-level";
        public const string DisableSystemTrace = "disable-system-trace";
        public const string DisableEventLog = "disable-event-log";
        public const string DisableNLog = "disable-n-log";
        public const string DisableLog4NetLogging = "disable-log4net-logging";
        public const string DisableDefaultHttpErrorCode = "disable_default_http_error_code";
        public const string IgnoreExceptions = "ignore-exceptions";
        public const string IgnoreLoggerName = "ignore-logger-names";
        public const string CaptureLoggerErrorAndFatalMessage = "capture-logger-error-and-fatal-messages";
        public const string MaxFramesInRootCause = "max-frames-in-root-cause";
        public const string StackTraceLineLimit = "stack-trace-line-limit";
        public const string MarkTranactionAsErrorOnErrorMessage = "mark-transaction-as-error-on-error-message-log-tag";
        public const string AsyncActivitySupControllerPortEd = "async-activity-supControllerPorted";

        /*
         * <error-configuration agent-type="php-app-agent">
                <detect-php-errors>true</detect-php-errors>
                <php-error-level>ERROR</php-error-level>
                <disable_default_http_error_code>false</disable_default_http_error_code>
                <ignore-exceptions/>
                <ignore-logger-names/>
                <capture-logger-error-and-fatal-messages>false</capture-logger-error-and-fatal-messages>
                <max-frames-in-root-cause>0</max-frames-in-root-cause>
                <stack-trace-line-limit>0</stack-trace-line-limit>
                <mark-transaction-as-error-on-error-message-log-tag>true</mark-transaction-as-error-on-error-message-log-tag>
            </error-configuration>
         */

        public const string EumConfiguration = "Eum-configuration";
        public const string ExternalJsFetchRul = "external-js-fetch-url";
        public const string HeartBeatUrl = "heart-beat-url";
        public const string Automatic = "automatic";
        public const string FrameworksToEnableAttributeInjection = "frameworks-to-enable-attribute-injection";
        public const string Manual = "manual";
        public const string EumParserRules = "Eum-parser-rules";
        public const string EumInjectionRules = "Eum-injection-rules";
        public const string ExcluceRules = "exclude-rules";
        public const string IncludeRules = "include-rules";
        public const string EumCloudApplicationKey = "Eum-cloud-application-key";
        public const string EumBeaconUrl = "Eum-beacon-url";
        public const string EumJsUrl = "Eum-js-url";
        public const string EumTargetTiers = "Eum-target-tiers";

        public const string DataGathererConfigs = "data-gatherer-configs";
        public const string HttpDataGathererConfig = "http-data-gatherer-config";
        public const string AttachToNewBts = "attach-to-new-bts";
        public const string Parameters = "parameters";
        public const string GatherUrl = "gather-url";
        public const string GatherSessionId = "gather-session-id";
        public const string GatherUserPrincipal = "gather-user-principal";
        public const string SqlDataGathererConfig = "sql-data-gatherer-config";
        public const string MatchType = "match-type";
        public const string MatchPattern = "match-pattern";
        public const string Inverse = "inverse";

        /* Business transaction group */
        public const string BusinessTransactionGroups = "business-transaction-groups";
        /* Need application component */
        public const string ApplicationComponents = "application-components";

        /* Need business transaction */
        public const string BusinessTransactionComponents = "business-transaction-components";

        public const string EntryMatchPointConfigurations = "entry-match-point-configurations";
        public const string EntryMatchPointConfiguration = "entry-match-point-configuration";
        public const string TransactionConfigurations = "transaction-configurations";
        public const string TransactionEntryPointType = "transaction-entry-point-type";
        public const string Enable = "enable";
        public const string DiscoveryConfig = "discovery-config";
        public const string DiscoveryConfigEnabled = "discovery-config-enabled";
        public const string DiscoveryResolution = "discovery-resolution";

        public const string BackendMatchPointConfigurations = "backend-match-point-configurations";
        public const string BackendMatchPointConfiguration = "backend-match-point-configuration";
        public const string CustomExitPointDefinition = "custom-exit-point-definition";
        public const string BackendDiscoveryConfigurations = "backend-discovery-configurations";
        public const string BackendDiscoveryConfiguration = "backend-discovery-configuration";
        public const string BackendIdentityOptions = "backend-identity-options";
        public const string BackendIdentityOption = "backend-identity-option";
        public const string NamingOptions = "naming-options";
        public const string NameValue = "name-value";
        public const string Value = "value";
        public const string DiscoveryEnabled = "discovery-enabled";
        public const string CorrelationEnabled = "correlation-enabled";
        public const string SupControllerPortSCorrelation = "supControllerPorts-correlation";
        public const string Priority = "priority";
        public const string ExitPointType = "exit-point-type"; //exitPointType

        public const string MetricBaselines = "metric-baselines";
        public const string MetricBaseline = "metric-baseline";
        public const string Seasonality = "seasonality";
        public const string Fixed = "fixed";
        public const string IsDefault = "is-default";
        public const string AllDate = "all-date";
        public const string NumberOfDays = "Number-of-days";

        /* Need to create info points  */
        public const string InfoPointGathererConfigs = "info-point-gatherer-configs";

        /* Need to create tasks */
        public const string Tasks = "tasks";

        /* Need to create workflows */
        public const string Workflows = "workflows";

        /* For agent configuration you will different xml structures for properties
         * depending on the type String, Boolean, Integer...
         */
        public const string AgentConfigurations = "agent-configurations";
        public const string AgentConfiguration = "agent-configuration";
        public const string Override = "override";
        public const string AgentType = "agent-type";
        public const string PropertyDefinitions = "property-definitions";
        public const string PropertyDefinition = "property-definition";
        public const string Type = "type";
        public const string Required = "required";
        public const string DefaultStringValue = "default-string-value";
        public const string UpperNumericBound = "upper-numeric-bound";
        public const string LowerNumericBound = "lower-numeric-bound";
        public const string StringMaxLength = "string-max-length";
        public const string AllowedStringValues = "allowed-string-values";
        public const string Properties = "properties";
        public const string Property = "property";
        public const string StringValue = "string-value";
        public const string IntegerType = "INTEGER";
        public const string StringType = "STRING";
        public const string BooleanType = "BOOLEAN";

        public const string EumCloudConfig = "Eum-cloud-config";
        public const string ApplicationDiagnosticData = "application-diagnostic-data";
        public const string Summary = "summary";
        public const string DiagnosticType = "diagnostic-type";
        public const string Key = "key";
        public const string ExcludeConfig = "exclude-config";
        public const string PageConfig = "page-config";
        public const string PageConfigVersion = "page-config-version";

        // Policy Violation & Event
        public const string PolicyViolations = "policy-violations";

        public const string PolicyViolation = "policy-violation";
        public const string StartTimeInMillis = "startTimeInMillis";
        public const string DetectedTimeInMillis = "detectedTimeInMillis";
        public const string EndTimeInMillis = "endTimeInMillis";
        public const string IncidentStatus = "incidentStatus";
        public const string Severity = "severity";
        public const string TriggeredEntityDefinition = "triggeredEntityDefinition";
        public const string AffectedEntityDefinition = "affectedEntityDefinition";
        public const string EntityType = "entityType";
        public const string EntityId = "entityId";
        public const string DeepLinkUrl = "deepLinkUrl";
        public const string Event = "event";
        public const string Events = "events";
        public const string EventTime = "eventTime";
        public const string Archived = "archived";
        public const string MarkedAsResolved = "markedAsResolved";
        public const string MarkedAsRead = "markedAsRead";
        public const string AffectedEntities = "affectedEntities";
        public const string EntityDefinition = "entity-definition";

        //Backends
        public const string Backends = "backends";

        public const string Backend = "backend";
        public const string ApplicationComponentNodeId = "applicationComponentNodeId";
        public const string TierId = "BtTierId";
        public const string BcExitPointType = "exitPointType";

        public readonly Dictionary<string, string> TimeRange = new Dictionary<string, string>();

        private Dictionary()
        {
            TimeRange["BEFORE_NODE"] = "1";
            TimeRange["BEFORE_TIME"] = "2";
            TimeRange["AFTER_TIME"] = "3";
            TimeRange["BETWEEN_TIMES"] = "4";
        }
    }
}
