// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class ConfluentSchemaRegistry : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint");
                writer.WriteStringValue(Endpoint);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(ServiceType.ToString());
            writer.WriteEndObject();
        }

        internal static ConfluentSchemaRegistry DeserializeConfluentSchemaRegistry(JsonElement element)
        {
            Optional<string> endpoint = default;
            TargetServiceType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new TargetServiceType(property.Value.GetString());
                    continue;
                }
            }
            return new ConfluentSchemaRegistry(type, endpoint.Value);
        }
    }
}
