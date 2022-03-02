﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace Microsoft.Bot.Connector.Schema.Teams
{
    /// <summary>
    /// Signin state (part of signin action auth flow) verification invoke query.
    /// </summary>
    public partial class SigninStateVerificationQuery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SigninStateVerificationQuery"/> class.
        /// </summary>
        public SigninStateVerificationQuery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigninStateVerificationQuery"/> class.
        /// </summary>
        /// <param name="state"> The state string originally received when the
        /// signin web flow is finished with a state posted back to client via
        /// tab SDK microsoftTeams.authentication.notifySuccess(state).</param>
        public SigninStateVerificationQuery(string state = default)
        {
            State = state;
            CustomInit();
        }

        /// <summary>
        /// Gets or sets  The state string originally received when the signin
        /// web flow is finished with a state posted back to client via tab SDK
        /// microsoftTeams.authentication.notifySuccess(state).
        /// </summary>
        /// <value>The state.</value>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        partial void CustomInit();
    }
}
