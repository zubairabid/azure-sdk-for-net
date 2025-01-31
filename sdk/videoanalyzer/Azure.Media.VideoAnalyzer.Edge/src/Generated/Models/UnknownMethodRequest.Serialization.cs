// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    internal partial class UnknownMethodRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion");
                writer.WriteStringValue(ApiVersion);
            }
            writer.WriteEndObject();
        }

        internal static UnknownMethodRequest DeserializeUnknownMethodRequest(JsonElement element)
        {
            string methodName = "Unknown";
            Optional<string> apiVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("methodName"))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@apiVersion"))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownMethodRequest(methodName, apiVersion.Value);
        }
    }
}
