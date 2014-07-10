/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Collections.Generic;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    /// <summary>
    ///     @author david.falkenstein@AppDynamics.com
    ///     <node>
    ///         <id>9</id>
    ///         <name>2ndTierNode2</name>
    ///         <type>Other</type>
    ///         <BtTierId>6</BtTierId>
    ///         <BtTierName>2ndTier</BtTierName>
    ///         <machineId>2</machineId>
    ///         <machineName>appdyn01.david.falkenstein@AppDynamics.comto.com</machineName>
    ///         <machineOSType>Linux</machineOSType>
    ///         <machineAgentPresent>false</machineAgentPresent>
    ///         <appAgentPresent>true</appAgentPresent>
    ///         <appAgentVersion>Server Agent v3.7.7.1 GA #2013-07-31_11-46-46 r2d61b3d9cb526ed366749d47cd2f84f944232929 2</appAgentVersion>
    ///         <ipAddresses>
    ///             <ipAddress>fe80:0:0:0:a00:27ff:fe01:fc51%3</ipAddress>
    ///             <ipAddress>192.168.56.113</ipAddress>
    ///             <ipAddress>fe80:0:0:0:a00:27ff:fe09:e259%2</ipAddress>
    ///             <ipAddress>192.168.10.103</ipAddress>
    ///         </ipAddresses>
    ///     </node>
    /// </summary>
    public class AppNode
    {
        private List<string> _ipaddresses = new List<string>();

        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Type { get; set; }

        public virtual int TierId { get; set; }

        public virtual string TierName { get; set; }

        public virtual int MachineId { get; set; }

        public virtual string MachineName { get; set; }

        public virtual string MachineOsType { get; set; }

        public virtual bool MachineAgentPresent { get; set; }

        public virtual bool AppAgentPresent { get; set; }

        public virtual string AppAgentVersion { get; set; }

        public virtual List<string> Ipaddresses
        {
            get { return _ipaddresses; }
            set { _ipaddresses = value; }
        }
    }
}