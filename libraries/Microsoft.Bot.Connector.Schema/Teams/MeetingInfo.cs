﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace Microsoft.Bot.Connector.Schema.Teams
{
    /// <summary>
    /// General information about a Teams meeting.
    /// </summary>
    public class MeetingInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingInfo"/> class.
        /// </summary>
        public MeetingInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingInfo"/> class.
        /// </summary>
        /// <param name="details">The meeting's detailed information.</param>
        /// <param name="conversation">Conversation Account for the meeting.</param>
        /// <param name="organizer">Information specific to this organizer of the specific meeting.</param>
        public MeetingInfo(MeetingDetails details, ConversationAccount conversation = null, TeamsChannelAccount organizer = null)
        {
            Details = details;
            Conversation = conversation;
            Organizer = organizer;
            CustomInit();
        }

        /// <summary>
        /// Gets or sets the specific details of a Teams meeting.
        /// </summary>
        /// <value>
        /// The specific details of a Teams meeting.
        /// </value>
        [JsonPropertyName("details")]
        public MeetingDetails Details { get; set; }

        /// <summary>
        /// Gets or sets the Conversation Account for the meeting.
        /// </summary>
        /// <value>
        /// The Conversation Account for the meeting.
        /// </value>
        [JsonPropertyName("conversation")]
        public ConversationAccount Conversation { get; set; }

        /// <summary>
        /// Gets or sets the meeting organizer's user information.
        /// </summary>
        /// <value>
        /// The organizer's user information.
        /// </value>
        [JsonPropertyName("organizer")]
        public TeamsChannelAccount Organizer { get; set; }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        private void CustomInit()
        {
        }
    }
}