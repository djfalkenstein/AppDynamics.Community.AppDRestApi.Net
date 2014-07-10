/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Objects
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>

    public class IpAddresses
    {
        private List<IPAddress> _ipaddresses = new List<IPAddress>();

        public virtual List<IPAddress> Ipaddresses
        {
            get
            {
                return _ipaddresses;
            }
            set
            {
                _ipaddresses = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\tIPAddresses : \n");
            foreach (IPAddress ip in _ipaddresses)
            {
                builder.Append(ip);
            }
            return builder.ToString();
        }
    }
}