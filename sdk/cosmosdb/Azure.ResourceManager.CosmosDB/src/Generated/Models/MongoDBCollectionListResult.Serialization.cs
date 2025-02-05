// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MongoDBCollectionListResult
    {
        internal static MongoDBCollectionListResult DeserializeMongoDBCollectionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<MongoDBCollectionGetResults>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<MongoDBCollectionGetResults> array = new List<MongoDBCollectionGetResults>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MongoDBCollectionGetResults.DeserializeMongoDBCollectionGetResults(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MongoDBCollectionListResult(Optional.ToList(value));
        }
    }
}
