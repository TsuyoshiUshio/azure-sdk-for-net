// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties of the Job Response object. </summary>
    public partial class IotHubJobInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotHubJobInfo"/>. </summary>
        internal IotHubJobInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IotHubJobInfo"/>. </summary>
        /// <param name="jobId"> The job identifier. </param>
        /// <param name="startOn"> The start time of the job. </param>
        /// <param name="endOn"> The time the job stopped processing. </param>
        /// <param name="jobType"> The type of the job. </param>
        /// <param name="status"> The status of the job. </param>
        /// <param name="failureReason"> If status == failed, this string containing the reason for the failure. </param>
        /// <param name="statusMessage"> The status message for the job. </param>
        /// <param name="parentJobId"> The job identifier of the parent job, if any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubJobInfo(string jobId, DateTimeOffset? startOn, DateTimeOffset? endOn, IotHubJobType? jobType, IotHubJobStatus? status, string failureReason, string statusMessage, string parentJobId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            JobId = jobId;
            StartOn = startOn;
            EndOn = endOn;
            JobType = jobType;
            Status = status;
            FailureReason = failureReason;
            StatusMessage = statusMessage;
            ParentJobId = parentJobId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The job identifier. </summary>
        public string JobId { get; }
        /// <summary> The start time of the job. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The time the job stopped processing. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The type of the job. </summary>
        public IotHubJobType? JobType { get; }
        /// <summary> The status of the job. </summary>
        public IotHubJobStatus? Status { get; }
        /// <summary> If status == failed, this string containing the reason for the failure. </summary>
        public string FailureReason { get; }
        /// <summary> The status message for the job. </summary>
        public string StatusMessage { get; }
        /// <summary> The job identifier of the parent job, if any. </summary>
        public string ParentJobId { get; }
    }
}
