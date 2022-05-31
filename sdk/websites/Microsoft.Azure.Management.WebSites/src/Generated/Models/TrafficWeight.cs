// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Traffic weight assigned to a revision
    /// </summary>
    public partial class TrafficWeight
    {
        /// <summary>
        /// Initializes a new instance of the TrafficWeight class.
        /// </summary>
        public TrafficWeight()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrafficWeight class.
        /// </summary>
        /// <param name="revisionName">Name of a revision</param>
        /// <param name="weight">Traffic weight assigned to a revision</param>
        /// <param name="latestRevision">Indicates that the traffic weight
        /// belongs to a latest stable revision</param>
        public TrafficWeight(string revisionName = default(string), int? weight = default(int?), bool? latestRevision = default(bool?))
        {
            RevisionName = revisionName;
            Weight = weight;
            LatestRevision = latestRevision;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of a revision
        /// </summary>
        [JsonProperty(PropertyName = "revisionName")]
        public string RevisionName { get; set; }

        /// <summary>
        /// Gets or sets traffic weight assigned to a revision
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or sets indicates that the traffic weight belongs to a latest
        /// stable revision
        /// </summary>
        [JsonProperty(PropertyName = "latestRevision")]
        public bool? LatestRevision { get; set; }

    }
}
