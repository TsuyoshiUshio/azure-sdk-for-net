// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ElasticSan.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ElasticSan
{
    public partial class ElasticSanVolumeData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(CreationData))
            {
                writer.WritePropertyName("creationData");
                writer.WriteObjectValue(CreationData);
            }
            if (Optional.IsDefined(SizeGiB))
            {
                writer.WritePropertyName("sizeGiB");
                writer.WriteNumberValue(SizeGiB.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ElasticSanVolumeData DeserializeElasticSanVolumeData(JsonElement element)
        {
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> volumeId = default;
            Optional<SourceCreationData> creationData = default;
            Optional<long> sizeGiB = default;
            Optional<IscsiTargetInfo> storageTarget = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("volumeId"))
                        {
                            volumeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationData"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationData = SourceCreationData.DeserializeSourceCreationData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sizeGiB"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sizeGiB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("storageTarget"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            storageTarget = IscsiTargetInfo.DeserializeIscsiTargetInfo(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ElasticSanVolumeData(id, name, type, systemData, tags, location, volumeId.Value, creationData.Value, Optional.ToNullable(sizeGiB), storageTarget.Value);
        }
    }
}
