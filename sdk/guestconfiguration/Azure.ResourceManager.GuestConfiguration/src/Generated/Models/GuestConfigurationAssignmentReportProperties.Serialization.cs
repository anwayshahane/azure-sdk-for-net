// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class GuestConfigurationAssignmentReportProperties
    {
        internal static GuestConfigurationAssignmentReportProperties DeserializeGuestConfigurationAssignmentReportProperties(JsonElement element)
        {
            Optional<ComplianceStatus> complianceStatus = default;
            Optional<string> reportId = default;
            Optional<AssignmentInfo> assignment = default;
            Optional<VmInfo> vm = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<AssignmentReportDetails> details = default;
            Optional<string> vmssResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complianceStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    complianceStatus = new ComplianceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reportId"))
                {
                    reportId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignment"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    assignment = AssignmentInfo.DeserializeAssignmentInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("vm"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vm = VmInfo.DeserializeVmInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        details = null;
                        continue;
                    }
                    details = AssignmentReportDetails.DeserializeAssignmentReportDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("vmssResourceId"))
                {
                    vmssResourceId = property.Value.GetString();
                    continue;
                }
            }
            return new GuestConfigurationAssignmentReportProperties(Optional.ToNullable(complianceStatus), reportId.Value, assignment.Value, vm.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), details.Value, vmssResourceId.Value);
        }
    }
}
