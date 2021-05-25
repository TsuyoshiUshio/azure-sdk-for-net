// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Describes how media is transferred to the extension plugin. </summary>
    public partial class GrpcExtensionDataTransfer
    {
        /// <summary> Initializes a new instance of GrpcExtensionDataTransfer. </summary>
        /// <param name="mode"> Data transfer mode: embedded or sharedMemory. </param>
        public GrpcExtensionDataTransfer(GrpcExtensionDataTransferMode mode)
        {
            Mode = mode;
        }

        /// <summary> Initializes a new instance of GrpcExtensionDataTransfer. </summary>
        /// <param name="sharedMemorySizeMiB"> The share memory buffer for sample transfers, in mebibytes. It can only be used with the &apos;SharedMemory&apos; transfer mode. </param>
        /// <param name="mode"> Data transfer mode: embedded or sharedMemory. </param>
        internal GrpcExtensionDataTransfer(string sharedMemorySizeMiB, GrpcExtensionDataTransferMode mode)
        {
            SharedMemorySizeMiB = sharedMemorySizeMiB;
            Mode = mode;
        }

        /// <summary> The share memory buffer for sample transfers, in mebibytes. It can only be used with the &apos;SharedMemory&apos; transfer mode. </summary>
        public string SharedMemorySizeMiB { get; set; }
        /// <summary> Data transfer mode: embedded or sharedMemory. </summary>
        public GrpcExtensionDataTransferMode Mode { get; set; }
    }
}
