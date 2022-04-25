// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Bot.Connector.Client.Models
{
    public partial class Attachment : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("contentType");
                writer.WriteStringValue(ContentType);
            }
            if (Optional.IsDefined(ContentUrl))
            {
                writer.WritePropertyName("contentUrl");
                writer.WriteStringValue(ContentUrl);
            }
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content");
                writer.WriteObjectValue(Content);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ThumbnailUrl))
            {
                writer.WritePropertyName("thumbnailUrl");
                writer.WriteStringValue(ThumbnailUrl);
            }
            writer.WriteEndObject();
        }
    }
}