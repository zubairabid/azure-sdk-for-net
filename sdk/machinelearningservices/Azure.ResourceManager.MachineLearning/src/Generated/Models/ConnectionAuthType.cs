// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Authentication type of the connection target. </summary>
    internal readonly partial struct ConnectionAuthType : IEquatable<ConnectionAuthType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectionAuthType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectionAuthType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PATValue = "PAT";
        private const string ManagedIdentityValue = "ManagedIdentity";
        private const string UsernamePasswordValue = "UsernamePassword";
        private const string NoneValue = "None";
        private const string SASValue = "SAS";

        /// <summary> PAT. </summary>
        public static ConnectionAuthType PAT { get; } = new ConnectionAuthType(PATValue);
        /// <summary> ManagedIdentity. </summary>
        public static ConnectionAuthType ManagedIdentity { get; } = new ConnectionAuthType(ManagedIdentityValue);
        /// <summary> UsernamePassword. </summary>
        public static ConnectionAuthType UsernamePassword { get; } = new ConnectionAuthType(UsernamePasswordValue);
        /// <summary> None. </summary>
        public static ConnectionAuthType None { get; } = new ConnectionAuthType(NoneValue);
        /// <summary> SAS. </summary>
        public static ConnectionAuthType SAS { get; } = new ConnectionAuthType(SASValue);
        /// <summary> Determines if two <see cref="ConnectionAuthType"/> values are the same. </summary>
        public static bool operator ==(ConnectionAuthType left, ConnectionAuthType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectionAuthType"/> values are not the same. </summary>
        public static bool operator !=(ConnectionAuthType left, ConnectionAuthType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConnectionAuthType"/>. </summary>
        public static implicit operator ConnectionAuthType(string value) => new ConnectionAuthType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectionAuthType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectionAuthType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
