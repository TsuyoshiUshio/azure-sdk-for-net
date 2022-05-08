// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Language.Conversations
{
    /// <summary> Supported parameters for an conversational summarization task. </summary>
    public partial class ConversationSummarizationTaskParameters : PreBuiltTaskParameters
    {
        /// <summary> Initializes a new instance of ConversationSummarizationTaskParameters. </summary>
        /// <param name="summaryAspects"></param>
        public ConversationSummarizationTaskParameters(SummaryAspectEnum summaryAspects)
        {
            SummaryAspects = summaryAspects;
        }

        /// <summary> Initializes a new instance of ConversationSummarizationTaskParameters. </summary>
        /// <param name="loggingOptOut"></param>
        /// <param name="modelVersion"></param>
        /// <param name="summaryAspects"></param>
        internal ConversationSummarizationTaskParameters(bool? loggingOptOut, string modelVersion, SummaryAspectEnum summaryAspects) : base(loggingOptOut, modelVersion)
        {
            SummaryAspects = summaryAspects;
        }

        /// <summary> Gets or sets the summary aspects. </summary>
        public SummaryAspectEnum SummaryAspects { get; set; }
    }
}
