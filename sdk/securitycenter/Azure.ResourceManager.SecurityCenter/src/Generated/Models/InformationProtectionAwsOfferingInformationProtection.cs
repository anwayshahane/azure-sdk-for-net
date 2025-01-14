// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The native cloud connection configuration. </summary>
    internal partial class InformationProtectionAwsOfferingInformationProtection
    {
        /// <summary> Initializes a new instance of InformationProtectionAwsOfferingInformationProtection. </summary>
        public InformationProtectionAwsOfferingInformationProtection()
        {
        }

        /// <summary> Initializes a new instance of InformationProtectionAwsOfferingInformationProtection. </summary>
        /// <param name="cloudRoleArn"> The cloud role ARN in AWS for this feature. </param>
        internal InformationProtectionAwsOfferingInformationProtection(string cloudRoleArn)
        {
            CloudRoleArn = cloudRoleArn;
        }

        /// <summary> The cloud role ARN in AWS for this feature. </summary>
        public string CloudRoleArn { get; set; }
    }
}
