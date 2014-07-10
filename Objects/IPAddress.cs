/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Objects
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    ///
    /// <ipAddresses>
    ///    <ipAddress>fe80:0:0:0:250:56ff:feab:55c3%2</ipAddress>
    ///    <ipAddress>10.33.151.72</ipAddress>
    ///  </ipAddresses>
    ///
    /// </summary>
    public class IPAddresses
    {
        public string IpAddress { get; set; }

        public IPAddresses(string ipaddress)
        {
            IpAddress = ipaddress;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\t\tIPAddress: ").Append(IpAddress).Append("\n");

            return builder.ToString();
        }
    }
}