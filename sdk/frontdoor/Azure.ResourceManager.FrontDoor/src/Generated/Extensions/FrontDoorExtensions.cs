// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.FrontDoor. </summary>
    public static partial class FrontDoorExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary>
        /// Check the availability of a Front Door resource name.
        /// Request Path: /providers/Microsoft.Network/checkFrontDoorNameAvailability
        /// Operation Id: FrontDoorNameAvailability_Check
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="input"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityOutput>> CheckFrontDoorNameAvailabilityAsync(this TenantResource tenantResource, CheckNameAvailabilityInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            return await GetExtensionClient(tenantResource).CheckFrontDoorNameAvailabilityAsync(input, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of a Front Door resource name.
        /// Request Path: /providers/Microsoft.Network/checkFrontDoorNameAvailability
        /// Operation Id: FrontDoorNameAvailability_Check
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="input"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public static Response<CheckNameAvailabilityOutput> CheckFrontDoorNameAvailability(this TenantResource tenantResource, CheckNameAvailabilityInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            return GetExtensionClient(tenantResource).CheckFrontDoorNameAvailability(input, cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Lists all available managed rule sets.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallManagedRuleSets
        /// Operation Id: ManagedRuleSets_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedRuleSetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ManagedRuleSetDefinition> GetManagedRuleSetsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetManagedRuleSetsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all available managed rule sets.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallManagedRuleSets
        /// Operation Id: ManagedRuleSets_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedRuleSetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ManagedRuleSetDefinition> GetManagedRuleSets(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetManagedRuleSets(cancellationToken);
        }

        /// <summary>
        /// Check the availability of a Front Door subdomain.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/checkFrontDoorNameAvailability
        /// Operation Id: FrontDoorNameAvailabilityWithSubscription_Check
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="input"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityOutput>> CheckFrontDoorNameAvailabilityWithSubscriptionAsync(this SubscriptionResource subscriptionResource, CheckNameAvailabilityInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            return await GetExtensionClient(subscriptionResource).CheckFrontDoorNameAvailabilityWithSubscriptionAsync(input, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of a Front Door subdomain.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/checkFrontDoorNameAvailability
        /// Operation Id: FrontDoorNameAvailabilityWithSubscription_Check
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="input"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public static Response<CheckNameAvailabilityOutput> CheckFrontDoorNameAvailabilityWithSubscription(this SubscriptionResource subscriptionResource, CheckNameAvailabilityInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            return GetExtensionClient(subscriptionResource).CheckFrontDoorNameAvailabilityWithSubscription(input, cancellationToken);
        }

        /// <summary>
        /// Lists all of the Front Doors within an Azure subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/frontDoors
        /// Operation Id: FrontDoors_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<FrontDoorResource> GetFrontDoorsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetFrontDoorsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all of the Front Doors within an Azure subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/frontDoors
        /// Operation Id: FrontDoors_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<FrontDoorResource> GetFrontDoors(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetFrontDoors(cancellationToken);
        }

        /// <summary>
        /// Gets a list of Network Experiment Profiles under a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/NetworkExperimentProfiles
        /// Operation Id: NetworkExperimentProfiles_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProfileResource> GetProfilesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetProfilesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of Network Experiment Profiles under a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/NetworkExperimentProfiles
        /// Operation Id: NetworkExperimentProfiles_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProfileResource> GetProfiles(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetProfiles(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of WebApplicationFirewallPolicyResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of WebApplicationFirewallPolicyResources and their operations over a WebApplicationFirewallPolicyResource. </returns>
        public static WebApplicationFirewallPolicyCollection GetWebApplicationFirewallPolicies(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetWebApplicationFirewallPolicies();
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="policyName"> The name of the Web Application Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<WebApplicationFirewallPolicyResource>> GetWebApplicationFirewallPolicyAsync(this ResourceGroupResource resourceGroupResource, string policyName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetWebApplicationFirewallPolicies().GetAsync(policyName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="policyName"> The name of the Web Application Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<WebApplicationFirewallPolicyResource> GetWebApplicationFirewallPolicy(this ResourceGroupResource resourceGroupResource, string policyName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetWebApplicationFirewallPolicies().Get(policyName, cancellationToken);
        }

        /// <summary> Gets a collection of FrontDoorResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of FrontDoorResources and their operations over a FrontDoorResource. </returns>
        public static FrontDoorCollection GetFrontDoors(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetFrontDoors();
        }

        /// <summary>
        /// Gets a Front Door with the specified Front Door name under the specified subscription and resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}
        /// Operation Id: FrontDoors_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="frontDoorName"> Name of the Front Door which is globally unique. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontDoorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontDoorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<FrontDoorResource>> GetFrontDoorAsync(this ResourceGroupResource resourceGroupResource, string frontDoorName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetFrontDoors().GetAsync(frontDoorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Front Door with the specified Front Door name under the specified subscription and resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}
        /// Operation Id: FrontDoors_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="frontDoorName"> Name of the Front Door which is globally unique. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontDoorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontDoorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<FrontDoorResource> GetFrontDoor(this ResourceGroupResource resourceGroupResource, string frontDoorName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetFrontDoors().Get(frontDoorName, cancellationToken);
        }

        /// <summary> Gets a collection of ProfileResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ProfileResources and their operations over a ProfileResource. </returns>
        public static ProfileCollection GetProfiles(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetProfiles();
        }

        /// <summary>
        /// Gets an NetworkExperiment Profile by ProfileName
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}
        /// Operation Id: NetworkExperimentProfiles_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="profileName"> The Profile identifier associated with the Tenant and Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ProfileResource>> GetProfileAsync(this ResourceGroupResource resourceGroupResource, string profileName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetProfiles().GetAsync(profileName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an NetworkExperiment Profile by ProfileName
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}
        /// Operation Id: NetworkExperimentProfiles_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="profileName"> The Profile identifier associated with the Tenant and Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ProfileResource> GetProfile(this ResourceGroupResource resourceGroupResource, string profileName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetProfiles().Get(profileName, cancellationToken);
        }

        #region WebApplicationFirewallPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="WebApplicationFirewallPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WebApplicationFirewallPolicyResource.CreateResourceIdentifier" /> to create a <see cref="WebApplicationFirewallPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WebApplicationFirewallPolicyResource" /> object. </returns>
        public static WebApplicationFirewallPolicyResource GetWebApplicationFirewallPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                WebApplicationFirewallPolicyResource.ValidateResourceId(id);
                return new WebApplicationFirewallPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region FrontDoorResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorResource" /> object. </returns>
        public static FrontDoorResource GetFrontDoorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontDoorResource.ValidateResourceId(id);
                return new FrontDoorResource(client, id);
            }
            );
        }
        #endregion

        #region FrontendEndpointResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontendEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontendEndpointResource.CreateResourceIdentifier" /> to create a <see cref="FrontendEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontendEndpointResource" /> object. </returns>
        public static FrontendEndpointResource GetFrontendEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontendEndpointResource.ValidateResourceId(id);
                return new FrontendEndpointResource(client, id);
            }
            );
        }
        #endregion

        #region RulesEngineResource
        /// <summary>
        /// Gets an object representing a <see cref="RulesEngineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RulesEngineResource.CreateResourceIdentifier" /> to create a <see cref="RulesEngineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RulesEngineResource" /> object. </returns>
        public static RulesEngineResource GetRulesEngineResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RulesEngineResource.ValidateResourceId(id);
                return new RulesEngineResource(client, id);
            }
            );
        }
        #endregion

        #region ProfileResource
        /// <summary>
        /// Gets an object representing a <see cref="ProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProfileResource.CreateResourceIdentifier" /> to create a <see cref="ProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProfileResource" /> object. </returns>
        public static ProfileResource GetProfileResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ProfileResource.ValidateResourceId(id);
                return new ProfileResource(client, id);
            }
            );
        }
        #endregion

        #region ExperimentResource
        /// <summary>
        /// Gets an object representing an <see cref="ExperimentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ExperimentResource.CreateResourceIdentifier" /> to create an <see cref="ExperimentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ExperimentResource" /> object. </returns>
        public static ExperimentResource GetExperimentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ExperimentResource.ValidateResourceId(id);
                return new ExperimentResource(client, id);
            }
            );
        }
        #endregion
    }
}
