// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.Language.Conversations
{
    /// <summary> Additional properties for supporting transcript conversation. </summary>
    public partial class TranscriptConversationItem : ConversationItemBase
    {
        /// <summary> Initializes a new instance of TranscriptConversationItem. </summary>
        /// <param name="id"> The ID of a conversation item. </param>
        /// <param name="participantId"> The participant ID of a conversation item. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="participantId"/> is null. </exception>
        public TranscriptConversationItem(string id, string participantId) : base(id, participantId)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (participantId == null)
            {
                throw new ArgumentNullException(nameof(participantId));
            }

            Modality = InputModality.Transcript;
        }

        /// <summary> Additional properties for supporting transcript conversation. </summary>
        public TranscriptConversationItemContent Content { get; set; }
    }
}
