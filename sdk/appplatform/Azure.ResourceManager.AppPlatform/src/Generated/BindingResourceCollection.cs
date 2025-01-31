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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="BindingResource" /> and their operations.
    /// Each <see cref="BindingResource" /> in the collection will belong to the same instance of <see cref="AppPlatformAppResource" />.
    /// To get a <see cref="BindingResourceCollection" /> instance call the GetBindingResources method from an instance of <see cref="AppPlatformAppResource" />.
    /// </summary>
    public partial class BindingResourceCollection : ArmCollection, IEnumerable<BindingResource>, IAsyncEnumerable<BindingResource>
    {
        private readonly ClientDiagnostics _bindingResourceBindingsClientDiagnostics;
        private readonly BindingsRestOperations _bindingResourceBindingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BindingResourceCollection"/> class for mocking. </summary>
        protected BindingResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BindingResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BindingResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _bindingResourceBindingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", BindingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BindingResource.ResourceType, out string bindingResourceBindingsApiVersion);
            _bindingResourceBindingsRestClient = new BindingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, bindingResourceBindingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformAppResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformAppResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new Binding or update an exiting Binding.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}
        /// Operation Id: Bindings_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BindingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string bindingName, BindingResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bindingName, nameof(bindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _bindingResourceBindingsClientDiagnostics.CreateScope("BindingResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _bindingResourceBindingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<BindingResource>(new BindingResourceOperationSource(Client), _bindingResourceBindingsClientDiagnostics, Pipeline, _bindingResourceBindingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new Binding or update an exiting Binding.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}
        /// Operation Id: Bindings_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BindingResource> CreateOrUpdate(WaitUntil waitUntil, string bindingName, BindingResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bindingName, nameof(bindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _bindingResourceBindingsClientDiagnostics.CreateScope("BindingResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _bindingResourceBindingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<BindingResource>(new BindingResourceOperationSource(Client), _bindingResourceBindingsClientDiagnostics, Pipeline, _bindingResourceBindingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a Binding and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}
        /// Operation Id: Bindings_Get
        /// </summary>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> is null. </exception>
        public virtual async Task<Response<BindingResource>> GetAsync(string bindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bindingName, nameof(bindingName));

            using var scope = _bindingResourceBindingsClientDiagnostics.CreateScope("BindingResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _bindingResourceBindingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Binding and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}
        /// Operation Id: Bindings_Get
        /// </summary>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> is null. </exception>
        public virtual Response<BindingResource> Get(string bindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bindingName, nameof(bindingName));

            using var scope = _bindingResourceBindingsClientDiagnostics.CreateScope("BindingResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _bindingResourceBindingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in an App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings
        /// Operation Id: Bindings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BindingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BindingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BindingResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _bindingResourceBindingsClientDiagnostics.CreateScope("BindingResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _bindingResourceBindingsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BindingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BindingResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _bindingResourceBindingsClientDiagnostics.CreateScope("BindingResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _bindingResourceBindingsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BindingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Handles requests to list all resources in an App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings
        /// Operation Id: Bindings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BindingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BindingResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<BindingResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _bindingResourceBindingsClientDiagnostics.CreateScope("BindingResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _bindingResourceBindingsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BindingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BindingResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _bindingResourceBindingsClientDiagnostics.CreateScope("BindingResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _bindingResourceBindingsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BindingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}
        /// Operation Id: Bindings_Get
        /// </summary>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string bindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bindingName, nameof(bindingName));

            using var scope = _bindingResourceBindingsClientDiagnostics.CreateScope("BindingResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _bindingResourceBindingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}
        /// Operation Id: Bindings_Get
        /// </summary>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> is null. </exception>
        public virtual Response<bool> Exists(string bindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bindingName, nameof(bindingName));

            using var scope = _bindingResourceBindingsClientDiagnostics.CreateScope("BindingResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _bindingResourceBindingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, bindingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BindingResource> IEnumerable<BindingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BindingResource> IAsyncEnumerable<BindingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
