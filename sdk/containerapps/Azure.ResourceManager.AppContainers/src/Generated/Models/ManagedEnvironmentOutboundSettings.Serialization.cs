// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ManagedEnvironmentOutboundSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OutBoundType))
            {
                writer.WritePropertyName("outBoundType");
                writer.WriteStringValue(OutBoundType.Value.ToString());
            }
            if (Optional.IsDefined(VirtualNetworkApplianceIP))
            {
                writer.WritePropertyName("virtualNetworkApplianceIp");
                writer.WriteStringValue(VirtualNetworkApplianceIP);
            }
            writer.WriteEndObject();
        }

        internal static ManagedEnvironmentOutboundSettings DeserializeManagedEnvironmentOutboundSettings(JsonElement element)
        {
            Optional<ManagedEnvironmentOutBoundType> outBoundType = default;
            Optional<string> virtualNetworkApplianceIP = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outBoundType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    outBoundType = new ManagedEnvironmentOutBoundType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualNetworkApplianceIp"))
                {
                    virtualNetworkApplianceIP = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedEnvironmentOutboundSettings(Optional.ToNullable(outBoundType), virtualNetworkApplianceIP.Value);
        }
    }
}
