// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support
{

    /// <summary>Replica failover mode in availability group.</summary>
    public partial struct Failover :
        System.IEquatable<Failover>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Failover Automatic = @"AUTOMATIC";

        public static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Failover Manual = @"MANUAL";

        /// <summary>the value for an instance of the <see cref="Failover" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to Failover</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Failover" />.</param>
        internal static object CreateFrom(object value)
        {
            return new Failover(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type Failover</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Failover e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type Failover (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is Failover && Equals((Failover)obj);
        }

        /// <summary>Creates an instance of the <see cref="Failover"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private Failover(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum Failover</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for Failover</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to Failover</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Failover" />.</param>

        public static implicit operator Failover(string value)
        {
            return new Failover(value);
        }

        /// <summary>Implicit operator to convert Failover to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="Failover" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Failover e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum Failover</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Failover e1, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Failover e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum Failover</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Failover e1, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Failover e2)
        {
            return e2.Equals(e1);
        }
    }
}