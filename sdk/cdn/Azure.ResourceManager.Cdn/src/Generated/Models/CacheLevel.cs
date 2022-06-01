// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The level at which the content needs to be cached. </summary>
    public readonly partial struct CacheLevel : IEquatable<CacheLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CacheLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CacheLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllValue = "All";

        /// <summary> All. </summary>
        public static CacheLevel All { get; } = new CacheLevel(AllValue);
        /// <summary> Determines if two <see cref="CacheLevel"/> values are the same. </summary>
        public static bool operator ==(CacheLevel left, CacheLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CacheLevel"/> values are not the same. </summary>
        public static bool operator !=(CacheLevel left, CacheLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CacheLevel"/>. </summary>
        public static implicit operator CacheLevel(string value) => new CacheLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CacheLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CacheLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
