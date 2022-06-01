// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> settings for compression. </summary>
    public partial class RouteCacheCompressionSettings
    {
        /// <summary> Initializes a new instance of RouteCacheCompressionSettings. </summary>
        public RouteCacheCompressionSettings()
        {
            ContentTypesToCompress = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RouteCacheCompressionSettings. </summary>
        /// <param name="contentTypesToCompress"> List of content types on which compression applies. The value should be a valid MIME type. </param>
        /// <param name="isCompressionEnabled"> Indicates whether content compression is enabled on AzureFrontDoor. Default value is false. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won&apos;t be compressed on AzureFrontDoor when requested content is smaller than 1 byte or larger than 1 MB. </param>
        internal RouteCacheCompressionSettings(IList<string> contentTypesToCompress, bool? isCompressionEnabled)
        {
            ContentTypesToCompress = contentTypesToCompress;
            IsCompressionEnabled = isCompressionEnabled;
        }

        /// <summary> List of content types on which compression applies. The value should be a valid MIME type. </summary>
        public IList<string> ContentTypesToCompress { get; }
        /// <summary> Indicates whether content compression is enabled on AzureFrontDoor. Default value is false. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won&apos;t be compressed on AzureFrontDoor when requested content is smaller than 1 byte or larger than 1 MB. </summary>
        public bool? IsCompressionEnabled { get; set; }
    }
}
