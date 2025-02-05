// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> The operation mode for Intrusion system mode. </summary>
    public readonly partial struct FirewallPolicyIntrusionSystemMode : IEquatable<FirewallPolicyIntrusionSystemMode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="FirewallPolicyIntrusionSystemMode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FirewallPolicyIntrusionSystemMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static FirewallPolicyIntrusionSystemMode Enabled { get; } = new FirewallPolicyIntrusionSystemMode(EnabledValue);
        /// <summary> Disabled. </summary>
        public static FirewallPolicyIntrusionSystemMode Disabled { get; } = new FirewallPolicyIntrusionSystemMode(DisabledValue);
        /// <summary> Determines if two <see cref="FirewallPolicyIntrusionSystemMode"/> values are the same. </summary>
        public static bool operator ==(FirewallPolicyIntrusionSystemMode left, FirewallPolicyIntrusionSystemMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FirewallPolicyIntrusionSystemMode"/> values are not the same. </summary>
        public static bool operator !=(FirewallPolicyIntrusionSystemMode left, FirewallPolicyIntrusionSystemMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FirewallPolicyIntrusionSystemMode"/>. </summary>
        public static implicit operator FirewallPolicyIntrusionSystemMode(string value) => new FirewallPolicyIntrusionSystemMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FirewallPolicyIntrusionSystemMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FirewallPolicyIntrusionSystemMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
