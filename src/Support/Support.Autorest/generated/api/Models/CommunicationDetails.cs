// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Support.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Extensions;

    /// <summary>Object that represents a Communication resource.</summary>
    public partial class CommunicationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsInternal
    {

        /// <summary>Body of the communication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Support.DoNotFormat]
        public string Body { get => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).Body; set => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).Body = value ; }

        /// <summary>Direction of communication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Support.DoNotFormat]
        public string CommunicationDirection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).CommunicationDirection; }

        /// <summary>Communication type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Support.DoNotFormat]
        public string CommunicationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).CommunicationType; }

        /// <summary>Time in UTC (ISO 8601 format) when the communication was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Support.FormatTable(Index = 3)]
        public global::System.DateTime? CreatedDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).CreatedDate; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Support.DoNotFormat]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for CommunicationDirection</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsInternal.CommunicationDirection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).CommunicationDirection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).CommunicationDirection = value; }

        /// <summary>Internal Acessors for CommunicationType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsInternal.CommunicationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).CommunicationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).CommunicationType = value; }

        /// <summary>Internal Acessors for CreatedDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsInternal.CreatedDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).CreatedDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).CreatedDate = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsProperties Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Support.Models.CommunicationDetailsProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Support.FormatTable(Index = 0)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsProperties _property;

        /// <summary>Properties of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Support.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Support.Models.CommunicationDetailsProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Support.DoNotFormat]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Email address of the sender. This property is required if called by a service principal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Support.FormatTable(Index = 1)]
        public string Sender { get => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).Sender; set => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).Sender = value ?? null; }

        /// <summary>Subject of the communication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Support.FormatTable(Index = 2)]
        public string Subject { get => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).Subject; set => ((Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsPropertiesInternal)Property).Subject = value ; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of the resource 'Microsoft.Support/communications'.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Support.DoNotFormat]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="CommunicationDetails" /> instance.</summary>
        public CommunicationDetails()
        {

        }
    }
    /// Object that represents a Communication resource.
    public partial interface ICommunicationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.IJsonSerializable
    {
        /// <summary>Body of the communication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Body of the communication.",
        SerializedName = @"body",
        PossibleTypes = new [] { typeof(string) })]
        string Body { get; set; }
        /// <summary>Direction of communication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Direction of communication.",
        SerializedName = @"communicationDirection",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Support.PSArgumentCompleterAttribute("inbound", "outbound")]
        string CommunicationDirection { get;  }
        /// <summary>Communication type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Communication type.",
        SerializedName = @"communicationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Support.PSArgumentCompleterAttribute("web", "phone")]
        string CommunicationType { get;  }
        /// <summary>Time in UTC (ISO 8601 format) when the communication was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Time in UTC (ISO 8601 format) when the communication was created.",
        SerializedName = @"createdDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedDate { get;  }
        /// <summary>Id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Id of the resource.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the resource.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>
        /// Email address of the sender. This property is required if called by a service principal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Email address of the sender. This property is required if called by a service principal.",
        SerializedName = @"sender",
        PossibleTypes = new [] { typeof(string) })]
        string Sender { get; set; }
        /// <summary>Subject of the communication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Subject of the communication.",
        SerializedName = @"subject",
        PossibleTypes = new [] { typeof(string) })]
        string Subject { get; set; }
        /// <summary>Type of the resource 'Microsoft.Support/communications'.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Type of the resource 'Microsoft.Support/communications'.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Object that represents a Communication resource.
    internal partial interface ICommunicationDetailsInternal

    {
        /// <summary>Body of the communication.</summary>
        string Body { get; set; }
        /// <summary>Direction of communication.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Support.PSArgumentCompleterAttribute("inbound", "outbound")]
        string CommunicationDirection { get; set; }
        /// <summary>Communication type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Support.PSArgumentCompleterAttribute("web", "phone")]
        string CommunicationType { get; set; }
        /// <summary>Time in UTC (ISO 8601 format) when the communication was created.</summary>
        global::System.DateTime? CreatedDate { get; set; }
        /// <summary>Id of the resource.</summary>
        string Id { get; set; }
        /// <summary>Name of the resource.</summary>
        string Name { get; set; }
        /// <summary>Properties of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ICommunicationDetailsProperties Property { get; set; }
        /// <summary>
        /// Email address of the sender. This property is required if called by a service principal.
        /// </summary>
        string Sender { get; set; }
        /// <summary>Subject of the communication.</summary>
        string Subject { get; set; }
        /// <summary>Type of the resource 'Microsoft.Support/communications'.</summary>
        string Type { get; set; }

    }
}