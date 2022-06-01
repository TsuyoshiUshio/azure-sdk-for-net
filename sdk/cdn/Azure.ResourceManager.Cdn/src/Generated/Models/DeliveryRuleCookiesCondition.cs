// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the Cookies condition for the delivery rule. </summary>
    public partial class DeliveryRuleCookiesCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of DeliveryRuleCookiesCondition. </summary>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRuleCookiesCondition(CookiesMatchCondition properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
            Name = MatchVariable.Cookies;
        }

        /// <summary> Initializes a new instance of DeliveryRuleCookiesCondition. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        internal DeliveryRuleCookiesCondition(MatchVariable name, CookiesMatchCondition properties) : base(name)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public CookiesMatchCondition Properties { get; set; }
    }
}
