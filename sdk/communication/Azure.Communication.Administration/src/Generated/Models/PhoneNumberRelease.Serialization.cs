// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    public partial class PhoneNumberRelease
    {
        internal static PhoneNumberRelease DeserializePhoneNumberRelease(JsonElement element)
        {
            Optional<string> releaseId = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<ReleaseStatus> status = default;
            Optional<string> errorMessage = default;
            Optional<IReadOnlyDictionary<string, PhoneNumberReleaseDetails>> phoneNumberReleaseStatusDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("releaseId"))
                {
                    releaseId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdAt"))
                {
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new ReleaseStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneNumberReleaseStatusDetails"))
                {
                    Dictionary<string, PhoneNumberReleaseDetails> dictionary = new Dictionary<string, PhoneNumberReleaseDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, PhoneNumberReleaseDetails.DeserializePhoneNumberReleaseDetails(property0.Value));
                    }
                    phoneNumberReleaseStatusDetails = dictionary;
                    continue;
                }
            }
            return new PhoneNumberRelease(releaseId.Value, Optional.ToNullable(createdAt), Optional.ToNullable(status), errorMessage.Value, Optional.ToDictionary(phoneNumberReleaseStatusDetails));
        }
    }
}
