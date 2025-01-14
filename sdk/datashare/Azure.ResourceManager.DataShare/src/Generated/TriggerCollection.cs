// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing a collection of <see cref="TriggerResource" /> and their operations.
    /// Each <see cref="TriggerResource" /> in the collection will belong to the same instance of <see cref="ShareSubscriptionResource" />.
    /// To get a <see cref="TriggerCollection" /> instance call the GetTriggers method from an instance of <see cref="ShareSubscriptionResource" />.
    /// </summary>
    public partial class TriggerCollection : ArmCollection, IEnumerable<TriggerResource>, IAsyncEnumerable<TriggerResource>
    {
        private readonly ClientDiagnostics _triggerClientDiagnostics;
        private readonly TriggersRestOperations _triggerRestClient;

        /// <summary> Initializes a new instance of the <see cref="TriggerCollection"/> class for mocking. </summary>
        protected TriggerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TriggerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TriggerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _triggerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", TriggerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TriggerResource.ResourceType, out string triggerApiVersion);
            _triggerRestClient = new TriggersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, triggerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ShareSubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ShareSubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Trigger 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}
        /// Operation Id: Triggers_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="data"> Trigger details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TriggerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string triggerName, TriggerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _triggerClientDiagnostics.CreateScope("TriggerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _triggerRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataShareArmOperation<TriggerResource>(new TriggerOperationSource(Client), _triggerClientDiagnostics, Pipeline, _triggerRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a Trigger 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}
        /// Operation Id: Triggers_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="data"> Trigger details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TriggerResource> CreateOrUpdate(WaitUntil waitUntil, string triggerName, TriggerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _triggerClientDiagnostics.CreateScope("TriggerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _triggerRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, data, cancellationToken);
                var operation = new DataShareArmOperation<TriggerResource>(new TriggerOperationSource(Client), _triggerClientDiagnostics, Pipeline, _triggerRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Trigger in a shareSubscription
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}
        /// Operation Id: Triggers_Get
        /// </summary>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<Response<TriggerResource>> GetAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _triggerClientDiagnostics.CreateScope("TriggerCollection.Get");
            scope.Start();
            try
            {
                var response = await _triggerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Trigger in a shareSubscription
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}
        /// Operation Id: Triggers_Get
        /// </summary>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual Response<TriggerResource> Get(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _triggerClientDiagnostics.CreateScope("TriggerCollection.Get");
            scope.Start();
            try
            {
                var response = _triggerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Triggers in a share subscription
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers
        /// Operation Id: Triggers_ListByShareSubscription
        /// </summary>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TriggerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TriggerResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<TriggerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _triggerClientDiagnostics.CreateScope("TriggerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _triggerRestClient.ListByShareSubscriptionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TriggerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TriggerResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _triggerClientDiagnostics.CreateScope("TriggerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _triggerRestClient.ListByShareSubscriptionNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TriggerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List Triggers in a share subscription
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers
        /// Operation Id: Triggers_ListByShareSubscription
        /// </summary>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TriggerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TriggerResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<TriggerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _triggerClientDiagnostics.CreateScope("TriggerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _triggerRestClient.ListByShareSubscription(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TriggerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TriggerResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _triggerClientDiagnostics.CreateScope("TriggerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _triggerRestClient.ListByShareSubscriptionNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TriggerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}
        /// Operation Id: Triggers_Get
        /// </summary>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _triggerClientDiagnostics.CreateScope("TriggerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _triggerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/triggers/{triggerName}
        /// Operation Id: Triggers_Get
        /// </summary>
        /// <param name="triggerName"> The name of the trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual Response<bool> Exists(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _triggerClientDiagnostics.CreateScope("TriggerCollection.Exists");
            scope.Start();
            try
            {
                var response = _triggerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, triggerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TriggerResource> IEnumerable<TriggerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TriggerResource> IAsyncEnumerable<TriggerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
