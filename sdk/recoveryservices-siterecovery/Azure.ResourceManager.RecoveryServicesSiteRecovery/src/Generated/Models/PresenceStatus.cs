// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A value indicating whether the VM has a physical disk attached. String value of SrsDataContract.PresenceStatus enum. </summary>
    public readonly partial struct PresenceStatus : IEquatable<PresenceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PresenceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PresenceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string PresentValue = "Present";
        private const string NotPresentValue = "NotPresent";

        /// <summary> Unknown. </summary>
        public static PresenceStatus Unknown { get; } = new PresenceStatus(UnknownValue);
        /// <summary> Present. </summary>
        public static PresenceStatus Present { get; } = new PresenceStatus(PresentValue);
        /// <summary> NotPresent. </summary>
        public static PresenceStatus NotPresent { get; } = new PresenceStatus(NotPresentValue);
        /// <summary> Determines if two <see cref="PresenceStatus"/> values are the same. </summary>
        public static bool operator ==(PresenceStatus left, PresenceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PresenceStatus"/> values are not the same. </summary>
        public static bool operator !=(PresenceStatus left, PresenceStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PresenceStatus"/>. </summary>
        public static implicit operator PresenceStatus(string value) => new PresenceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PresenceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PresenceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
