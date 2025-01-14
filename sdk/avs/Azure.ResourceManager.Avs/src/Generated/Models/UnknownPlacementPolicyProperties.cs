// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The UnknownPlacementPolicyProperties. </summary>
    internal partial class UnknownPlacementPolicyProperties : PlacementPolicyProperties
    {
        /// <summary> Initializes a new instance of UnknownPlacementPolicyProperties. </summary>
        /// <param name="policyType"> placement policy type. </param>
        /// <param name="state"> Whether the placement policy is enabled or disabled. </param>
        /// <param name="displayName"> Display name of the placement policy. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        internal UnknownPlacementPolicyProperties(PlacementPolicyType policyType, PlacementPolicyState? state, string displayName, PlacementPolicyProvisioningState? provisioningState) : base(policyType, state, displayName, provisioningState)
        {
            PolicyType = policyType;
        }
    }
}
