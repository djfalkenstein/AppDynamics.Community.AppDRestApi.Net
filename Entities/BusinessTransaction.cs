/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    ///
    /// <business-transaction>
    ///  <BtId>6210</BtId>
    ///  <BtName>_AppDynamics.Community.AppDRestApi_DEFAULT_TX_</BtName>
    ///  <BtEntryPointType>POJO</BtEntryPointType>
    ///  <BtInternalName>_AppDynamics.Community.AppDRestApi_DEFAULT_TX_</BtInternalName>
    ///  <BtTierId>578</BtTierId>
    ///  <BtTierName>my-family-booklet-dev</BtTierName>
    ///  <BtBackground>false</BtBackground>
    /// </business-transaction>
    ///
    /// </summary>
    public class BusinessTransaction
    {
        public bool BtBackground { get; internal set; }
        public string BtEntryPointType { get; internal set; }
        public int BtId { get; internal set; }
        public string BtInternalName { get; internal set; }
        public string BtName { get; internal set; }
        public int BtTierId { get; internal set; }
        public string BtTierName { get; internal set; }

        public BusinessTransaction(bool background, string epType, int btId, string intname, string name, int tierId, string tierName)
        {
            BtBackground = background;
            BtEntryPointType = epType;
            BtId = btId;
            BtInternalName = intname;
            BtName = name;
            BtTierId = tierId;
            BtTierName = tierName;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(@"Id = ").Append(BtId);
            builder.Append(@", ");
            builder.Append(@"Name = ").Append(BtName);
            builder.Append(@", ");
            builder.Append(@"InternalName = ").Append(BtInternalName);
            builder.Append(@", ");
            builder.Append(@"EntryPointType = ").Append(BtEntryPointType);
            builder.Append(@", ");
            builder.Append(@"TierName = ").Append(BtTierName);
            builder.Append(@", ");
            builder.Append(@"Background = ").Append(BtBackground).Append("\n");
            return builder.ToString();
        }
    }
}