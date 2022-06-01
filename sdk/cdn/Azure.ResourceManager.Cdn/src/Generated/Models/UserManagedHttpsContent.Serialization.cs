// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class UserManagedHttpsContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("certificateSourceParameters");
            writer.WriteObjectValue(CertificateSourceParameters);
            writer.WritePropertyName("certificateSource");
            writer.WriteStringValue(CertificateSource.ToString());
            writer.WritePropertyName("protocolType");
            writer.WriteStringValue(ProtocolType.ToString());
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion");
                writer.WriteStringValue(MinimumTlsVersion.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static UserManagedHttpsContent DeserializeUserManagedHttpsContent(JsonElement element)
        {
            KeyVaultCertificateSource certificateSourceParameters = default;
            CertificateSource certificateSource = default;
            ProtocolType protocolType = default;
            Optional<MinimumTlsVersion> minimumTlsVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateSourceParameters"))
                {
                    certificateSourceParameters = KeyVaultCertificateSource.DeserializeKeyVaultCertificateSource(property.Value);
                    continue;
                }
                if (property.NameEquals("certificateSource"))
                {
                    certificateSource = new CertificateSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocolType"))
                {
                    protocolType = new ProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minimumTlsVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minimumTlsVersion = property.Value.GetString().ToMinimumTlsVersion();
                    continue;
                }
            }
            return new UserManagedHttpsContent(certificateSource, protocolType, Optional.ToNullable(minimumTlsVersion), certificateSourceParameters);
        }
    }
}
