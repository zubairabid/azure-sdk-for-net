// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    internal partial class DeletedAutomationAccountListResult
    {
        internal static DeletedAutomationAccountListResult DeserializeDeletedAutomationAccountListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DeletedAutomationAccount>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DeletedAutomationAccount> array = new List<DeletedAutomationAccount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeletedAutomationAccount.DeserializeDeletedAutomationAccount(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DeletedAutomationAccountListResult(Optional.ToList(value));
        }
    }
}
