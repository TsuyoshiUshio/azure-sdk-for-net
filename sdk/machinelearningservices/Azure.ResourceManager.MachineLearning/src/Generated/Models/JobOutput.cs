// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Job output definition container information on where to find job output/logs. </summary>
    public partial class JobOutput
    {
        /// <summary> Initializes a new instance of JobOutput. </summary>
        public JobOutput()
        {
        }

        /// <summary> Initializes a new instance of JobOutput. </summary>
        /// <param name="description"> Description for the output. </param>
        /// <param name="jobOutputType"> [Required] Specifies the type of job. </param>
        internal JobOutput(string description, JobOutputType jobOutputType)
        {
            Description = description;
            JobOutputType = jobOutputType;
        }

        /// <summary> Description for the output. </summary>
        public string Description { get; set; }
        /// <summary> [Required] Specifies the type of job. </summary>
        internal JobOutputType JobOutputType { get; set; }
    }
}
