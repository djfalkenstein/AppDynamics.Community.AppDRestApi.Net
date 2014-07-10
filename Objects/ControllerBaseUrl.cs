// ***********************************************************************
// Assembly         : AppDynamics.Community.AppDRestApi.Net
// Author           : David.Falkenstein
// Created          : 07-02-2014
//
// Last Modified By : David.Falkenstein
// Last Modified On : 07-04-2014
// ***********************************************************************
// <copyright file="ControllerBaseUrl.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;
using AppDynamics.Community.AppDRestApi.Net.Util;

/// <summary>
/// The Objects namespace.
/// </summary>
namespace AppDynamics.Community.AppDRestApi.Net.Objects
{
    /// <summary>
    /// Class ControllerBaseUrl.
    /// </summary>
    public class ControllerBaseUrl
    {
        /// <summary>
        /// Gets or sets the controller.
        /// </summary>
        /// <value>The controller.</value>
        private string Controller { get; set; }
        /// <summary>
        /// Gets or sets the controller port.
        /// </summary>
        /// <value>The controller port.</value>
        private string ControllerPort { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [use SSL].
        /// </summary>
        /// <value><c>true</c> if [use SSL]; otherwise, <c>false</c>.</value>
        private bool UseSsl { get; set; }

        /// <summary>
        /// Gets the controller URL to string.
        /// </summary>
        /// <value>The controller URL to string.</value>
        public virtual string ControllerUrlToString
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(UseSsl ? Dictionary.Https : Dictionary.Http);
                builder.Append(Controller);
                
                Validation val = new Validation();
                string port = val.ValidatePort(ControllerPort);
                
                if (!String.IsNullOrEmpty(port))
                {
                    builder.Append(Dictionary.Colon).Append(ControllerPort);
                }
                return builder.ToString();
            }
        }

        /*
         * @param controller The controller
         * @param ControllerPort The controller ControllerPort
         *
         */

        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerBaseUrl"/> class.
        /// </summary>
        /// <param name="controller">The controller.</param>
        /// <param name="controllerPort">The controller port.</param>
        public ControllerBaseUrl(string controller, string controllerPort)
        {
            Controller = controller;
            ControllerPort = controllerPort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerBaseUrl"/> class.
        /// </summary>
        /// <param name="controller">The controller.</param>
        public ControllerBaseUrl(string controller)
        {
            Controller = controller;
        }

        /*
         * @param controller The controller
         * @param ControllerPort The controller ControllerPort
         * @param useSSL Use SSL in the query
         *
         */

        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerBaseUrl"/> class.
        /// </summary>
        /// <param name="controller">The controller.</param>
        /// <param name="controllerPort">The controller port.</param>
        /// <param name="useSsl">if set to <c>true</c> [use SSL].</param>
        public ControllerBaseUrl(string controller, string controllerPort, bool useSsl)
        {
            Controller = controller;
            ControllerPort = controllerPort;
            UseSsl = useSsl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerBaseUrl"/> class.
        /// </summary>
        /// <param name="controller">The controller.</param>
        /// <param name="useSsl">if set to <c>true</c> [use SSL].</param>
        public ControllerBaseUrl(string controller, bool useSsl)
        {
            Controller = controller;
            UseSsl = useSsl;
        }
    }
}
