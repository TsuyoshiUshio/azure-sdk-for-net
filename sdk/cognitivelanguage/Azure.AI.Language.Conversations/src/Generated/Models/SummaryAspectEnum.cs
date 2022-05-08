// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations
{
    /// <summary> The SummaryAspectEnum. </summary>
    public readonly partial struct SummaryAspectEnum : IEquatable<SummaryAspectEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SummaryAspectEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SummaryAspectEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IssueValue = "Issue";
        private const string ResolutionValue = "Resolution";
        private const string IssueResolutionValue = "Issue, Resolution";

        /// <summary> Issue. </summary>
        public static SummaryAspectEnum Issue { get; } = new SummaryAspectEnum(IssueValue);
        /// <summary> Resolution. </summary>
        public static SummaryAspectEnum Resolution { get; } = new SummaryAspectEnum(ResolutionValue);
        /// <summary> Issue, Resolution. </summary>
        public static SummaryAspectEnum IssueResolution { get; } = new SummaryAspectEnum(IssueResolutionValue);
        /// <summary> Determines if two <see cref="SummaryAspectEnum"/> values are the same. </summary>
        public static bool operator ==(SummaryAspectEnum left, SummaryAspectEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SummaryAspectEnum"/> values are not the same. </summary>
        public static bool operator !=(SummaryAspectEnum left, SummaryAspectEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SummaryAspectEnum"/>. </summary>
        public static implicit operator SummaryAspectEnum(string value) => new SummaryAspectEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SummaryAspectEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SummaryAspectEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
