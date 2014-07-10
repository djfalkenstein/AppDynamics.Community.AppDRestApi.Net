// ***********************************************************************
// Assembly         : AppDynamics.Community.AppDRestApi.Net
// Author           : David.Falkenstein
// Created          : 07-02-2014
//
// Last Modified By : David.Falkenstein
// Last Modified On : 07-05-2014
// ***********************************************************************
// <copyright file="RestAccess.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using AppDynamics.Community.AppDRestApi.Net.Entities;
using AppDynamics.Community.AppDRestApi.Net.Objects;
using AppDynamics.Community.AppDRestApi.Net.Queries;
using AppDynamics.Community.AppDRestApi.Net.Resources;
using AppDynamics.Community.AppDRestApi.Net.Util;

namespace AppDynamics.Community.AppDRestApi.Net
{
    /// <summary>
    /// Class RestAccess.
    /// </summary>
    public class RestAccess
    {
        #region Properties
        /// <summary>
        /// Gets the controller URL.
        /// </summary>
        /// <value>The controller URL.</value>
        public static string ControllerUrl { get; private set; }
        /// <summary>
        /// Gets the controller port.
        /// </summary>
        /// <value>The controller port.</value>
        public static string ControllerPort { get; private set; }
        /// <summary>
        /// Gets a value indicating whether [use SSL].
        /// </summary>
        /// <value><c>true</c> if [use SSL]; otherwise, <c>false</c>.</value>
        public static bool UseSsl { get; private set; }
        /// <summary>
        /// Gets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public static string UserName { get; private set; }
        /// <summary>
        /// Gets the user password.
        /// </summary>
        /// <value>The user password.</value>
        public static string UserPassword { get; private set; }
        /// <summary>
        /// Gets the account.
        /// </summary>
        /// <value>The account.</value>
        public static string Account { get; private set; }
        /// <summary>
        /// Gets the authentication.
        /// </summary>
        /// <value>The authentication.</value>
        public static RestAuth Auth { get; private set; }
        /// <summary>
        /// Gets the base URL.
        /// </summary>
        /// <value>The base URL.</value>
        public static ControllerBaseUrl BaseUrl { get; private set; }

        /// <summary>
        /// The value
        /// </summary>
        public readonly Validation Val = new Validation();
        /// <summary>
        /// The re
        /// </summary>
        public static RestExecuter Re = new RestExecuter();

        #endregion
        
        #region RestAccess
        /// <summary>
        /// Returns a RESTAccess object that can be used to query the AppDynamics.Community.AppDRestApi
        /// controller.
        /// </summary>
        /// <param name="controllerUrl">FQDN of the controller</param>
        /// <param name="port">Port the controller is using</param>
        /// <param name="username">User to execute the query as</param>
        /// <param name="password">Password to use with the connection</param>
        /// <exception cref="System.ArgumentNullException">controllerUrl
        /// or
        /// port
        /// or
        /// username
        /// or
        /// password</exception>
        public RestAccess(string controllerUrl, string port, string username, string password)
        {
            if (controllerUrl == null) throw new ArgumentNullException("controllerUrl");
            if (port == null) throw new ArgumentNullException("port");
            if (username == null) throw new ArgumentNullException("username");
            if (password == null) throw new ArgumentNullException("password");

            ControllerUrl = Val.ValidaleDns(controllerUrl);
            ControllerPort = Val.ValidatePort(port);
            UserName = Val.ValidateUsername(username);
            UserPassword = Val.ValidatePassword(password);

            BaseUrl = new ControllerBaseUrl(ControllerUrl, ControllerPort);
            Auth = new RestAuth(UserName, UserPassword);
        }

        /// <summary>
        /// Returns a RESTAccess object that can be used to query the AppDynamics.Community.AppDRestApi
        /// controller.
        /// </summary>
        /// <param name="controllerUrl">FQDN of the controller</param>
        /// <param name="port">Port the controller is using</param>
        /// <param name="useSsl">Use SSL</param>
        /// <param name="username">User to execute the query as</param>
        /// <param name="password">Password to use with the connection</param>
        /// <exception cref="System.ArgumentNullException">controllerUrl
        /// or
        /// port
        /// or
        /// username
        /// or
        /// password</exception>
        public RestAccess(string controllerUrl, string port, bool useSsl, string username, string password)
        {
            if (controllerUrl == null) throw new ArgumentNullException("controllerUrl");
            if (port == null) throw new ArgumentNullException("port");
            if (username == null) throw new ArgumentNullException("username");
            if (password == null) throw new ArgumentNullException("password");

            ControllerUrl = Val.ValidaleDns(controllerUrl);
            ControllerPort = Val.ValidatePort(port);
            UserName = Val.ValidateUsername(username);
            UserPassword = Val.ValidatePassword(password);
            UseSsl = useSsl;

            BaseUrl = new ControllerBaseUrl(ControllerUrl, ControllerPort, UseSsl);
            Auth = new RestAuth(UserName, UserPassword);
        }

        /// <summary>
        /// Returns a RESTAccess object that can be used to query the AppDynamics.Community.AppDRestApi
        /// controller.
        /// </summary>
        /// <param name="controllerUrl">FQDN of the controller</param>
        /// <param name="port">Port the controller is using</param>
        /// <param name="username">User to execute the query as</param>
        /// <param name="password">Password to use with the connection</param>
        /// <param name="account">Account name to use with the queries</param>
        /// <exception cref="System.ArgumentNullException">controllerUrl
        /// or
        /// port
        /// or
        /// username
        /// or
        /// password
        /// or
        /// account</exception>
        public RestAccess(string controllerUrl, string port, string username, string password, string account)
        {
            if (controllerUrl == null) throw new ArgumentNullException("controllerUrl");
            if (port == null) throw new ArgumentNullException("port");
            if (username == null) throw new ArgumentNullException("username");
            if (password == null) throw new ArgumentNullException("password");
            if (account == null) throw new ArgumentNullException("account");

            ControllerUrl = Val.ValidaleDns(controllerUrl);
            ControllerPort = Val.ValidatePort(port);
            UserName = Val.ValidateUsername(username);
            UserPassword = Val.ValidatePassword(password);
            Account = Val.ValidateAccount(account);

            BaseUrl = new ControllerBaseUrl(ControllerUrl, ControllerPort);
            Auth = new RestAuth(UserName, UserPassword, Account, true);
        }

        /// <summary>
        /// Returns a RESTAccess object that can be used to query the AppDynamics.Community.AppDRestApi
        /// controller.
        /// </summary>
        /// <param name="controllerUrl">FQDN of the controller</param>
        /// <param name="port">Port the controller is using</param>
        /// <param name="useSsl">Use SSL</param>
        /// <param name="username">User to execute the query as</param>
        /// <param name="password">Password to use with the connection</param>
        /// <param name="account">Account name to use with the queries</param>
        /// <exception cref="System.ArgumentNullException">controllerUrl
        /// or
        /// port
        /// or
        /// username
        /// or
        /// password
        /// or
        /// account</exception>
        public RestAccess(string controllerUrl, string port, bool useSsl, string username, string password, string account)
        {
            if (controllerUrl == null) throw new ArgumentNullException("controllerUrl");
            if (port == null) throw new ArgumentNullException("port");
            if (username == null) throw new ArgumentNullException("username");
            if (password == null) throw new ArgumentNullException("password");
            if (account == null) throw new ArgumentNullException("account");

            ControllerUrl = Val.ValidaleDns(controllerUrl);
            ControllerPort = Val.ValidatePort(port);
            UserName = Val.ValidateUsername(username);
            UserPassword = Val.ValidatePassword(password);
            Account = Val.ValidateAccount(account);
            UseSsl = useSsl;

            BaseUrl = new ControllerBaseUrl(ControllerUrl, ControllerPort, UseSsl);
            Auth = new RestAuth(UserName, UserPassword, Account, true);
        }

        /// <summary>
        /// Returns a RESTAccess object that can be used to query the AppDynamics.Community.AppDRestApi
        /// controller.
        /// </summary>
        /// <param name="controllerUrl">FQDN of the controller</param>
        /// <param name="useSsl">Use SSL</param>
        /// <param name="username">User to execute the query as</param>
        /// <param name="password">Password to use with the connection</param>
        /// <param name="account">Account name to use with the queries</param>
        /// <exception cref="System.ArgumentNullException">controllerUrl
        /// or
        /// username
        /// or
        /// password
        /// or
        /// account</exception>
        public RestAccess(string controllerUrl, bool useSsl, string username, string password, string account)
        {
            if (controllerUrl == null) throw new ArgumentNullException("controllerUrl");
            if (username == null) throw new ArgumentNullException("username");
            if (password == null) throw new ArgumentNullException("password");
            if (account == null) throw new ArgumentNullException("account");

            ControllerUrl = Val.ValidaleDns(controllerUrl);
            UserName = Val.ValidateUsername(username);
            UserPassword = Val.ValidatePassword(password);
            Account = Val.ValidateAccount(account);
            UseSsl = useSsl;

            BaseUrl = new ControllerBaseUrl(ControllerUrl, UseSsl);
            Auth = new RestAuth(UserName, UserPassword, Account, true);
        }
        #endregion

        /// <summary>
        /// Class ApplicationFunctions.
        /// </summary>
        public class ApplicationFunctions
	    {
            #region Application Functions
            /// <summary>
            /// Gets all applications.
            /// </summary>
            /// <returns>List&lt;Application&gt;.</returns>
            public virtual List<Application> GetAllApplications()
            {
                string url = BaseUrl.ControllerUrlToString + Dictionary.ControllerApps + Dictionary.UseJson;
                return Re.ExecuteApplicationQuery(Auth, url);
            }


            /// <summary>
            /// Gets the application export by identifier.
            /// </summary>
            /// <param name="appId">The application identifier.</param>
            /// <returns>List&lt;Application&gt;.</returns>
            public virtual List<Application> GetApplicationExportById(int appId)
            {
                //TODO: Verify
                string url = BaseUrl.ControllerUrlToString + Dictionary.ApplicationExId + appId + Dictionary.UseJson;
                return Re.ExecuteApplicationQuery(Auth, url);
            }

            /// <summary>
            /// Returns the backends for an application name.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <returns>Backends.</returns>
            public virtual List<Backend> GetBackendsForApplication(string application)
            {
                BackendsQuery bq = new BackendsQuery();
                return Re.ExecuteBackendsQuery(Auth, bq.BuildUrlStringBackendsFromApps(BaseUrl.ControllerUrlToString, application));
            }

            #endregion
	}

        /// <summary>
        /// Class BtFunctions.
        /// </summary>
        public class BtFunctions
        {
            #region BT Functions

            /// <summary>
            /// Returns the business transactions for an application name.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <returns><seealso cref="BusinessTransactions" /></returns>
            public virtual List<BusinessTransaction> GetBtsForApplication(string application)
            {
                //BusinessTransactionQuery btq = new BusinessTransactionQuery();
                //return Re.ExecuteBusinessTransactionQuery(Auth, btq.BuildUrlStringGetAllBtsForApp(BaseUrl.ControllerUrlToString, application));

                BusinessTransactionQuery btq = new BusinessTransactionQuery();
                string queryBtsFromApps = btq.BuildUrlStringGetAllBtsForApp(BaseUrl.ControllerUrlToString, application);
                return Re.ExecuteBusinessTransactionQuery(Auth, queryBtsFromApps);
            }

            /// <summary>
            /// Returns the business transactions for an application id.
            /// </summary>
            /// <param name="appId">The id for the application</param>
            /// <returns><seealso cref="BusinessTransactions" /></returns>
            public virtual List<BusinessTransaction> GetBtsForApplication(int appId)
            {
                BusinessTransactionQuery btq = new BusinessTransactionQuery();
                string queryBtsFromApps = btq.BuildUrlStringGetAllBtsForApp(BaseUrl.ControllerUrlToString, appId);
                return Re.ExecuteBusinessTransactionQuery(Auth, queryBtsFromApps);
            }

            /// <summary>
            /// Gets the bt for application.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <param name="btId">Id of the Business Transaction</param>
            /// <returns><seealso cref="BusinessTransactions" /></returns>
            public virtual List<BusinessTransaction> GetBtForApplication(string application, int btId)
            {
                BusinessTransactionQuery btq = new BusinessTransactionQuery();
                return Re.ExecuteBusinessTransactionQuery(Auth, btq.QueryBtFromApps(BaseUrl.ControllerUrlToString, application, btId));
            }

            /// <summary>
            /// Gets the bt for application.
            /// </summary>
            /// <param name="appId">The id for the application</param>
            /// <param name="btId">Id of the Business Transaction</param>
            /// <returns><seealso cref="BusinessTransactions" /></returns>
            public virtual List<BusinessTransaction> GetBtForApplication(int appId, int btId)
            {
                BusinessTransactionQuery btq = new BusinessTransactionQuery();
                return Re.ExecuteBusinessTransactionQuery(Auth, btq.QueryBtFromApps(BaseUrl.ControllerUrlToString, appId, btId));
            }

            #endregion
        }

        /// <summary>
        /// Class EventFunctions.
        /// </summary>
        public class EventFunctions
        {
            /// <summary>
            /// Returns the events for an application.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <param name="eventTypes">Event types to request, comma delimited list</param>
            /// <param name="severities">Severities to request, comma delimited list</param>
            /// <param name="start">Timestamp of the start time</param>
            /// <param name="end">Timestamp of the end time</param>
            /// <returns><seealso cref="Events" /></returns>
            public virtual List<Event> GetEvents(string application, string eventTypes, string severities, long start, long end)
            {
                EventsQuery eq = new EventsQuery();
                return Re.ExecuteEventsQuery(Auth, eq.BuildUrlStringPolicyViolationsSFromApps(BaseUrl.ControllerUrlToString, application, eventTypes, severities, start, end));
            }
        }

        /// <summary>
        /// Class HealthRuleFunctions.
        /// </summary>
        public class HealthRuleFunctions
        {
            /// <summary>
            /// Returns the health rule violations for an application.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <param name="start">Timestamp of the start time</param>
            /// <param name="end">Timestamp of the end time</param>
            /// <returns><seealso cref="PolicyViolations" /></returns>
            public virtual List<PolicyViolation> GetHealthRuleViolations(string application, long start, long end)
            {
                PolicyViolationQuery pvq = new PolicyViolationQuery();
                return Re.ExecutePolicyViolationsQuery(Auth, pvq.BuildUrlStringHealthRuleViolationsFromApps(BaseUrl.ControllerUrlToString, application, start, end));
            }
        }

        /// <summary>
        /// Class MetricFunctions.
        /// </summary>
        public class MetricFunctions
	    {
		     #region Metric Functions

            /// <summary>
            /// This will return the list of the metric path bases, for example 'Business Transaction Performance"
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <returns><seealso cref="MetricItems" /></returns>
            public virtual List<MetricItem> GetBaseMetricList(string application)
            {
                MetricItemQuery miq = new MetricItemQuery();
                return Re.ExecuteMetricItemsQuery(Auth, miq.BuildUrlStringMetricList(BaseUrl.ControllerUrlToString, application));
            }

            /// <summary>
            /// This will allow the user to provide the metric path they wish to walk. The paths need to be separated by the character '|'
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <param name="metricPath">Metric path to the metric list requested</param>
            /// <returns><seealso cref="MetricItems" /></returns>
            public virtual List<MetricItem> GetBaseMetricListPath(string application, string metricPath)
            {
                MetricItemQuery miq = new MetricItemQuery();
                return Re.ExecuteMetricItemsQuery(Auth, miq.BuildUrlStringMetricListForPath(BaseUrl.ControllerUrlToString, application, metricPath));
            }

            /// <summary>
            /// This is going to execute a generic query based on the application and full metric path provided.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <param name="metricPath">String that determine which metric to request</param>
            /// <param name="start">Timestamp of the start time</param>
            /// <param name="end">Timestamp of the end time</param>
            /// <param name="rollup">Boolean determines whether to roll up the metrics</param>
            /// <returns><seealso cref="MetricDataArray" /></returns>
            public virtual List<MetricData> GetRestGenericMetricQuery(string application, string metricPath, long start, long end, bool rollup)
            {
                MetricItemQuery miq = new MetricItemQuery();
                return Re.ExecuteMetricQuery(Auth, miq.BuildUrlStringGeneralMetricQuery(BaseUrl.ControllerUrlToString, application, metricPath, start, end, rollup));
            }

        #endregion
	    }

        /// <summary>
        /// Class NodeFunctions.
        /// </summary>
        public class NodeFunctions
        {
            #region Node Functions

            /// <summary>
            /// Gets the nodes from tier.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <param name="tier">Name of the tier</param>
            /// <returns><seealso cref="Nodes" /></returns>
            public virtual List<Node> GetNodesFromTier(string application, string tier)
            {
                TierQuery tq = new TierQuery();
                return Re.ExecuteNodeQuery(Auth, tq.BuildUrlStringNodesFromTier(BaseUrl.ControllerUrlToString, application, tier));
            }

            /// <summary>
            /// Gets the nodes from tier.
            /// </summary>
            /// <param name="application">Id of the application</param>
            /// <param name="tier">Name of the tier</param>
            /// <returns><seealso cref="Nodes" /></returns>
            public virtual List<Node> GetNodesFromTier(int application, string tier)
            {
                TierQuery tq = new TierQuery();
                return Re.ExecuteNodeQuery(Auth, tq.BuildUrlStringNodesFromTier(BaseUrl.ControllerUrlToString, application, tier));
            }

            /// <summary>
            /// Gets the nodes from tier.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <param name="tier">Id of the tier</param>
            /// <returns><seealso cref="Nodes" /></returns>
            public virtual List<Node> GetNodesFromTier(string application, int tier)
            {
                TierQuery tq = new TierQuery();
                return Re.ExecuteNodeQuery(Auth, tq.BuildUrlStringNodesFromTier(BaseUrl.ControllerUrlToString, application, tier));
            }

            /// <summary>
            /// Gets the nodes from tier.
            /// </summary>
            /// <param name="application">Id of the application</param>
            /// <param name="tier">Id of the tier</param>
            /// <returns>Nodes.</returns>
            public virtual List<Node> GetNodesFromTier(int application, int tier)
            {
                TierQuery tq = new TierQuery();
                return Re.ExecuteNodeQuery(Auth, tq.BuildUrlStringNodesFromTier(BaseUrl.ControllerUrlToString, application, tier));
            }

            /// <summary>
            /// Returns the nodes for an application name.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <returns><seealso cref="Nodes" /></returns>
            public virtual List<Node> GetNodesForApplication(string application)
            {
                NodeQuery nq = new NodeQuery();
                return Re.ExecuteNodeQuery(Auth, nq.BuildUrlStringNodesFromApps(BaseUrl.ControllerUrlToString, application));
            }

            /// <summary>
            /// Returns the nodes for an application id.
            /// </summary>
            /// <param name="application">Id of the application</param>
            /// <returns><seealso cref="Nodes" /></returns>
            public virtual List<Node> GetNodesForApplication(int application)
            {
                NodeQuery nq = new NodeQuery();
                return Re.ExecuteNodeQuery(Auth, nq.BuildUrlStringNodesFromApps(BaseUrl.ControllerUrlToString, application));
            }

            /// <summary>
            /// Gets the node for application.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <param name="nodeId">id of the Node</param>
            /// <returns><seealso cref="Nodes" /></returns>
            public virtual List<Node> GetNodeForApplication(string application, int nodeId)
            {
                NodeQuery nq = new NodeQuery();
                return Re.ExecuteNodeQuery(Auth, nq.BuildUrlStringNodeFromApps(BaseUrl.ControllerUrlToString, application, nodeId));
            }

            /// <summary>
            /// Gets the node for application.
            /// </summary>
            /// <param name="application">Id of the application</param>
            /// <param name="nodeId">Id of the Node</param>
            /// <returns><seealso cref="Nodes" /></returns>
            public virtual List<Node> GetNodeForApplication(int application, int nodeId)
            {
                NodeQuery nq = new NodeQuery();
                return Re.ExecuteNodeQuery(Auth, nq.BuildUrlStringNodeFromApps(BaseUrl.ControllerUrlToString, application, nodeId));
            }

            #endregion
        }

        /// <summary>
        /// Class PolicyFunctions.
        /// </summary>
        public class PolicyFunctions
        {
            /// <summary>
            /// Returns the policy violations for an application.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <param name="start">Timestamp for the start time</param>
            /// <param name="end">Timestamp for the end time</param>
            /// <returns><seealso cref="PolicyViolations" /></returns>
            public virtual List<PolicyViolation> GetPolicyViolations(string application, long start, long end)
            {
                PolicyViolationQuery pvq = new PolicyViolationQuery();
                return Re.ExecutePolicyViolationsQuery(Auth, pvq.BuildUrlStringHealthRuleViolationsFromApps(BaseUrl.ControllerUrlToString, application, start, end));
            }
        }

        /// <summary>
        /// Class SnapShotFunctions.
        /// </summary>
        public class SnapShotFunctions
        {
            #region Snapshot Functions

            /// <summary>
            /// Gets the snapshots.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <param name="start">Timestamp of the start time</param>
            /// <param name="end">Timestamp of the end time</param>
            /// <returns><seealso cref="Snapshots" /></returns>
            public virtual List<Snapshot> GetSnapshots(string application, long start, long end)
            {
                SnapshotQuery ssq = new SnapshotQuery();
                return Re.ExecuteSnapshotsQuery(Auth, ssq.BuildUrlStringRequestSnapshot(BaseUrl.ControllerUrlToString, application, start, end));
            }

            /// <summary>
            /// Gets the snapshots.
            /// </summary>
            /// <param name="application">Id of the application</param>
            /// <param name="start">Timestamp of the start time</param>
            /// <param name="end">Timestamp of the end time</param>
            /// <returns><seealso cref="Snapshots" /></returns>
            public virtual List<Snapshot> GetSnapshots(int application, long start, long end)
            {
                SnapshotQuery ssq = new SnapshotQuery();
                return Re.ExecuteSnapshotsQuery(Auth, ssq.BuildUrlStringRequestSnapshot(BaseUrl.ControllerUrlToString, application, start, end));
            }

            #endregion
        }

        /// <summary>
        /// Class TierFunctions.
        /// </summary>
        public class TierFunctions
        {
            #region Tier Functions

            /// <summary>
            /// Returns the tiers for an application name.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <returns><seealso cref="Tiers" /></returns>
            public virtual List<Tier> GetTiersForApplication(string application)
            {
                TierQuery tq = new TierQuery();
                return Re.ExecuteTierQuery(Auth, tq.BuildUrlStringTiersFromApps(BaseUrl.ControllerUrlToString, application));
            }

            /// <summary>
            /// Returns the tiers for an application id.
            /// </summary>
            /// <param name="application">ExApplication id</param>
            /// <returns><seealso cref="Tiers" /></returns>
            public virtual List<Tier> GetTiersForApplication(int application)
            {
                TierQuery tq = new TierQuery();
                return Re.ExecuteTierQuery(Auth, tq.BuildUrlStringTiersFromApps(BaseUrl.ControllerUrlToString, application));
            }

            /// <summary>
            /// Gets the tier for application.
            /// </summary>
            /// <param name="application">Name of the application</param>
            /// <param name="tierId">ID of the Tier</param>
            /// <returns><seealso cref="Tiers" /></returns>
            public virtual List<Tier> GetTierForApplication(string application, int tierId)
            {
                TierQuery tq = new TierQuery();
                return Re.ExecuteTierQuery(Auth, tq.BuildUrlStringTierFromApps(BaseUrl.ControllerUrlToString, application, tierId));
            }

            /// <summary>
            /// Gets the tier for application.
            /// </summary>
            /// <param name="application">ExApplication id</param>
            /// <param name="tierId">ID of the Tier</param>
            /// <returns><seealso cref="Tiers" /></returns>
            public virtual List<Tier> GetTierForApplication(int application, int tierId)
            {
                TierQuery tq = new TierQuery();
                return Re.ExecuteTierQuery(Auth, tq.BuildUrlStringTierFromApps(BaseUrl.ControllerUrlToString, application, tierId));
            }
            #endregion
        }

        /// <summary>
        /// Class MetricQueries.
        /// </summary>
        public class MetricQueries
        {
            #region GetRestMetricQuery

            /// <summary>
            /// Returns MetricData that can be parsed
            /// Case statement to determine Query string. Possible Results
            /// </summary>
            /// <param name="queryIndex">Index of the type of query to run</param>
            /// <param name="application">Name of the application which holds the metric</param>
            /// <param name="tier">Name of the tier which holds the metric</param>
            /// <param name="start">Timestamp in milliseconds for the start time for the query</param>
            /// <param name="end">Timestamp in milliseconds for the end time for the query</param>
            /// <returns><seealso cref="MetricDataArray" />
            /// <para>
            ///   <br />Index 0  : queyrAgentTierAppAgentAvailability
            /// <br />Index 1  : BuildUrlStringAgentTierMachineAgentAvailability
            /// <br />Index 2  : BuildUrlStringHdTierCPUBusy
            /// <br />Index 3  : BuildUrlStringHdTierCPUIdle
            /// <br />Index 4  : BuildUrlStringHdTierCPUStolen
            /// <br />Index 5  : BuildUrlStringHdTierDisksKBReadPerSec
            /// <br />Index 6  : BuildUrlStringHdTierDisksKBWrittenPerSec
            /// <br />Index 7  : BuildUrlStringHdTierDisksReadPerSec
            /// <br />Index 8  : BuildUrlStringHdTierDisksWritesPerSec
            /// <br />Index 9  : BuildUrlStringHdTierMemoryFreePerc
            /// <br />Index 10 : BuildUrlStringHdTierMemoryFreeMB
            /// <br />Index 11 : BuildUrlStringHdTierMemoryTotalMB
            /// <br />Index 12 : BuildUrlStringHdTierMemoryUsedPerc
            /// <br />Index 13 : BuildUrlStringHdTierMemoryUsedMB
            /// <br />Index 14 : BuildUrlStringHdTierNetworkIncomingKB
            /// <br />Index 15 : BuildUrlStringHdTierNetworkIncomingKBPerSec
            /// <br />Index 16 : BuildUrlStringHdTierNetworkIncomingPackets
            /// <br />Index 17 : BuildUrlStringHdTierNetworkIncomingPacketsPerSec
            /// <br />Index 18 : BuildUrlStringHdTierNetworkOutgoingKB
            /// <br />Index 19 : BuildUrlStringHdTierNetworkOutgoingKBPerSec
            /// <br />Index 20 : BuildUrlStringHdTierNetworkOutgoingPackets
            /// <br />Index 21 : BuildUrlStringHdTierNetworkOutgoingPacketsPerSec
            /// <br />Index 22 : QueryJvmTierProcessCPUBurntMsPerMin
            /// <br />Index 23 : QueryJvmTierProcessCPUUsagePerc
            /// <br />Index 24 : QueryJvmTierGarbageCollectionGCTimeSpentPerMin
            /// <br />Index 25 : QueryJvmTierGarbageCollectionMajorCollectionTimeSpentPerMin
            /// <br />Index 26 : QueryJvmTierGarbageCollectionMinorCollectionTimeSpentPerMin
            /// <br />Index 27 : QueryJvmTierGarbageCollectionNumberOfMajorCollectionTimeSpentPerMin
            /// <br />Index 28 : QueryJvmTierGarbageCollectionNumberOfMinorCollectionTimeSpentPerMin
            /// <br />Index 29 : QueryJvmTierMemoryHeapCommittedMB
            /// <br />Index 30 : QueryJvmTierMemoryHeapCurrentUsageMB
            /// <br />Index 31 : QueryJvmTierMemoryHeapMaxAvailableMB
            /// <br />Index 32 : QueryJvmTierMemoryHeapUsedPerc
            /// <br />Index 33 : QueryJvmTierMemoryNonHeapCommittedMB
            /// <br />Index 34 : QueryJvmTierMemoryNonHeapCurrentUsageMB
            /// <br />Index 35 : QueryJvmTierMemoryNonHeapMaxAvailableMB
            /// <br />Index 36 : QueryJvmTierMemoryNonHeapUsedPerc
            /// <br />Index 37 : QueryJvmTierThreadsCurrentNoOfThreads
            /// <br />Index 38 : QueryOapTierStallCount
            /// <br />Index 39 : QueryOapTierNumberOfVerySlowCalls
            /// <br />Index 40 : QueryOapTierNumberOfSlowCalls
            /// <br />Index 41 : QueryOapTierInfrastructureErrorsPerMinute
            /// <br />Index 42 : QueryOapTierHttpErrorCodesPerMinute
            /// <br />Index 43 : QueryOapTierExceptionsPerMinute
            /// <br />Index 44 : QueryOapTierErrorsPerMinute
            /// <br />Index 45 : QueryOapTierErrorPageRedirectsPerMinute
            /// <br />Index 46 : QueryOapTierCallsPerMinute
            /// <br />Index 47 : QueryOapTierAvgResponseTimeMs
            /// </para>
            /// <para /></returns>
            public virtual List<MetricData> GetRestMetricQuery(int queryIndex, string application, string tier, long start, long end)
            {
                return GetRestMetricQuery(queryIndex, application, tier, start, end, false);
            }

            /// <summary>
            /// Returns MetricData that can be parsed
            /// Case statement to determine Query string. Possible Results
            /// </summary>
            /// <param name="queryIndex">Index of the type of query to run</param>
            /// <param name="application">Name of the application which holds the metric</param>
            /// <param name="tier">Name of the tier which holds the metric</param>
            /// <param name="start">Timestamp in milliseconds for the start time for the query</param>
            /// <param name="end">Timestamp in milliseconds for the end time for the query</param>
            /// <param name="rollup">Boolean determines whether to roll up the metrics</param>
            /// <returns><seealso cref="MetricDataArray" />
            /// <para>
            ///   <br />Index 0  : queyrAgentTierAppAgentAvailability
            /// <br />Index 1  : BuildUrlStringAgentTierMachineAgentAvailability
            /// <br />Index 2  : BuildUrlStringHdTierCPUBusy
            /// <br />Index 3  : BuildUrlStringHdTierCPUIdle
            /// <br />Index 4  : BuildUrlStringHdTierCPUStolen
            /// <br />Index 5  : BuildUrlStringHdTierDisksKBReadPerSec
            /// <br />Index 6  : BuildUrlStringHdTierDisksKBWrittenPerSec
            /// <br />Index 7  : BuildUrlStringHdTierDisksReadPerSec
            /// <br />Index 8  : BuildUrlStringHdTierDisksWritesPerSec
            /// <br />Index 9  : BuildUrlStringHdTierMemoryFreePerc
            /// <br />Index 10 : BuildUrlStringHdTierMemoryFreeMB
            /// <br />Index 11 : BuildUrlStringHdTierMemoryTotalMB
            /// <br />Index 12 : BuildUrlStringHdTierMemoryUsedPerc
            /// <br />Index 13 : BuildUrlStringHdTierMemoryUsedMB
            /// <br />Index 14 : BuildUrlStringHdTierNetworkIncomingKB
            /// <br />Index 15 : BuildUrlStringHdTierNetworkIncomingKBPerSec
            /// <br />Index 16 : BuildUrlStringHdTierNetworkIncomingPackets
            /// <br />Index 17 : BuildUrlStringHdTierNetworkIncomingPacketsPerSec
            /// <br />Index 18 : BuildUrlStringHdTierNetworkOutgoingKB
            /// <br />Index 19 : BuildUrlStringHdTierNetworkOutgoingKBPerSec
            /// <br />Index 20 : BuildUrlStringHdTierNetworkOutgoingPackets
            /// <br />Index 21 : BuildUrlStringHdTierNetworkOutgoingPacketsPerSec
            /// <br />Index 22 : QueryJvmTierProcessCPUBurntMsPerMin
            /// <br />Index 23 : QueryJvmTierProcessCPUUsagePerc
            /// <br />Index 24 : QueryJvmTierGarbageCollectionGCTimeSpentPerMin
            /// <br />Index 25 : QueryJvmTierGarbageCollectionMajorCollectionTimeSpentPerMin
            /// <br />Index 26 : QueryJvmTierGarbageCollectionMinorCollectionTimeSpentPerMin
            /// <br />Index 27 : QueryJvmTierGarbageCollectionNumberOfMajorCollectionTimeSpentPerMin
            /// <br />Index 28 : QueryJvmTierGarbageCollectionNumberOfMinorCollectionTimeSpentPerMin
            /// <br />Index 29 : QueryJvmTierMemoryHeapCommittedMB
            /// <br />Index 30 : QueryJvmTierMemoryHeapCurrentUsageMB
            /// <br />Index 31 : QueryJvmTierMemoryHeapMaxAvailableMB
            /// <br />Index 32 : QueryJvmTierMemoryHeapUsedPerc
            /// <br />Index 33 : QueryJvmTierMemoryNonHeapCommittedMB
            /// <br />Index 34 : QueryJvmTierMemoryNonHeapCurrentUsageMB
            /// <br />Index 35 : QueryJvmTierMemoryNonHeapMaxAvailableMB
            /// <br />Index 36 : QueryJvmTierMemoryNonHeapUsedPerc
            /// <br />Index 37 : QueryJvmTierThreadsCurrentNoOfThreads
            /// <br />Index 38 : QueryOapTierStallCount
            /// <br />Index 39 : QueryOapTierNumberOfVerySlowCalls
            /// <br />Index 40 : QueryOapTierNumberOfSlowCalls
            /// <br />Index 41 : QueryOapTierInfrastructureErrorsPerMinute
            /// <br />Index 42 : QueryOapTierHttpErrorCodesPerMinute
            /// <br />Index 43 : QueryOapTierExceptionsPerMinute
            /// <br />Index 44 : QueryOapTierErrorsPerMinute
            /// <br />Index 45 : QueryOapTierErrorPageRedirectsPerMinute
            /// <br />Index 46 : QueryOapTierCallsPerMinute
            /// <br />Index 47 : QueryOapTierAvgResponseTimeMs
            /// </para>
            /// <para /></returns>
            public virtual List<MetricData> GetRestMetricQuery(int queryIndex, string application, string tier, long start, long end, bool rollup)
            {
                string query = null;
                MetricQuery mq = new MetricQuery(BaseUrl.ControllerUrlToString, application);
                switch (queryIndex)
                {
                    case 0:
                        query = mq.BuildUrlStringAgentTierAppAgentAvailability(tier, start, end, rollup);
                        break;

                    case 1:
                        query = mq.BuildUrlStringAgentTierMachineAgentAvailability(tier, start, end, rollup);
                        break;

                    case 2:
                        query = mq.BuildUrlStringHdTierCpuBusy(tier, start, end, rollup);
                        break;

                    case 3:
                        query = mq.BuildUrlStringHdTierCpuIdle(tier, start, end, rollup);
                        break;

                    case 4:
                        query = mq.BuildUrlStringHdTierCpuStolen(tier, start, end, rollup);
                        break;

                    case 5:
                        query = mq.BuildUrlStringHdTierDisksKbReadPerSec(tier, start, end, rollup);
                        break;

                    case 6:
                        query = mq.BuildUrlStringHdTierDisksKbWrittenPerSec(tier, start, end, rollup);
                        break;

                    case 7:
                        query = mq.BuildUrlStringHdTierDisksReadPerSec(tier, start, end, rollup);
                        break;

                    case 8:
                        query = mq.BuildUrlStringHdTierDisksWritesPerSec(tier, start, end, rollup);
                        break;

                    case 9:
                        query = mq.BuildUrlStringHdTierMemoryFreePerc(tier, start, end, rollup);
                        break;

                    case 10:
                        query = mq.BuildUrlStringHdTierMemoryFreeMb(tier, start, end, rollup);
                        break;

                    case 11:
                        query = mq.BuildUrlStringHdTierMemoryTotalMb(tier, start, end, rollup);
                        break;

                    case 12:
                        query = mq.BuildUrlStringHdTierMemoryUsedPerc(tier, start, end, rollup);
                        break;

                    case 13:
                        query = mq.BuildUrlStringHdTierMemoryUsedMb(tier, start, end, rollup);
                        break;

                    case 14:
                        query = mq.BuildUrlStringHdTierNetworkIncomingKb(tier, start, end, rollup);
                        break;

                    case 15:
                        query = mq.BuildUrlStringHdTierNetworkIncomingKbPerSec(tier, start, end, rollup);
                        break;

                    case 16:
                        query = mq.BuildUrlStringHdTierNetworkIncomingPackets(tier, start, end, rollup);
                        break;

                    case 17:
                        query = mq.BuildUrlStringHdTierNetworkIncomingPacketsPerSec(tier, start, end, rollup);
                        break;

                    case 18:
                        query = mq.BuildUrlStringHdTierNetworkOutgoingKb(tier, start, end, rollup);
                        break;

                    case 19:
                        query = mq.BuildUrlStringHdTierNetworkOutgoingKbPerSec(tier, start, end, rollup);
                        break;

                    case 20:
                        query = mq.BuildUrlStringHdTierNetworkOutgoingPackets(tier, start, end, rollup);
                        break;

                    case 21:
                        query = mq.BuildUrlStringHdTierNetworkOutgoingPacketsPerSec(tier, start, end, rollup);
                        break;

                    case 22:
                        query = mq.QueryJvmTierProcessCpuBurntMsPerMin(tier, start, end, rollup);
                        break;

                    case 23:
                        query = mq.QueryJvmTierProcessCpuUsagePerc(tier, start, end, rollup);
                        break;

                    case 24:
                        query = mq.QueryJvmTierGarbageCollectionGcTimeSpentPerMin(tier, start, end, rollup);
                        break;

                    case 25:
                        query = mq.QueryJvmTierGarbageCollectionMajorCollectionTimeSpentPerMin(tier, start, end, rollup);
                        break;

                    case 26:
                        query = mq.QueryJvmTierGarbageCollectionMinorCollectionTimeSpentPerMin(tier, start, end, rollup);
                        break;

                    case 27:
                        query = mq.QueryJvmTierGarbageCollectionNumberOfMajorCollectionTimeSpentPerMin(tier, start, end, rollup);
                        break;

                    case 28:
                        query = mq.QueryJvmTierGarbageCollectionNumberOfMinorCollectionTimeSpentPerMin(tier, start, end, rollup);
                        break;

                    case 29:
                        query = mq.QueryJvmTierMemoryHeapCommittedMb(tier, start, end, rollup);
                        break;

                    case 30:
                        query = mq.QueryJvmTierMemoryHeapCurrentUsageMb(tier, start, end, rollup);
                        break;

                    case 31:
                        query = mq.QueryJvmTierMemoryHeapMaxAvailableMb(tier, start, end, rollup);
                        break;

                    case 32:
                        query = mq.QueryJvmTierMemoryHeapUsedPerc(tier, start, end, rollup);
                        break;

                    case 33:
                        query = mq.QueryJvmTierMemoryNonHeapCommittedMb(tier, start, end, rollup);
                        break;

                    case 34:
                        query = mq.QueryJvmTierMemoryNonHeapCurrentUsageMb(tier, start, end, rollup);
                        break;

                    case 35:
                        query = mq.QueryJvmTierMemoryNonHeapMaxAvailableMb(tier, start, end, rollup);
                        break;

                    case 36:
                        query = mq.QueryJvmTierMemoryNonHeapUsedPerc(tier, start, end, rollup);
                        break;

                    case 37:
                        query = mq.QueryJvmTierThreadsCurrentNoOfThreads(tier, start, end, rollup);
                        break;

                    case 38:
                        query = mq.QueryOapTierStallCount(tier, start, end, rollup);
                        break;

                    case 39:
                        query = mq.QueryOapTierNumberOfVerySlowCalls(tier, start, end, rollup);
                        break;

                    case 40:
                        query = mq.QueryOapTierNumberOfSlowCalls(tier, start, end, rollup);
                        break;

                    case 41:
                        query = mq.QueryOapTierInfrastructureErrorsPerMinute(tier, start, end, rollup);
                        break;

                    case 42:
                        query = mq.QueryOapTierHttpErrorCodesPerMinute(tier, start, end, rollup);
                        break;

                    case 43:
                        query = mq.QueryOapTierExceptionsPerMinute(tier, start, end, rollup);
                        break;

                    case 44:
                        query = mq.QueryOapTierErrorsPerMinute(tier, start, end, rollup);
                        break;

                    case 45:
                        query = mq.QueryOapTierErrorPageRedirectsPerMinute(tier, start, end, rollup);
                        break;

                    case 46:
                        query = mq.QueryOapTierCallsPerMinute(tier, start, end, rollup);
                        break;

                    case 47:
                        query = mq.QueryOapTierAvgResponseTimeMs(tier, start, end, rollup);
                        break;
                }

                return query == null ? null : Re.ExecuteMetricQuery(Auth, query);
            }

            /// <summary>
            /// Returns MetricData that can be parsed
            /// Case statement to determine Query string. Possible Results
            /// </summary>
            /// <param name="queryIndex">Index of the type of query to run</param>
            /// <param name="application">Name of the application which holds the metric</param>
            /// <param name="tier">Name of the tier which holds the metric</param>
            /// <param name="node">Name of the node which holds the metric</param>
            /// <param name="start">Timestamp in milliseconds for the start time for the query</param>
            /// <param name="end">Timestamp in milliseconds for the end time for the query</param>
            /// <returns><seealso cref="MetricDataArray" />
            /// <para>
            ///   <br />Index 0  : queyrAgentTierAppAgentAvailability
            /// <br />Index 1  : BuildUrlStringAgentTierMachineAgentAvailability
            /// <br />Index 2  : BuildUrlStringHdTierCPUBusy
            /// <br />Index 3  : BuildUrlStringHdTierCPUIdle
            /// <br />Index 4  : BuildUrlStringHdTierCPUStolen
            /// <br />Index 5  : BuildUrlStringHdTierDisksKBReadPerSec
            /// <br />Index 6  : BuildUrlStringHdTierDisksKBWrittenPerSec
            /// <br />Index 7  : BuildUrlStringHdTierDisksReadPerSec
            /// <br />Index 8  : BuildUrlStringHdTierDisksWritesPerSec
            /// <br />Index 9  : BuildUrlStringHdTierMemoryFreePerc
            /// <br />Index 10 : BuildUrlStringHdTierMemoryFreeMB
            /// <br />Index 11 : BuildUrlStringHdTierMemoryTotalMB
            /// <br />Index 12 : BuildUrlStringHdTierMemoryUsedPerc
            /// <br />Index 13 : BuildUrlStringHdTierMemoryUsedMB
            /// <br />Index 14 : BuildUrlStringHdTierNetworkIncomingKB
            /// <br />Index 15 : BuildUrlStringHdTierNetworkIncomingKBPerSec
            /// <br />Index 16 : BuildUrlStringHdTierNetworkIncomingPackets
            /// <br />Index 17 : BuildUrlStringHdTierNetworkIncomingPacketsPerSec
            /// <br />Index 18 : BuildUrlStringHdTierNetworkOutgoingKB
            /// <br />Index 19 : BuildUrlStringHdTierNetworkOutgoingKBPerSec
            /// <br />Index 20 : BuildUrlStringHdTierNetworkOutgoingPackets
            /// <br />Index 21 : BuildUrlStringHdTierNetworkOutgoingPacketsPerSec
            /// <br />Index 22 : QueryJvmTierProcessCPUBurntMsPerMin
            /// <br />Index 23 : QueryJvmTierProcessCPUUsagePerc
            /// <br />Index 24 : QueryJvmTierGarbageCollectionGCTimeSpentPerMin
            /// <br />Index 25 : QueryJvmTierGarbageCollectionMajorCollectionTimeSpentPerMin
            /// <br />Index 26 : QueryJvmTierGarbageCollectionMinorCollectionTimeSpentPerMin
            /// <br />Index 27 : QueryJvmTierGarbageCollectionNumberOfMajorCollectionTimeSpentPerMin
            /// <br />Index 28 : QueryJvmTierGarbageCollectionNumberOfMinorCollectionTimeSpentPerMin
            /// <br />Index 29 : QueryJvmTierMemoryHeapCommittedMB
            /// <br />Index 30 : QueryJvmTierMemoryHeapCurrentUsageMB
            /// <br />Index 31 : QueryJvmTierMemoryHeapMaxAvailableMB
            /// <br />Index 32 : QueryJvmTierMemoryHeapUsedPerc
            /// <br />Index 33 : QueryJvmTierMemoryNonHeapCommittedMB
            /// <br />Index 34 : QueryJvmTierMemoryNonHeapCurrentUsageMB
            /// <br />Index 35 : QueryJvmTierMemoryNonHeapMaxAvailableMB
            /// <br />Index 36 : QueryJvmTierMemoryNonHeapUsedPerc
            /// <br />Index 37 : QueryJvmTierThreadsCurrentNoOfThreads
            /// <br />Index 38 : QueryOapTierStallCount
            /// <br />Index 39 : QueryOapTierNumberOfVerySlowCalls
            /// <br />Index 40 : QueryOapTierNumberOfSlowCalls
            /// <br />Index 41 : QueryOapTierInfrastructureErrorsPerMinute
            /// <br />Index 42 : QueryOapTierHttpErrorCodesPerMinute
            /// <br />Index 43 : QueryOapTierExceptionsPerMinute
            /// <br />Index 44 : QueryOapTierErrorsPerMinute
            /// <br />Index 45 : QueryOapTierErrorPageRedirectsPerMinute
            /// <br />Index 46 : QueryOapTierCallsPerMinute
            /// <br />Index 47 : QueryOapTierAvgResponseTimeMs
            /// </para>
            /// <para /></returns>
            public virtual List<MetricData> GetRestMetricQuery(int queryIndex, string application, string tier, string node, long start, long end)
            {
                return GetRestMetricQuery(queryIndex, application, tier, node, start, end, false);
            }

            /// <summary>
            /// Returns MetricData that can be parsed
            /// Case statement to determine Query string. Possible Results
            /// </summary>
            /// <param name="queryIndex">Index of the type of query to run</param>
            /// <param name="application">Name of the application which holds the metric</param>
            /// <param name="tier">Name of the tier which holds the metric</param>
            /// <param name="node">Name of the node which holds the metric</param>
            /// <param name="start">Timestamp in milliseconds for the start time for the query</param>
            /// <param name="end">Timestamp in milliseconds for the end time for the query</param>
            /// <param name="rollup">Boolean determines whether to roll up the metrics</param>
            /// <returns><seealso cref="MetricDataArray" />
            /// <para>
            ///   <br />Index 0  : queyrAgentTierAppAgentAvailability
            /// <br />Index 1  : BuildUrlStringAgentTierMachineAgentAvailability
            /// <br />Index 2  : BuildUrlStringHdTierCPUBusy
            /// <br />Index 3  : BuildUrlStringHdTierCPUIdle
            /// <br />Index 4  : BuildUrlStringHdTierCPUStolen
            /// <br />Index 5  : BuildUrlStringHdTierDisksKBReadPerSec
            /// <br />Index 6  : BuildUrlStringHdTierDisksKBWrittenPerSec
            /// <br />Index 7  : BuildUrlStringHdTierDisksReadPerSec
            /// <br />Index 8  : BuildUrlStringHdTierDisksWritesPerSec
            /// <br />Index 9  : BuildUrlStringHdTierMemoryFreePerc
            /// <br />Index 10 : BuildUrlStringHdTierMemoryFreeMB
            /// <br />Index 11 : BuildUrlStringHdTierMemoryTotalMB
            /// <br />Index 12 : BuildUrlStringHdTierMemoryUsedPerc
            /// <br />Index 13 : BuildUrlStringHdTierMemoryUsedMB
            /// <br />Index 14 : BuildUrlStringHdTierNetworkIncomingKB
            /// <br />Index 15 : BuildUrlStringHdTierNetworkIncomingKBPerSec
            /// <br />Index 16 : BuildUrlStringHdTierNetworkIncomingPackets
            /// <br />Index 17 : BuildUrlStringHdTierNetworkIncomingPacketsPerSec
            /// <br />Index 18 : BuildUrlStringHdTierNetworkOutgoingKB
            /// <br />Index 19 : BuildUrlStringHdTierNetworkOutgoingKBPerSec
            /// <br />Index 20 : BuildUrlStringHdTierNetworkOutgoingPackets
            /// <br />Index 21 : BuildUrlStringHdTierNetworkOutgoingPacketsPerSec
            /// <br />Index 22 : QueryJvmTierProcessCPUBurntMsPerMin
            /// <br />Index 23 : QueryJvmTierProcessCPUUsagePerc
            /// <br />Index 24 : QueryJvmTierGarbageCollectionGCTimeSpentPerMin
            /// <br />Index 25 : QueryJvmTierGarbageCollectionMajorCollectionTimeSpentPerMin
            /// <br />Index 26 : QueryJvmTierGarbageCollectionMinorCollectionTimeSpentPerMin
            /// <br />Index 27 : QueryJvmTierGarbageCollectionNumberOfMajorCollectionTimeSpentPerMin
            /// <br />Index 28 : QueryJvmTierGarbageCollectionNumberOfMinorCollectionTimeSpentPerMin
            /// <br />Index 29 : QueryJvmTierMemoryHeapCommittedMB
            /// <br />Index 30 : QueryJvmTierMemoryHeapCurrentUsageMB
            /// <br />Index 31 : QueryJvmTierMemoryHeapMaxAvailableMB
            /// <br />Index 32 : QueryJvmTierMemoryHeapUsedPerc
            /// <br />Index 33 : QueryJvmTierMemoryNonHeapCommittedMB
            /// <br />Index 34 : QueryJvmTierMemoryNonHeapCurrentUsageMB
            /// <br />Index 35 : QueryJvmTierMemoryNonHeapMaxAvailableMB
            /// <br />Index 36 : QueryJvmTierMemoryNonHeapUsedPerc
            /// <br />Index 37 : QueryJvmTierThreadsCurrentNoOfThreads
            /// <br />Index 38 : QueryOapTierStallCount
            /// <br />Index 39 : QueryOapTierNumberOfVerySlowCalls
            /// <br />Index 40 : QueryOapTierNumberOfSlowCalls
            /// <br />Index 41 : QueryOapTierInfrastructureErrorsPerMinute
            /// <br />Index 42 : QueryOapTierHttpErrorCodesPerMinute
            /// <br />Index 43 : QueryOapTierExceptionsPerMinute
            /// <br />Index 44 : QueryOapTierErrorsPerMinute
            /// <br />Index 45 : QueryOapTierErrorPageRedirectsPerMinute
            /// <br />Index 46 : QueryOapTierCallsPerMinute
            /// <br />Index 47 : QueryOapTierAvgResponseTimeMs
            /// </para>
            /// <para /></returns>
            public virtual List<MetricData> GetRestMetricQuery(int queryIndex, string application, string tier, string node, long start, long end, bool rollup)
            {
                string query = null;
                MetricQuery mq = new MetricQuery(BaseUrl.ControllerUrlToString, application);
                switch (queryIndex)
                {
                    case 0:
                        // Agent query
                        query = mq.BuildUrlStringAgentNodeAppAgentAvailability(tier, node, start, end, rollup);
                        break;

                    case 1:
                        query = mq.BuildUrlStringAgentNodeMachineAgentAvailability(tier, node, start, end, rollup);
                        break;

                    case 2:
                        query = mq.BuildUrlStringHdNodeCpuBusy(tier, node, start, end, rollup);
                        break;

                    case 3:
                        query = mq.BuildUrlStringHdNodeCpuIdle(tier, node, start, end, rollup);
                        break;

                    case 4:
                        query = mq.BuildUrlStringHdNodeCpuStolen(tier, node, start, end, rollup);
                        break;

                    case 5:
                        query = mq.BuildUrlStringHdNodeDisksKbReadPerSec(tier, node, start, end, rollup);
                        break;

                    case 6:
                        query = mq.BuildUrlStringHdNodeDisksKbWrittenPerSec(tier, node, start, end, rollup);
                        break;

                    case 7:
                        query = mq.BuildUrlStringHdNodeDisksReadPerSec(tier, node, start, end, rollup);
                        break;

                    case 8:
                        query = mq.BuildUrlStringHdNodeDisksWritesPerSec(tier, node, start, end, rollup);
                        break;

                    case 9:
                        query = mq.BuildUrlStringHdNodeMemoryFreePerc(tier, node, start, end, rollup);
                        break;

                    case 10:
                        query = mq.BuildUrlStringHdNodeMemoryFreeMb(tier, node, start, end, rollup);
                        break;

                    case 11:
                        query = mq.BuildUrlStringHdNodeMemoryTotalMb(tier, node, start, end, rollup);
                        break;

                    case 12:
                        query = mq.BuildUrlStringHdNodeMemoryUsedPerc(tier, node, start, end, rollup);
                        break;

                    case 13:
                        query = mq.BuildUrlStringHdNodeMemoryUsedMb(tier, node, start, end, rollup);
                        break;

                    case 14:
                        query = mq.BuildUrlStringHdNodeNetworkIncomingKb(tier, node, start, end, rollup);
                        break;

                    case 15:
                        query = mq.BuildUrlStringHdNodeNetworkIncomingKbPerSec(tier, node, start, end, rollup);
                        break;

                    case 16:
                        query = mq.BuildUrlStringHdNodeNetworkIncomingPackets(tier, node, start, end, rollup);
                        break;

                    case 17:
                        query = mq.BuildUrlStringHdNodeNetworkIncomingPacketsPerSec(tier, node, start, end, rollup);
                        break;

                    case 18:
                        query = mq.BuildUrlStringHdNodeNetworkOutgoingKb(tier, node, start, end, rollup);
                        break;

                    case 19:
                        query = mq.BuildUrlStringHdNodeNetworkOutgoingKbPerSec(tier, node, start, end, rollup);
                        break;

                    case 20:
                        query = mq.BuildUrlStringHdNodeNetworkOutgoingPackets(tier, node, start, end, rollup);
                        break;

                    case 21:
                        query = mq.BuildUrlStringHdNodeNetworkOutgoingPacketsPerSec(tier, node, start, end, rollup);
                        break;

                    case 22:
                        query = mq.QueryJvmNodeProcessCpuBurntMsPerMin(tier, node, start, end, rollup);
                        break;

                    case 23:
                        query = mq.QueryJvmNodeProcessCpuUsagePerc(tier, node, start, end, rollup);
                        break;

                    case 24:
                        query = mq.QueryJvmNodeGarbageCollectionGcTimeSpentPerMin(tier, node, start, end, rollup);
                        break;

                    case 25:
                        query = mq.QueryJvmNodeGarbageCollectionMajorCollectionTimeSpentPerMin(tier, node, start, end, rollup);
                        break;

                    case 26:
                        query = mq.QueryJvmNodeGarbageCollectionMinorCollectionTimeSpentPerMin(tier, node, start, end, rollup);
                        break;

                    case 27:
                        query = mq.QueryJvmNodeGarbageCollectionNumberOfMajorCollectionTimeSpentPerMin(tier, node, start, end, rollup);
                        break;

                    case 28:
                        query = mq.QueryJvmNodeGarbageCollectionNumberOfMinorCollectionTimeSpentPerMin(tier, node, start, end, rollup);
                        break;

                    case 29:
                        query = mq.QueryJvmNodeMemoryHeapCommittedMb(tier, node, start, end, rollup);
                        break;

                    case 30:
                        query = mq.QueryJvmNodeMemoryHeapCurrentUsageMb(tier, node, start, end, rollup);
                        break;

                    case 31:
                        query = mq.QueryJvmNodeMemoryHeapMaxAvailableMb(tier, node, start, end, rollup);
                        break;

                    case 32:
                        query = mq.QueryJvmNodeMemoryHeapUsedPerc(tier, node, start, end, rollup);
                        break;

                    case 33:
                        query = mq.QueryJvmNodeMemoryNonHeapCommittedMb(tier, node, start, end, rollup);
                        break;

                    case 34:
                        query = mq.QueryJvmNodeMemoryNonHeapCurrentUsageMb(tier, node, start, end, rollup);
                        break;

                    case 35:
                        query = mq.QueryJvmNodeMemoryNonHeapMaxAvailableMb(tier, node, start, end, rollup);
                        break;

                    case 36:
                        query = mq.QueryJvmNodeMemoryNonHeapUsedPerc(tier, node, start, end, rollup);
                        break;

                    case 37:
                        query = mq.QueryJvmNodeThreadsCurrentNoOfThreads(tier, node, start, end, rollup);
                        break;

                    case 38:
                        query = mq.QueryOapNodeStallCount(tier, node, start, end, rollup);
                        break;

                    case 39:
                        query = mq.QueryOapNodeNumberOfVerySlowCalls(tier, node, start, end, rollup);
                        break;

                    case 40:
                        query = mq.QueryOapNodeNumberOfSlowCalls(tier, node, start, end, rollup);
                        break;

                    case 41:
                        query = mq.QueryOapNodeInfrastructureErrorsPerMinute(tier, node, start, end, rollup);
                        break;

                    case 42:
                        query = mq.QueryOapNodeHttpErrorCodesPerMinute(tier, node, start, end, rollup);
                        break;

                    case 43:
                        query = mq.QueryOapNodeExceptionsPerMinute(tier, node, start, end, rollup);
                        break;

                    case 44:
                        query = mq.QueryOapNodeErrorsPerMinute(tier, node, start, end, rollup);
                        break;

                    case 45:
                        query = mq.QueryOapNodeErrorPageRedirectsPerMinute(tier, node, start, end, rollup);
                        break;

                    case 46:
                        query = mq.QueryOapNodeCallsPerMinute(tier, node, start, end, rollup);
                        break;

                    case 47:
                        query = mq.QueryOapNodeAvgResponseTimeMs(tier, node, start, end, rollup);
                        break;
                }
                return query == null ? null : Re.ExecuteMetricQuery(Auth, query);
            }

            #endregion

            #region GetRestEumMetricQuery
            /// <summary>
            /// Gets the rest eum metric query.
            /// </summary>
            /// <param name="queryIndex">Index of the type of query to run</param>
            /// <param name="application">Name of the application which holds the metric</param>
            /// <param name="urlPath">URL path that was captured</param>
            /// <param name="start">Timestamp in milliseconds for the start time for the query</param>
            /// <param name="end">Timestamp in milliseconds for the end time for the query</param>
            /// <returns><seealso cref="MetricDataArray" />
            /// <para>
            ///   <br />Index  0 : QueryEumAjaxRequestsPerMin
            /// <br />Index  1 : QueryEumAjaxRequestsErrorsPerMin
            /// <br />Index  2 : QueryEumAjaxDocDownloadTime
            /// <br />Index  3 : QueryEumAjaxDocProcessingTime
            /// <br />Index  4 : QueryEumAjaxEndUserResponseTime
            /// <br />Index  5 : QueryEumAjaxFirstByteTimeMs
            /// <br />Index  6 : QueryEumBasePagesRequestsPerMin
            /// <br />Index  7 : QueryEumBasePagesDocReadyTimeMs
            /// <br />Index  8 : QueryEumBasePagesDocDownloadTime
            /// <br />Index  9 : QueryEumBasePagesDocProcessingTime
            /// <br />Index 10 : QueryEumBasePagesEndUserResponseTime
            /// <br />Index 11 : QueryEumBasePagesFirstByteTimeMs
            /// <br />Index 12 : QueryEumBasePagesFrontEndTimeMs
            /// <br />Index 13 : QueryEumBasePagesPageRenderTimeMs
            /// <br />Index 14 : QueryEumBasePagesPageViewsWithJavascriptErrorsPerMinute
            /// <br />Index 15 : QueryEumBasePagesResponseAvailableTimeMs
            /// <br />Index 16 : QueryEumBasePagesServerConnectionTimeMs
            /// <br />Index 17 : QueryEumBasePagesSyntheticRequestsPerMinute(urlPath, start, end);
            /// </para></returns>
            public virtual List<MetricData> GetRestEumMetricQuery(int queryIndex, string application, string urlPath, long start, long end)
            {
                return GetRestEumMetricQuery(queryIndex, application, urlPath, start, end, false);
            }

            /// <summary>
            /// Gets the rest eum metric query.
            /// </summary>
            /// <param name="queryIndex">Index of the type of query to run</param>
            /// <param name="application">Name of the application which holds the metric</param>
            /// <param name="urlPath">URL path that was captured</param>
            /// <param name="start">Timestamp in milliseconds for the start time for the query</param>
            /// <param name="end">Timestamp in milliseconds for the end time for the query</param>
            /// <param name="rollup">Boolean determines whether to roll up the metrics</param>
            /// <returns><seealso cref="MetricDataArray" />
            /// <para>
            ///   <br />Index  0 : QueryEumAjaxRequestsPerMin
            /// <br />Index  1 : QueryEumAjaxRequestsErrorsPerMin
            /// <br />Index  2 : QueryEumAjaxDocDownloadTime
            /// <br />Index  3 : QueryEumAjaxDocProcessingTime
            /// <br />Index  4 : QueryEumAjaxEndUserResponseTime
            /// <br />Index  5 : QueryEumAjaxFirstByteTimeMs
            /// <br />Index  6 : QueryEumBasePagesRequestsPerMin
            /// <br />Index  7 : QueryEumBasePagesDocReadyTimeMs
            /// <br />Index  8 : QueryEumBasePagesDocDownloadTime
            /// <br />Index  9 : QueryEumBasePagesDocProcessingTime
            /// <br />Index 10 : QueryEumBasePagesEndUserResponseTime
            /// <br />Index 11 : QueryEumBasePagesFirstByteTimeMs
            /// <br />Index 12 : QueryEumBasePagesFrontEndTimeMs
            /// <br />Index 13 : QueryEumBasePagesPageRenderTimeMs
            /// <br />Index 14 : QueryEumBasePagesPageViewsWithJavascriptErrorsPerMinute
            /// <br />Index 15 : QueryEumBasePagesResponseAvailableTimeMs
            /// <br />Index 16 : QueryEumBasePagesServerConnectionTimeMs
            /// <br />Index 17 : QueryEumBasePagesSyntheticRequestsPerMinute(urlPath, start, end);
            /// </para></returns>
            public virtual List<MetricData> GetRestEumMetricQuery(int queryIndex, string application, string urlPath, long start, long end, bool rollup)
            {
                string query = null;
                MetricQuery mq = new MetricQuery(BaseUrl.ControllerUrlToString, application);
                switch (queryIndex)
                {
                    case 0:
                        // Agent query
                        query = mq.QueryEumAjaxRequestsPerMin(urlPath, start, end, rollup);
                        break;

                    case 1:
                        // Agent query
                        query = mq.QueryEumAjaxRequestsErrorsPerMin(urlPath, start, end, rollup);
                        break;

                    case 2:
                        // Agent query
                        query = mq.QueryEumAjaxDocDownloadTime(urlPath, start, end, rollup);
                        break;

                    case 3:
                        // Agent query
                        query = mq.QueryEumAjaxDocProcessingTime(urlPath, start, end, rollup);
                        break;

                    case 4:
                        // Agent query
                        query = mq.QueryEumAjaxEndUserResponseTime(urlPath, start, end, rollup);
                        break;

                    case 5:
                        // Agent query
                        query = mq.QueryEumAjaxFirstByteTimeMs(urlPath, start, end, rollup);
                        break;

                    case 6:
                        // Agent query
                        query = mq.QueryEumBasePagesRequestsPerMin(urlPath, start, end, rollup);
                        break;

                    case 7:
                        // Agent query
                        query = mq.QueryEumBasePagesDocReadyTimeMs(urlPath, start, end, rollup);
                        break;

                    case 8:
                        // Agent query
                        query = mq.QueryEumBasePagesDocDownloadTime(urlPath, start, end, rollup);
                        break;

                    case 9:
                        // Agent query
                        query = mq.QueryEumBasePagesDocProcessingTime(urlPath, start, end, rollup);
                        break;

                    case 10:
                        // Agent query
                        query = mq.QueryEumBasePagesEndUserResponseTime(urlPath, start, end, rollup);
                        break;

                    case 11:
                        // Agent query
                        query = mq.QueryEumBasePagesFirstByteTimeMs(urlPath, start, end, rollup);
                        break;

                    case 12:
                        // Agent query
                        query = mq.QueryEumBasePagesFrontEndTimeMs(urlPath, start, end, rollup);
                        break;

                    case 13:
                        // Agent query
                        query = mq.QueryEumBasePagesPageRenderTimeMs(urlPath, start, end, rollup);
                        break;

                    case 14:
                        // Agent query
                        query = mq.QueryEumBasePagesPageViewsWithJavascriptErrorsPerMinute(urlPath, start, end, rollup);
                        break;

                    case 15:
                        // Agent query
                        query = mq.QueryEumBasePagesResponseAvailableTimeMs(urlPath, start, end, rollup);
                        break;

                    case 16:
                        // Agent query
                        query = mq.QueryEumBasePagesServerConnectionTimeMs(urlPath, start, end, rollup);
                        break;

                    case 17:
                        // Agent query
                        query = mq.QueryEumBasePagesSyntheticRequestsPerMinute(urlPath, start, end, rollup);
                        break;
                }
                //This will be the final check, to insure that we don't send a bad query.
                if (query == null)
                {
                    //logger.log(Level.WARNING,(new StringBuilder()).Append("\nMatching query was not found for queryIndex ").Append(queryIndex).Append(" application ").Append(application).Append(" url ").Append(urlPath).ToString());
                    return null;
                }
                return Re.ExecuteMetricQuery(Auth, query);
            }

            #endregion

            #region GetRestbtMetricQuery

            /// <summary>
            /// Gets the restbt metric query.
            /// </summary>
            /// <param name="queryIndex">Index of the type of query to run</param>
            /// <param name="application">Name of the application which holds the metric</param>
            /// <param name="tier">Name of the tier which holds the metric</param>
            /// <param name="site">Business transaction name</param>
            /// <param name="start">Timestamp in milliseconds for the start time for the query</param>
            /// <param name="end">Timestamp in milliseconds for the end time for the query</param>
            /// <returns><seealso cref="MetricDataArray" />
            /// <para>
            ///   <br />Index  0 : QueryBtAverageBlockTimeMs
            /// <br />Index  1 : QueryBtAverageCpuUsedMs
            /// <br />Index  2 : QueryBtAverageRequestSize
            /// <br />Index  3 : QueryBtAverageResponseTime
            /// <br />Index  4 : QueryBtAverageWaitTimeMs
            /// <br />Index  5 : QueryBtCallPerMinute
            /// <br />Index  6 : QueryBtErrorsPerMinute
            /// <br />Index  7 : QueryBtNormalAverageResponseTimeMs
            /// <br />Index  8 : QueryBtNumberOfSlowCalls
            /// <br />Index  9 : QueryBtNumberOfVerySlowCalls
            /// <br />Index 10 : QueryBtStallCount
            /// </para></returns>
            public virtual List<MetricData> GetRestbtMetricQuery(int queryIndex, string application, string tier, string site, long start, long end)
            {
                return GetRestbtMetricQuery(queryIndex, application, tier, site, start, end, false);
            }

            /// <summary>
            /// Gets the restbt metric query.
            /// </summary>
            /// <param name="queryIndex">Index of the type of query to run</param>
            /// <param name="application">Name of the application which holds the metric</param>
            /// <param name="tier">Name of the tier which holds the metric</param>
            /// <param name="site">Business transaction name</param>
            /// <param name="start">Timestamp in milliseconds for the start time for the query</param>
            /// <param name="end">Timestamp in milliseconds for the end time for the query</param>
            /// <param name="rollup">Boolean determines whether to roll up the metrics</param>
            /// <returns><seealso cref="MetricDataArray" />
            /// <para>
            ///   <br />Index  0 : QueryBtAverageBlockTimeMs
            /// <br />Index  1 : QueryBtAverageCpuUsedMs
            /// <br />Index  2 : QueryBtAverageRequestSize
            /// <br />Index  3 : QueryBtAverageResponseTime
            /// <br />Index  4 : QueryBtAverageWaitTimeMs
            /// <br />Index  5 : QueryBtCallPerMinute
            /// <br />Index  6 : QueryBtErrorsPerMinute
            /// <br />Index  7 : QueryBtNormalAverageResponseTimeMs
            /// <br />Index  8 : QueryBtNumberOfSlowCalls
            /// <br />Index  9 : QueryBtNumberOfVerySlowCalls
            /// <br />Index 10 : QueryBtStallCount
            /// </para></returns>
            public virtual List<MetricData> GetRestbtMetricQuery(int queryIndex, string application, string tier, string site, long start, long end, bool rollup)
            {
                string query = null;
                MetricQuery mq = new MetricQuery(BaseUrl.ControllerUrlToString, application);
                switch (queryIndex)
                {
                    case 0:
                        query = mq.QueryBtAverageBlockTimeMs(application, tier, site, start, end, rollup);
                        break;

                    case 1:
                        query = mq.QueryBtAverageCpuUsedMs(application, tier, site, start, end, rollup);
                        break;

                    case 2:
                        query = mq.QueryBtAverageRequestSize(application, tier, site, start, end, rollup);
                        break;

                    case 3:
                        query = mq.QueryBtAverageResponseTime(application, tier, site, start, end, rollup);
                        break;

                    case 4:
                        query = mq.QueryBtAverageWaitTimeMs(application, tier, site, start, end, rollup);
                        break;

                    case 5:
                        query = mq.QueryBtCallPerMinute(application, tier, site, start, end, rollup);
                        break;

                    case 6:
                        query = mq.QueryBtErrorsPerMinute(application, tier, site, start, end, rollup);
                        break;

                    case 7:
                        query = mq.QueryBtNormalAverageResponseTimeMs(application, tier, site, start, end, rollup);
                        break;

                    case 8:
                        query = mq.QueryBtNumberOfSlowCalls(application, tier, site, start, end, rollup);
                        break;

                    case 9:
                        query = mq.QueryBtNumberOfVerySlowCalls(application, tier, site, start, end, rollup);
                        break;

                    case 10:
                        query = mq.QueryBtStallCount(application, tier, site, start, end, rollup);
                        break;
                }

                //This will be the final check, to insure that we don't send a bad query.
                if (query == null)
                {
                    //logger.log(Level.WARNING,new StringBuilder().append("\nQueryIndex sent ").append(queryIndex).append(" application ").append(application).append(" tier ").append(tier).append(" site ").append(site).ToString());
                    return null;
                }

                return Re.ExecuteMetricQuery(Auth, query);
            }

            #endregion

            #region GetRestBackendMetricQuery

            /// <summary>
            /// Gets the rest backend metric query.
            /// </summary>
            /// <param name="queryIndex">Index of the type of query to run</param>
            /// <param name="application">Name of the application which holds the metric</param>
            /// <param name="tier">Name of the tier which holds the metric</param>
            /// <param name="start">Timestamp in milliseconds for the start time for the query</param>
            /// <param name="end">Timestamp in milliseconds for the end time for the query</param>
            /// <returns><seealso cref="MetricDataArray" />
            /// <para>
            ///   <br />Index  0 : queryBackendAverageResponseTimeMs
            /// <br />Index  1 : queryBackendCallsPerMinute
            /// <br />Index  2 : queryBackendErrorsPerMinute
            /// </para></returns>
            public virtual List<MetricData> GetRestBackendMetricQuery(int queryIndex, string application, string tier, long start, long end)
            {
                string query = null;
                MetricQuery mq = new MetricQuery(BaseUrl.ControllerUrlToString, application);
                switch (queryIndex)
                {
                    case 0:
                        query = mq.QueryBackendAverageResponseTimeMs(application, tier, start, end, false);
                        break;

                    case 1:
                        query = mq.QueryBackendCallsPerMinute(application, tier, start, end, false);
                        break;

                    case 2:
                        query = mq.QueryBackendErrorsPerMinute(application, tier, start, end, false);
                        break;
                }

                //This will be the final check, to insure that we don't send a bad query.
                if (query == null)
                {
                    //logger.log(Level.WARNING,new StringBuilder().append("\nQueryIndex sent ").append(queryIndex).append(" application ").append(application).append(" tier ").append(tier).ToString());
                    return null;
                }
                return Re.ExecuteMetricQuery(Auth, query);
            }

            /// <summary>
            /// Gets the rest backend metric query.
            /// </summary>
            /// <param name="queryIndex">Index of the type of query to run</param>
            /// <param name="application">Name of the application which holds the metric</param>
            /// <param name="tier">Name of the tier which holds the metric</param>
            /// <param name="start">Timestamp in milliseconds for the start time for the query</param>
            /// <param name="end">Timestamp in milliseconds for the end time for the query</param>
            /// <param name="rollup">Boolean determines whether to roll up the metrics</param>
            /// <returns><seealso cref="MetricDataArray" />
            /// <para>
            ///   <br />Index  0 : queryBackendAverageResponseTimeMs
            /// <br />Index  1 : queryBackendCallsPerMinute
            /// <br />Index  2 : queryBackendErrorsPerMinute
            /// </para></returns>
            public virtual List<MetricData> GetRestBackendMetricQuery(int queryIndex, string application, string tier, long start, long end, bool rollup)
            {
                string query = null;
                MetricQuery mq = new MetricQuery(BaseUrl.ControllerUrlToString, application);
                switch (queryIndex)
                {
                    case 0:
                        query = mq.QueryBackendAverageResponseTimeMs(application, tier, start, end, rollup);
                        break;

                    case 1:
                        query = mq.QueryBackendCallsPerMinute(application, tier, start, end, rollup);
                        break;

                    case 2:
                        query = mq.QueryBackendErrorsPerMinute(application, tier, start, end, rollup);
                        break;
                }

                //This will be the final check, to insure that we don't send a bad query.
                return query == null ? null : Re.ExecuteMetricQuery(Auth, query);
            }

            #endregion
        }
    }


}
