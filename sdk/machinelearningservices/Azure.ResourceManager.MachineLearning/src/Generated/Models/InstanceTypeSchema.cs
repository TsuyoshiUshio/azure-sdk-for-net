// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Instance type schema. </summary>
    public partial class InstanceTypeSchema
    {
        /// <summary> Initializes a new instance of InstanceTypeSchema. </summary>
        public InstanceTypeSchema()
        {
            NodeSelector = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of InstanceTypeSchema. </summary>
        /// <param name="nodeSelector"> Node Selector. </param>
        /// <param name="resources"> Resource requests/limits for this instance type. </param>
        internal InstanceTypeSchema(IDictionary<string, string> nodeSelector, InstanceTypeSchemaResources resources)
        {
            NodeSelector = nodeSelector;
            Resources = resources;
        }

        /// <summary> Node Selector. </summary>
        public IDictionary<string, string> NodeSelector { get; }
        /// <summary> Resource requests/limits for this instance type. </summary>
        public InstanceTypeSchemaResources Resources { get; set; }
    }
}
