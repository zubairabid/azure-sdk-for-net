// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class StorageAccountCredentials
    {
        internal static StorageAccountCredentials DeserializeStorageAccountCredentials(JsonElement element)
        {
            Optional<string> resourceId = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryKey"))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
            }
            return new StorageAccountCredentials(resourceId.Value, primaryKey.Value, secondaryKey.Value);
        }
    }
}
