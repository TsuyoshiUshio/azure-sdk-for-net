// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The SkuCapability. </summary>
    public partial class SkuCapability
    {
        /// <summary> Initializes a new instance of SkuCapability. </summary>
        internal SkuCapability()
        {
        }

        /// <summary> Initializes a new instance of SkuCapability. </summary>
        /// <param name="name"> An invariant to describe the feature. </param>
        /// <param name="value"> An invariant if the feature is measured by quantity. </param>
        internal SkuCapability(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> An invariant to describe the feature. </summary>
        public string Name { get; }
        /// <summary> An invariant if the feature is measured by quantity. </summary>
        public string Value { get; }
    }
}
