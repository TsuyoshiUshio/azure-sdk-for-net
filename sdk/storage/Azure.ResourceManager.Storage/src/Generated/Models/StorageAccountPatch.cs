// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The parameters that can be provided when updating the storage account properties. </summary>
    public partial class StorageAccountPatch
    {
        /// <summary> Initializes a new instance of StorageAccountPatch. </summary>
        public StorageAccountPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets the SKU name. Note that the SKU name cannot be updated to Standard_ZRS, Premium_LRS or Premium_ZRS, nor can accounts of those SKU names be updated to any other value. </summary>
        public StorageSku Sku { get; set; }
        /// <summary> Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater in length than 128 characters and a value no greater in length than 256 characters. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Optional. Indicates the type of storage account. Currently only StorageV2 value supported by server. </summary>
        public StorageKind? Kind { get; set; }
        /// <summary> Custom domain assigned to the storage account by the user. Name is the CNAME source. Only one custom domain is supported per storage account at this time. To clear the existing custom domain, use an empty string for the custom domain name property. </summary>
        public CustomDomain CustomDomain { get; set; }
        /// <summary> Not applicable. Azure Storage encryption at rest is enabled by default for all storage accounts and cannot be disabled. </summary>
        public Encryption Encryption { get; set; }
        /// <summary> SasPolicy assigned to the storage account. </summary>
        public SasPolicy SasPolicy { get; set; }
        /// <summary> KeyPolicy assigned to the storage account. </summary>
        internal KeyPolicy KeyPolicy { get; set; }
        /// <summary> The key expiration period in days. </summary>
        public int? KeyExpirationPeriodInDays
        {
            get => KeyPolicy is null ? default(int?) : KeyPolicy.KeyExpirationPeriodInDays;
            set
            {
                KeyPolicy = value.HasValue ? new KeyPolicy(value.Value) : null;
            }
        }

        /// <summary> Required for storage accounts where kind = BlobStorage. The access tier used for billing. </summary>
        public AccessTier? AccessTier { get; set; }
        /// <summary> Provides the identity based authentication settings for Azure Files. </summary>
        public AzureFilesIdentityBasedAuthentication AzureFilesIdentityBasedAuthentication { get; set; }
        /// <summary> Allows https traffic only to storage service if sets to true. </summary>
        public bool? EnableHttpsTrafficOnly { get; set; }
        /// <summary> Enables Secure File Transfer Protocol, if set to true. </summary>
        public bool? IsSftpEnabled { get; set; }
        /// <summary> Enables local users feature, if set to true. </summary>
        public bool? IsLocalUserEnabled { get; set; }
        /// <summary> Network rule set. </summary>
        public NetworkRuleSet NetworkRuleSet { get; set; }
        /// <summary> Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled. </summary>
        public LargeFileSharesState? LargeFileSharesState { get; set; }
        /// <summary> Maintains information about the network routing choice opted by the user for data transfer. </summary>
        public RoutingPreference RoutingPreference { get; set; }
        /// <summary> Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property. </summary>
        public bool? AllowBlobPublicAccess { get; set; }
        /// <summary> Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property. </summary>
        public MinimumTlsVersion? MinimumTlsVersion { get; set; }
        /// <summary> Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). The default value is null, which is equivalent to true. </summary>
        public bool? AllowSharedKeyAccess { get; set; }
        /// <summary> Allow or disallow cross AAD tenant object replication. The default interpretation is true for this property. </summary>
        public bool? AllowCrossTenantReplication { get; set; }
        /// <summary> A boolean flag which indicates whether the default authentication is OAuth or not. The default interpretation is false for this property. </summary>
        public bool? DefaultToOAuthAuthentication { get; set; }
        /// <summary> Allow or disallow public network access to Storage Account. Value is optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The property is immutable and can only be set to true at the account creation time. When set to true, it enables object level immutability for all the containers in the account by default. </summary>
        public ImmutableStorageAccount ImmutableStorageWithVersioning { get; set; }
        /// <summary> Restrict copy to and from Storage Accounts within an AAD tenant or with Private Links to the same VNet. </summary>
        public AllowedCopyScope? AllowedCopyScope { get; set; }
    }
}
