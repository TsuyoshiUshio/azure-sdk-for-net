// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A list of recommended sensitivity label update operations.
    /// </summary>
    public partial class RecommendedSensitivityLabelUpdateList
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecommendedSensitivityLabelUpdateList class.
        /// </summary>
        public RecommendedSensitivityLabelUpdateList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RecommendedSensitivityLabelUpdateList class.
        /// </summary>
        public RecommendedSensitivityLabelUpdateList(IList<RecommendedSensitivityLabelUpdate> operations = default(IList<RecommendedSensitivityLabelUpdate>))
        {
            Operations = operations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operations")]
        public IList<RecommendedSensitivityLabelUpdate> Operations { get; set; }

    }
}
