// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    public partial class ArcSettingData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ArcInstanceResourceGroup))
            {
                writer.WritePropertyName("arcInstanceResourceGroup");
                writer.WriteStringValue(ArcInstanceResourceGroup);
            }
            if (Optional.IsDefined(ArcApplicationClientId))
            {
                writer.WritePropertyName("arcApplicationClientId");
                writer.WriteStringValue(ArcApplicationClientId.Value);
            }
            if (Optional.IsDefined(ArcApplicationTenantId))
            {
                writer.WritePropertyName("arcApplicationTenantId");
                writer.WriteStringValue(ArcApplicationTenantId.Value);
            }
            if (Optional.IsDefined(ArcServicePrincipalObjectId))
            {
                writer.WritePropertyName("arcServicePrincipalObjectId");
                writer.WriteStringValue(ArcServicePrincipalObjectId.Value);
            }
            if (Optional.IsDefined(ArcApplicationObjectId))
            {
                writer.WritePropertyName("arcApplicationObjectId");
                writer.WriteStringValue(ArcApplicationObjectId.Value);
            }
            if (Optional.IsDefined(ConnectivityProperties))
            {
                writer.WritePropertyName("connectivityProperties");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ConnectivityProperties);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ConnectivityProperties.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ArcSettingData DeserializeArcSettingData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> arcInstanceResourceGroup = default;
            Optional<Guid> arcApplicationClientId = default;
            Optional<Guid> arcApplicationTenantId = default;
            Optional<Guid> arcServicePrincipalObjectId = default;
            Optional<Guid> arcApplicationObjectId = default;
            Optional<ArcSettingAggregateState> aggregateState = default;
            Optional<IReadOnlyList<PerNodeState>> perNodeDetails = default;
            Optional<BinaryData> connectivityProperties = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("arcInstanceResourceGroup"))
                        {
                            arcInstanceResourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("arcApplicationClientId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            arcApplicationClientId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("arcApplicationTenantId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            arcApplicationTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("arcServicePrincipalObjectId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            arcServicePrincipalObjectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("arcApplicationObjectId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            arcApplicationObjectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aggregateState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            aggregateState = new ArcSettingAggregateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("perNodeDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PerNodeState> array = new List<PerNodeState>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PerNodeState.DeserializePerNodeState(item));
                            }
                            perNodeDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("connectivityProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            connectivityProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ArcSettingData(id, name, type, systemData, Optional.ToNullable(provisioningState), arcInstanceResourceGroup.Value, Optional.ToNullable(arcApplicationClientId), Optional.ToNullable(arcApplicationTenantId), Optional.ToNullable(arcServicePrincipalObjectId), Optional.ToNullable(arcApplicationObjectId), Optional.ToNullable(aggregateState), Optional.ToList(perNodeDetails), connectivityProperties.Value);
        }
    }
}
