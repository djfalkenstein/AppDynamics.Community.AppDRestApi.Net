using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    ///
    /// This XML file does not appear to have any style information associated with it. The document tree is shown below.
    /// <backends>
    ///
    ///
    /// <backend>
    /// <id>9</id>
    /// <name>NEWSCHEMA-MYSQL-LOCALHOST</name>
    /// <exitPointType>JDBC</exitPointType>
    /// <properties>
    ///    <name-value>
    ///        <id>0</id>
    ///        <name>HOST</name>
    ///        <value>LOCALHOST</value>
    ///    </name-value>
    ///    <name-value>
    ///        <id>0</id>
    ///        <name>MAJOR_VERSION</name>
    ///        <value>5.6</value>
    ///    </name-value>
    ///    <name-value>
    ///        <id>0</id>
    ///        <name>ControllerPort</name>
    ///        <value>3308</value>
    ///    </name-value>
    ///    <name-value>
    ///    <id>0</id>
    ///    <name>SCHEMA</name>
    ///    <value>NEWSCHEMA</value>
    ///    </name-value>
    ///    <name-value>
    ///    <id>0</id>
    ///    <name>URL</name>
    ///    <value>jdbc:mysql://localhost:3308/newschema</value>
    ///    </name-value>
    ///    <name-value>
    ///    <id>0</id>
    ///    <name>VENDOR</name>
    ///    <value>MYSQL</value>
    ///    </name-value>
    /// </properties>
    /// <applicationComponentNodeId>0</applicationComponentNodeId>
    /// <BtTierId>0</BtTierId>
    /// </backend>
    ///
    /// </backends>
    ///
    /// </summary>

    public class Backend
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExitPointType { get; set; }
        public ApiProperties Properties { get; set; }
        public int ApplicationComponentNodeId { get; set; }
        public int TierId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Backend"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="exitPointType">Type of the exit point.</param>
        /// <param name="properties">The properties.</param>
        /// <param name="appCompNodeId">The application comp node identifier.</param>
        /// <param name="tierId">The tier identifier.</param>
        public Backend(int id, string name, string exitPointType, ApiProperties properties, int appCompNodeId, int tierId )
        {
            Id = id;
            Name = name;
            ExitPointType = exitPointType;
            Properties = properties;
            ApplicationComponentNodeId = appCompNodeId;
            TierId = tierId;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.L1).Append(Dictionary.Backend);
            builder.Append(Dictionary.L2).Append(Dictionary.Id).Append(Dictionary.Ve).Append(Id);
            builder.Append(Dictionary.L2).Append(Dictionary.Name).Append(Dictionary.Ve).Append(Name);
            builder.Append(Dictionary.L2).Append(Dictionary.BcExitPointType).Append(Dictionary.Ve).Append(ExitPointType);
            builder.Append(Properties);
            builder.Append(Dictionary.L2).Append(Dictionary.ApplicationComponentNodeId).Append(Dictionary.Ve).Append(ApplicationComponentNodeId);
            builder.Append(Dictionary.L2).Append(Dictionary.TierId).Append(Dictionary.Ve).Append(TierId);

            return builder.ToString();
        }
    }
}
