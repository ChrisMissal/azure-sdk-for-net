// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class Operation
    {
        internal static Operation DeserializeOperation(JsonElement element)
        {
            Optional<string> name = default;
            Optional<OperationDisplay> display = default;
            Optional<string> origin = default;
            Optional<OperationPropertiesFormatServiceSpecification> serviceSpecification = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("display"))
                {
                    display = OperationDisplay.DeserializeOperationDisplay(property.Value);
                    continue;
                }
                if (property.NameEquals("origin"))
                {
                    origin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serviceSpecification"))
                        {
                            serviceSpecification = OperationPropertiesFormatServiceSpecification.DeserializeOperationPropertiesFormatServiceSpecification(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Operation(name.Value, display.Value, origin.Value, serviceSpecification.Value);
        }
    }
}
