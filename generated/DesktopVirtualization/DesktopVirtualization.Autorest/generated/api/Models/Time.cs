// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>The time for a scaling action to occur.</summary>
    public partial class Time :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.ITime,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.ITimeInternal
    {

        /// <summary>Backing field for <see cref="Hour" /> property.</summary>
        private int _hour;

        /// <summary>The hour.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public int Hour { get => this._hour; set => this._hour = value; }

        /// <summary>Backing field for <see cref="Minute" /> property.</summary>
        private int _minute;

        /// <summary>The minute.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public int Minute { get => this._minute; set => this._minute = value; }

        /// <summary>Creates an new <see cref="Time" /> instance.</summary>
        public Time()
        {

        }
    }
    /// The time for a scaling action to occur.
    public partial interface ITime :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable
    {
        /// <summary>The hour.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The hour.",
        SerializedName = @"hour",
        PossibleTypes = new [] { typeof(int) })]
        int Hour { get; set; }
        /// <summary>The minute.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The minute.",
        SerializedName = @"minute",
        PossibleTypes = new [] { typeof(int) })]
        int Minute { get; set; }

    }
    /// The time for a scaling action to occur.
    internal partial interface ITimeInternal

    {
        /// <summary>The hour.</summary>
        int Hour { get; set; }
        /// <summary>The minute.</summary>
        int Minute { get; set; }

    }
}