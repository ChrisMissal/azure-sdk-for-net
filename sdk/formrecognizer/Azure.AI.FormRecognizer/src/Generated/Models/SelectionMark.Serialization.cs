// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class SelectionMark
    {
        internal static SelectionMark DeserializeSelectionMark(JsonElement element)
        {
            IReadOnlyList<float> boundingBox = default;
            float confidence = default;
            FormSelectionMarkState state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("boundingBox"))
                {
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    boundingBox = array;
                    continue;
                }
                if (property.NameEquals("confidence"))
                {
                    confidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    state = property.Value.GetString().ToFormSelectionMarkState();
                    continue;
                }
            }
            return new SelectionMark(boundingBox, confidence, state);
        }
    }
}
