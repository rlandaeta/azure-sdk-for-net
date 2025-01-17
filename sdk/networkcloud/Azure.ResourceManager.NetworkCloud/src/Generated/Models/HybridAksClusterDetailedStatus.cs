// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The more detailed status of this Hybrid AKS cluster. </summary>
    public readonly partial struct HybridAksClusterDetailedStatus : IEquatable<HybridAksClusterDetailedStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HybridAksClusterDetailedStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HybridAksClusterDetailedStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string AvailableValue = "Available";
        private const string ProvisioningValue = "Provisioning";

        /// <summary> Error. </summary>
        public static HybridAksClusterDetailedStatus Error { get; } = new HybridAksClusterDetailedStatus(ErrorValue);
        /// <summary> Available. </summary>
        public static HybridAksClusterDetailedStatus Available { get; } = new HybridAksClusterDetailedStatus(AvailableValue);
        /// <summary> Provisioning. </summary>
        public static HybridAksClusterDetailedStatus Provisioning { get; } = new HybridAksClusterDetailedStatus(ProvisioningValue);
        /// <summary> Determines if two <see cref="HybridAksClusterDetailedStatus"/> values are the same. </summary>
        public static bool operator ==(HybridAksClusterDetailedStatus left, HybridAksClusterDetailedStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HybridAksClusterDetailedStatus"/> values are not the same. </summary>
        public static bool operator !=(HybridAksClusterDetailedStatus left, HybridAksClusterDetailedStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HybridAksClusterDetailedStatus"/>. </summary>
        public static implicit operator HybridAksClusterDetailedStatus(string value) => new HybridAksClusterDetailedStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HybridAksClusterDetailedStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HybridAksClusterDetailedStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
