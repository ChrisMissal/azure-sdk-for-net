// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineStatusCodeCount
    {
        internal static VirtualMachineStatusCodeCount DeserializeVirtualMachineStatusCodeCount(JsonElement element)
        {
            Optional<string> code = default;
            Optional<int> count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
            }
            return new VirtualMachineStatusCodeCount(code.Value, Optional.ToNullable(count));
        }
    }
}
