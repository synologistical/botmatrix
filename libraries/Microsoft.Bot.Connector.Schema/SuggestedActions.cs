﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json.Serialization;

namespace Microsoft.Bot.Connector.Schema
{
    /// <summary>
    /// SuggestedActions that can be performed.
    /// </summary>
    public class SuggestedActions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestedActions"/> class.
        /// </summary>
        public SuggestedActions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestedActions"/> class.
        /// </summary>
        /// <param name="to">Ids of the recipients that the actions should be
        /// shown to.  These Ids are relative to the channelId and a subset of
        /// all recipients of the activity.</param>
        /// <param name="actions">Actions that can be shown to the user.</param>
        public SuggestedActions(IList<string> to = default, IList<CardAction> actions = default)
        {
            To = to;
            Actions = actions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestedActions"/> class.
        /// </summary>
        /// <param name="to">Ids of the recipients that the actions should be
        /// shown to. These Ids are relative to the channelId and a subset of
        /// all recipients of the activity.</param>
        /// <param name="actions">Actions that can be shown to the user.</param>
        /// <exception cref="ArgumentNullException">ArgumentNullException.</exception>
        public SuggestedActions(IEnumerable<string> to, IEnumerable<CardAction> actions)
            : this(to.ToArray(), actions.ToArray())
        {
        }

        /// <summary>
        /// Gets or sets ids of the recipients that the actions should be shown
        /// to.  These Ids are relative to the channelId and a subset of all
        /// recipients of the activity.
        /// </summary>
        /// <value>The ID's of the recipients that the actions should be shown to.</value>
        [SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Property setter is required for the collection to be deserialized")]
        [JsonPropertyName("to")]
        public IList<string> To { get; set; }

        /// <summary>
        /// Gets or sets actions that can be shown to the user.
        /// </summary>
        /// <value>The actions that can be shown to the user.</value>
        [SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Property setter is required for the collection to be deserialized")]
        [JsonPropertyName("actions")]
        public IList<CardAction> Actions { get; set; }
    }
}