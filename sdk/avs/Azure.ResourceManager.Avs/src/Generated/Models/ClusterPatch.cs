// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> An update of a cluster resource. </summary>
    public partial class ClusterPatch
    {
        /// <summary> Initializes a new instance of ClusterPatch. </summary>
        public ClusterPatch()
        {
            Hosts = new ChangeTrackingList<string>();
        }

        /// <summary> The cluster size. </summary>
        public int? ClusterSize { get; set; }
        /// <summary> The hosts. </summary>
        public IList<string> Hosts { get; }
    }
}
