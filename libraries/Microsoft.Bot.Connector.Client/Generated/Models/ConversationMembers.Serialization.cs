// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Bot.Connector.Client.Models
{
    public partial class ConversationMembers
    {
        internal static ConversationMembers DeserializeConversationMembers(JsonElement element)
        {
            Optional<string> id = default;
            Optional<IReadOnlyList<ChannelAccount>> members = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("members"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ChannelAccount> array = new List<ChannelAccount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChannelAccount.DeserializeChannelAccount(item));
                    }
                    members = array;
                    continue;
                }
            }
            return new ConversationMembers(id.Value, Optional.ToList(members));
        }
    }
}