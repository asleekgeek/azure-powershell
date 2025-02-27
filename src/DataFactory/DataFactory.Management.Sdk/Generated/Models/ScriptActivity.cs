// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Script activity type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Script")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ScriptActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the ScriptActivity class.
        /// </summary>
        public ScriptActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScriptActivity class.
        /// </summary>

        /// <param name="additionalProperties">A pipeline activity.
        /// </param>

        /// <param name="name">Activity name.
        /// </param>

        /// <param name="description">Activity description.
        /// </param>

        /// <param name="state">Activity state. This is an optional property and if not provided, the state
        /// will be Active by default.
        /// Possible values include: &#39;Active&#39;, &#39;Inactive&#39;</param>

        /// <param name="onInactiveMarkAs">Status result of the activity when the state is set to Inactive. This is an
        /// optional property and if not provided when the activity is inactive, the
        /// status will be Succeeded by default.
        /// Possible values include: &#39;Succeeded&#39;, &#39;Failed&#39;, &#39;Skipped&#39;</param>

        /// <param name="dependsOn">Activity depends on condition.
        /// </param>

        /// <param name="userProperties">Activity user properties.
        /// </param>

        /// <param name="linkedServiceName">Linked service reference.
        /// </param>

        /// <param name="policy">Activity policy.
        /// </param>

        /// <param name="scriptBlockExecutionTimeout">ScriptBlock execution timeout. Type: string (or Expression with resultType
        /// string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </param>

        /// <param name="scripts">Array of script blocks. Type: array.
        /// </param>

        /// <param name="logSettings">Log settings of script activity.
        /// </param>

        /// <param name="returnMultistatementResult">Enable to retrieve result sets from multiple SQL statements and the number
        /// of rows affected by the DML statement. Supported connector: SnowflakeV2.
        /// Type: boolean (or Expression with resultType boolean).
        /// </param>
        public ScriptActivity(string name, System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), string description = default(string), string state = default(string), string onInactiveMarkAs = default(string), System.Collections.Generic.IList<ActivityDependency> dependsOn = default(System.Collections.Generic.IList<ActivityDependency>), System.Collections.Generic.IList<UserProperty> userProperties = default(System.Collections.Generic.IList<UserProperty>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), object scriptBlockExecutionTimeout = default(object), System.Collections.Generic.IList<ScriptActivityScriptBlock> scripts = default(System.Collections.Generic.IList<ScriptActivityScriptBlock>), ScriptActivityTypePropertiesLogSettings logSettings = default(ScriptActivityTypePropertiesLogSettings), object returnMultistatementResult = default(object))

        : base(name, additionalProperties, description, state, onInactiveMarkAs, dependsOn, userProperties, linkedServiceName, policy)
        {
            this.ScriptBlockExecutionTimeout = scriptBlockExecutionTimeout;
            this.Scripts = scripts;
            this.LogSettings = logSettings;
            this.ReturnMultistatementResult = returnMultistatementResult;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets scriptBlock execution timeout. Type: string (or Expression
        /// with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.scriptBlockExecutionTimeout")]
        public object ScriptBlockExecutionTimeout {get; set; }

        /// <summary>
        /// Gets or sets array of script blocks. Type: array.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.scripts")]
        public System.Collections.Generic.IList<ScriptActivityScriptBlock> Scripts {get; set; }

        /// <summary>
        /// Gets or sets log settings of script activity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.logSettings")]
        public ScriptActivityTypePropertiesLogSettings LogSettings {get; set; }

        /// <summary>
        /// Gets or sets enable to retrieve result sets from multiple SQL statements
        /// and the number of rows affected by the DML statement. Supported connector:
        /// SnowflakeV2. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.returnMultistatementResult")]
        public object ReturnMultistatementResult {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();

            if (this.Scripts != null)
            {
                foreach (var element in this.Scripts)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.LogSettings != null)
            {
                this.LogSettings.Validate();
            }

        }
    }
}