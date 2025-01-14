// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Represents a data export setting. </summary>
    public partial class DataExportSettings : SettingData
    {
        /// <summary> Initializes a new instance of DataExportSettings. </summary>
        public DataExportSettings()
        {
            Kind = SettingKind.DataExportSettings;
        }

        /// <summary> Initializes a new instance of DataExportSettings. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> the kind of the settings string. </param>
        /// <param name="enabled"> Is the data export setting enabled. </param>
        internal DataExportSettings(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SettingKind kind, bool? enabled) : base(id, name, resourceType, systemData, kind)
        {
            Enabled = enabled;
            Kind = kind;
        }

        /// <summary> Is the data export setting enabled. </summary>
        public bool? Enabled { get; set; }
    }
}
