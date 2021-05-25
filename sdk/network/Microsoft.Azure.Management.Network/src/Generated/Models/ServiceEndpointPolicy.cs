// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Service End point policy resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServiceEndpointPolicy : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ServiceEndpointPolicy class.
        /// </summary>
        public ServiceEndpointPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceEndpointPolicy class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="serviceEndpointPolicyDefinitions">A collection of
        /// service endpoint policy definitions of the service endpoint
        /// policy.</param>
        /// <param name="subnets">A collection of references to
        /// subnets.</param>
        /// <param name="resourceGuid">The resource GUID property of the
        /// service endpoint policy resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// service endpoint policy resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="kind">Kind of service endpoint policy. This is
        /// metadata used for the Azure portal experience.</param>
        public ServiceEndpointPolicy(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<ServiceEndpointPolicyDefinition> serviceEndpointPolicyDefinitions = default(IList<ServiceEndpointPolicyDefinition>), IList<Subnet> subnets = default(IList<Subnet>), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string), string kind = default(string))
            : base(id, name, type, location, tags)
        {
            ServiceEndpointPolicyDefinitions = serviceEndpointPolicyDefinitions;
            Subnets = subnets;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
            Kind = kind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a collection of service endpoint policy definitions of
        /// the service endpoint policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceEndpointPolicyDefinitions")]
        public IList<ServiceEndpointPolicyDefinition> ServiceEndpointPolicyDefinitions { get; set; }

        /// <summary>
        /// Gets a collection of references to subnets.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnets")]
        public IList<Subnet> Subnets { get; private set; }

        /// <summary>
        /// Gets the resource GUID property of the service endpoint policy
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the service endpoint policy
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets kind of service endpoint policy. This is metadata used for the
        /// Azure portal experience.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

    }
}
