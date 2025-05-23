// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// A copy activity Amazon RDS for SQL Server source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AmazonRdsForSqlServerSource")]
    public partial class AmazonRdsForSqlServerSource : TabularSource
    {
        /// <summary>
        /// Initializes a new instance of the AmazonRdsForSqlServerSource class.
        /// </summary>
        public AmazonRdsForSqlServerSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AmazonRdsForSqlServerSource class.
        /// </summary>

        /// <param name="additionalProperties">A copy activity source.
        /// </param>

        /// <param name="sourceRetryCount">Source retry count. Type: integer (or Expression with resultType integer).
        /// </param>

        /// <param name="sourceRetryWait">Source retry wait. Type: string (or Expression with resultType string),
        /// pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </param>

        /// <param name="maxConcurrentConnections">The maximum concurrent connection count for the source data store. Type:
        /// integer (or Expression with resultType integer).
        /// </param>

        /// <param name="disableMetricsCollection">If true, disable data store metrics collection. Default is false. Type:
        /// boolean (or Expression with resultType boolean).
        /// </param>

        /// <param name="queryTimeout">Query timeout. Type: string (or Expression with resultType string),
        /// pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </param>

        /// <param name="additionalColumns">Specifies the additional columns to be added to source data. Type: array of
        /// objects(AdditionalColumns) (or Expression with resultType array of
        /// objects).
        /// </param>

        /// <param name="sqlReaderQuery">SQL reader query. Type: string (or Expression with resultType string).
        /// </param>

        /// <param name="sqlReaderStoredProcedureName">Name of the stored procedure for a SQL Database source. This cannot be used
        /// at the same time as SqlReaderQuery. Type: string (or Expression with
        /// resultType string).
        /// </param>

        /// <param name="storedProcedureParameters">Value and type setting for stored procedure parameters. Example:
        /// &#34;{Parameter1: {value: &#34;1&#34;, type: &#34;int&#34;}}&#34;.
        /// </param>

        /// <param name="isolationLevel">Specifies the transaction locking behavior for the SQL source. Allowed
        /// values: ReadCommitted/ReadUncommitted/RepeatableRead/Serializable/Snapshot.
        /// The default value is ReadCommitted. Type: string (or Expression with
        /// resultType string).
        /// </param>

        /// <param name="produceAdditionalTypes">Which additional types to produce.
        /// </param>

        /// <param name="partitionOption">The partition mechanism that will be used for Sql read in parallel.
        /// Possible values include: &#34;None&#34;, &#34;PhysicalPartitionsOfTable&#34;,
        /// &#34;DynamicRange&#34;.
        /// </param>

        /// <param name="partitionSettings">The settings that will be leveraged for Sql source partitioning.
        /// </param>
        public AmazonRdsForSqlServerSource(System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object disableMetricsCollection = default(object), object queryTimeout = default(object), object additionalColumns = default(object), object sqlReaderQuery = default(object), object sqlReaderStoredProcedureName = default(object), object storedProcedureParameters = default(object), object isolationLevel = default(object), object produceAdditionalTypes = default(object), object partitionOption = default(object), SqlPartitionSettings partitionSettings = default(SqlPartitionSettings))

        : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, queryTimeout, additionalColumns)
        {
            this.SqlReaderQuery = sqlReaderQuery;
            this.SqlReaderStoredProcedureName = sqlReaderStoredProcedureName;
            this.StoredProcedureParameters = storedProcedureParameters;
            this.IsolationLevel = isolationLevel;
            this.ProduceAdditionalTypes = produceAdditionalTypes;
            this.PartitionOption = partitionOption;
            this.PartitionSettings = partitionSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets sQL reader query. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sqlReaderQuery")]
        public object SqlReaderQuery {get; set; }

        /// <summary>
        /// Gets or sets name of the stored procedure for a SQL Database source. This
        /// cannot be used at the same time as SqlReaderQuery. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sqlReaderStoredProcedureName")]
        public object SqlReaderStoredProcedureName {get; set; }

        /// <summary>
        /// Gets or sets value and type setting for stored procedure parameters.
        /// Example: &#34;{Parameter1: {value: &#34;1&#34;, type: &#34;int&#34;}}&#34;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storedProcedureParameters")]
        public object StoredProcedureParameters {get; set; }

        /// <summary>
        /// Gets or sets specifies the transaction locking behavior for the SQL source.
        /// Allowed values:
        /// ReadCommitted/ReadUncommitted/RepeatableRead/Serializable/Snapshot. The
        /// default value is ReadCommitted. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isolationLevel")]
        public object IsolationLevel {get; set; }

        /// <summary>
        /// Gets or sets which additional types to produce.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "produceAdditionalTypes")]
        public object ProduceAdditionalTypes {get; set; }

        /// <summary>
        /// Gets or sets the partition mechanism that will be used for Sql read in
        /// parallel. Possible values include: &#34;None&#34;, &#34;PhysicalPartitionsOfTable&#34;,
        /// &#34;DynamicRange&#34;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "partitionOption")]
        public object PartitionOption {get; set; }

        /// <summary>
        /// Gets or sets the settings that will be leveraged for Sql source
        /// partitioning.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "partitionSettings")]
        public SqlPartitionSettings PartitionSettings {get; set; }
    }
}