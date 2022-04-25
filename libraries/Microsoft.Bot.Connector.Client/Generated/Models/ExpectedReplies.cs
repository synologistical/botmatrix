﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Bot.Connector.Client.Models
{
    /// <summary> Contents of the reply to an operation which returns expected Activity replies. </summary>
    public partial class ExpectedReplies
    {
        /// <summary> Initializes a new instance of ExpectedReplies. </summary>
        public ExpectedReplies()
        {
            Activities = new ChangeTrackingList<Activity>();
        }

        /// <summary> A list of Activities included in the response. </summary>
        public IList<Activity> Activities { get; }
    }
}