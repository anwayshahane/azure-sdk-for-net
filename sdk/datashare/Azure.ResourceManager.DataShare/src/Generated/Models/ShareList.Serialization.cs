// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataShare;

namespace Azure.ResourceManager.DataShare.Models
{
    internal partial class ShareList
    {
        internal static ShareList DeserializeShareList(JsonElement element)
        {
            Optional<string> nextLink = default;
            IReadOnlyList<ShareData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<ShareData> array = new List<ShareData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ShareData.DeserializeShareData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ShareList(nextLink.Value, value);
        }
    }
}
