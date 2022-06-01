// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Compute start stop schedule properties. </summary>
    public partial class ComputeStartStopSchedule
    {
        /// <summary> Initializes a new instance of ComputeStartStopSchedule. </summary>
        internal ComputeStartStopSchedule()
        {
        }

        /// <summary> Initializes a new instance of ComputeStartStopSchedule. </summary>
        /// <param name="id"> Schedule id. </param>
        /// <param name="provisioningStatus"> The current deployment state of schedule. </param>
        /// <param name="action"> The compute power action. </param>
        /// <param name="schedule"> Base definition of a schedule. </param>
        internal ComputeStartStopSchedule(string id, ProvisioningStatus? provisioningStatus, ComputePowerAction? action, ScheduleBase schedule)
        {
            Id = id;
            ProvisioningStatus = provisioningStatus;
            Action = action;
            Schedule = schedule;
        }

        /// <summary> Schedule id. </summary>
        public string Id { get; }
        /// <summary> The current deployment state of schedule. </summary>
        public ProvisioningStatus? ProvisioningStatus { get; }
        /// <summary> The compute power action. </summary>
        public ComputePowerAction? Action { get; }
        /// <summary> Base definition of a schedule. </summary>
        public ScheduleBase Schedule { get; }
    }
}
