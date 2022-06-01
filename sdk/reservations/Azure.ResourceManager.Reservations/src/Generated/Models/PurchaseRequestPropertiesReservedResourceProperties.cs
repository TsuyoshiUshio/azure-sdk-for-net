// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Properties specific to each reserved resource type. Not required if not applicable. </summary>
    internal partial class PurchaseRequestPropertiesReservedResourceProperties
    {
        /// <summary> Initializes a new instance of PurchaseRequestPropertiesReservedResourceProperties. </summary>
        public PurchaseRequestPropertiesReservedResourceProperties()
        {
        }

        /// <summary> Initializes a new instance of PurchaseRequestPropertiesReservedResourceProperties. </summary>
        /// <param name="instanceFlexibility"> Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines reserved resource type. </param>
        internal PurchaseRequestPropertiesReservedResourceProperties(InstanceFlexibility? instanceFlexibility)
        {
            InstanceFlexibility = instanceFlexibility;
        }

        /// <summary> Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines reserved resource type. </summary>
        public InstanceFlexibility? InstanceFlexibility { get; set; }
    }
}
