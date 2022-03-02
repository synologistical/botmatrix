﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Microsoft.Bot.Connector.Schema
{
    /// <summary>Metadata for an attachment.</summary>
    public class AttachmentInfo
    {
        /// <summary>Initializes a new instance of the <see cref="AttachmentInfo"/> class.</summary>
        public AttachmentInfo()
        {
            CustomInit();
        }

        /// <summary>Initializes a new instance of the <see cref="AttachmentInfo"/> class.</summary>
        /// <param name="name">Name of the attachment.</param>
        /// <param name="type">ContentType of the attachment.</param>
        /// <param name="views">attachment views.</param>
        public AttachmentInfo(string name = default, string type = default, IList<AttachmentView> views = default)
        {
            Name = name;
            Type = type;
            Views = views;
            CustomInit();
        }

        /// <summary>Gets or sets name of the attachment.</summary>
        /// <value>The name of the attachment.</value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets contentType of the attachment.</summary>
        /// <value>The content type of the attachment.</value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>Gets or sets attachment views.</summary>
        /// <value> The attachment views.</value>
        [SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Property setter is required for the collection to be deserialized")]
        [JsonPropertyName("views")]
        public IList<AttachmentView> Views { get; set; }

        /// <summary>An initialization method that performs custom operations like setting defaults.</summary>
        private void CustomInit()
        {
        }
    }
}