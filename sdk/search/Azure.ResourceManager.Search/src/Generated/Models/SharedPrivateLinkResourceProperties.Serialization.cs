// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    public partial class SharedPrivateLinkResourceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateLinkResourceId))
            {
                writer.WritePropertyName("privateLinkResourceId");
                writer.WriteStringValue(PrivateLinkResourceId);
            }
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId");
                writer.WriteStringValue(GroupId);
            }
            if (Optional.IsDefined(RequestMessage))
            {
                writer.WritePropertyName("requestMessage");
                writer.WriteStringValue(RequestMessage);
            }
            if (Optional.IsDefined(ResourceRegion))
            {
                writer.WritePropertyName("resourceRegion");
                writer.WriteStringValue(ResourceRegion);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static SharedPrivateLinkResourceProperties DeserializeSharedPrivateLinkResourceProperties(JsonElement element)
        {
            Optional<string> privateLinkResourceId = default;
            Optional<string> groupId = default;
            Optional<string> requestMessage = default;
            Optional<string> resourceRegion = default;
            Optional<SharedPrivateLinkResourceStatus> status = default;
            Optional<SharedPrivateLinkResourceProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateLinkResourceId"))
                {
                    privateLinkResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestMessage"))
                {
                    requestMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceRegion"))
                {
                    resourceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = property.Value.GetString().ToSharedPrivateLinkResourceStatus();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = property.Value.GetString().ToSharedPrivateLinkResourceProvisioningState();
                    continue;
                }
            }
            return new SharedPrivateLinkResourceProperties(privateLinkResourceId.Value, groupId.Value, requestMessage.Value, resourceRegion.Value, Optional.ToNullable(status), Optional.ToNullable(provisioningState));
        }
    }
}
