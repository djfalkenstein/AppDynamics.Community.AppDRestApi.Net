/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Objects;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    ///
    /// <node>
    ///  <id>11088</id>
    ///  <name>cf_8f756145-6d81-4217-bba3-93d7af5d7372</name>
    ///  <type>Tomcat 6.x</type>
    ///  <BtTierId>200</BtTierId>
    ///  <BtTierName>start</BtTierName>
    ///  <machineId>91</machineId>
    ///  <machineName>41308e8a-517c-4ca9-adc2-b2003ea03a5d</machineName>
    ///  <machineOSType>Linux</machineOSType>
    ///  <machineAgentPresent>true</machineAgentPresent>
    ///  <machineAgentVersion>Machine Agent v3.7.11.0 GA Build Date 2013-09-27 11:07:47</machineAgentVersion>
    ///  <appAgentPresent>true</appAgentPresent>
    ///  <appAgentVersion>Server Agent v3.7.11.0 GA #2013-09-27_11-05-45 re280bc92c2f193d92459c97836bba1297e1057cb 7</appAgentVersion>
    ///  <ipAddresses>
    ///    <ipAddress>fe80:0:0:0:250:56ff:feab:55c3%2</ipAddress>
    ///    <ipAddress>10.33.151.72</ipAddress>
    ///  </ipAddresses>
    /// </node>
    ///
    /// </summary>

    public class Node
    {
        public int NodeId { get; set; }
        public string NodeName { get; set; }
        public string NodeType { get; set; }
        public int TierId { get; set; }
        public string TierName { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string MachineOsType { get; set; }
        public bool MachineAgentPresent { get; set; }
        public string MachineAgentVersion { get; set; }
        public bool AppAgentPresent { get; set; }
        public string AppAgentVersion { get; set; }
        public IpAddresses IpAddresses { get; set; }

        public Node(int nodeid, string nodeName, string nodeType, int tierid,
                    string tiername, int machineid, string machinename,
                    string machineOsType, bool magentpresent, string magentVersion,
                    bool appAgentPresent, string appAgentVersion, IpAddresses ipAddress)
        {
            NodeId = nodeid;
            NodeName = nodeName;
            NodeType = nodeType;
            TierId = tierid;
            TierName = tiername;
            MachineId = machineid;
            MachineName = machinename;
            MachineOsType = machineOsType;
            MachineAgentPresent = magentpresent;
            MachineAgentVersion = magentVersion;
            AppAgentPresent = appAgentPresent;
            AppAgentVersion = appAgentVersion;
            IpAddresses = ipAddress;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\tNode Name : ").Append(NodeName).Append("\n");
            builder.Append("\tNode ID : ").Append(NodeId).Append("\n");
            builder.Append("\tNode Type: ").Append(NodeType).Append("\n");
            builder.Append("\tTier Name: ").Append(TierName).Append("\n");
            builder.Append("\tTier ID: ").Append(TierId).Append("\n");
            builder.Append("\tMachine ID: ").Append(MachineId).Append("\n");
            builder.Append("\tMachine Name: ").Append(MachineName).Append("\n");
            builder.Append("\tMachine Agent Present: ").Append(MachineAgentPresent).Append("\n");
            builder.Append("\tMachine Agent Version: ").Append(MachineAgentVersion).Append("\n");
            builder.Append("\tApplication Agent Present: ").Append(AppAgentPresent).Append("\n");
            builder.Append("\tApplication Agent Version: ").Append(AppAgentVersion).Append("\n");
            //builder.append(ipAddresses.toString());
            builder.Append("\t ******************** End Node ***************************\n");
            return builder.ToString();
        }
    }
}