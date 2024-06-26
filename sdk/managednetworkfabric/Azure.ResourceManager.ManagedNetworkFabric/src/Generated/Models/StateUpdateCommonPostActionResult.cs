// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Common response for the state updates. </summary>
    public partial class StateUpdateCommonPostActionResult : NetworkFabricErrorResult
    {
        /// <summary> Initializes a new instance of <see cref="StateUpdateCommonPostActionResult"/>. </summary>
        internal StateUpdateCommonPostActionResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StateUpdateCommonPostActionResult"/>. </summary>
        /// <param name="error"> The error object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="configurationState"> Gets the configuration state. </param>
        internal StateUpdateCommonPostActionResult(ResponseError error, IDictionary<string, BinaryData> serializedAdditionalRawData, NetworkFabricConfigurationState? configurationState) : base(error, serializedAdditionalRawData)
        {
            ConfigurationState = configurationState;
        }

        /// <summary> Gets the configuration state. </summary>
        public NetworkFabricConfigurationState? ConfigurationState { get; }
    }
}
