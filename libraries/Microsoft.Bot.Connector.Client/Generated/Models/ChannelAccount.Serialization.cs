// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Bot.Connector.Client.Models
{
    public partial class ChannelAccount : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AadObjectId))
            {
                writer.WritePropertyName("aadObjectId");
                writer.WriteStringValue(AadObjectId);
            }
            if (Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role");
                writer.WriteStringValue(Role.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ChannelAccount DeserializeChannelAccount(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> aadObjectId = default;
            Optional<RoleTypes> role = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadObjectId"))
                {
                    aadObjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    role = new RoleTypes(property.Value.GetString());
                    continue;
                }
            }
            return new ChannelAccount(id.Value, name.Value, aadObjectId.Value, Optional.ToNullable(role));
        }
    }
}