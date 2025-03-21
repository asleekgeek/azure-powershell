// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System.Linq;

    /// <summary>
    /// The workflow trigger history properties.
    /// </summary>
    public partial class WorkflowTriggerHistoryProperties
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerHistoryProperties class.
        /// </summary>
        public WorkflowTriggerHistoryProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerHistoryProperties class.
        /// </summary>

        /// <param name="startTime">Gets the start time.
        /// </param>

        /// <param name="endTime">Gets the end time.
        /// </param>

        /// <param name="status">Gets the status.
        /// Possible values include: &#39;NotSpecified&#39;, &#39;Paused&#39;, &#39;Running&#39;, &#39;Waiting&#39;,
        /// &#39;Succeeded&#39;, &#39;Skipped&#39;, &#39;Suspended&#39;, &#39;Cancelled&#39;, &#39;Failed&#39;, &#39;Faulted&#39;,
        /// &#39;TimedOut&#39;, &#39;Aborted&#39;, &#39;Ignored&#39;</param>

        /// <param name="code">Gets the code.
        /// </param>

        /// <param name="error">Gets the error.
        /// </param>

        /// <param name="trackingId">Gets the tracking id.
        /// </param>

        /// <param name="correlation">The run correlation.
        /// </param>

        /// <param name="inputsLink">Gets the link to input parameters.
        /// </param>

        /// <param name="outputsLink">Gets the link to output parameters.
        /// </param>

        /// <param name="fired">Gets a value indicating whether trigger was fired.
        /// </param>

        /// <param name="run">Gets the reference to workflow run.
        /// </param>
        public WorkflowTriggerHistoryProperties(System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string status = default(string), string code = default(string), object error = default(object), string trackingId = default(string), Correlation correlation = default(Correlation), ContentLink inputsLink = default(ContentLink), ContentLink outputsLink = default(ContentLink), bool? fired = default(bool?), ResourceReference run = default(ResourceReference))

        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Status = status;
            this.Code = code;
            this.Error = error;
            this.TrackingId = trackingId;
            this.Correlation = correlation;
            this.InputsLink = inputsLink;
            this.OutputsLink = outputsLink;
            this.Fired = fired;
            this.Run = run;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets gets the start time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime {get; private set; }

        /// <summary>
        /// Gets gets the end time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime {get; private set; }

        /// <summary>
        /// Gets gets the status. Possible values include: &#39;NotSpecified&#39;, &#39;Paused&#39;, &#39;Running&#39;, &#39;Waiting&#39;, &#39;Succeeded&#39;, &#39;Skipped&#39;, &#39;Suspended&#39;, &#39;Cancelled&#39;, &#39;Failed&#39;, &#39;Faulted&#39;, &#39;TimedOut&#39;, &#39;Aborted&#39;, &#39;Ignored&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {get; private set; }

        /// <summary>
        /// Gets gets the code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public string Code {get; private set; }

        /// <summary>
        /// Gets gets the error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "error")]
        public object Error {get; private set; }

        /// <summary>
        /// Gets gets the tracking id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "trackingId")]
        public string TrackingId {get; private set; }

        /// <summary>
        /// Gets or sets the run correlation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "correlation")]
        public Correlation Correlation {get; set; }

        /// <summary>
        /// Gets gets the link to input parameters.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "inputsLink")]
        public ContentLink InputsLink {get; private set; }

        /// <summary>
        /// Gets gets the link to output parameters.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "outputsLink")]
        public ContentLink OutputsLink {get; private set; }

        /// <summary>
        /// Gets gets a value indicating whether trigger was fired.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fired")]
        public bool? Fired {get; private set; }

        /// <summary>
        /// Gets gets the reference to workflow run.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "run")]
        public ResourceReference Run {get; private set; }
    }
}