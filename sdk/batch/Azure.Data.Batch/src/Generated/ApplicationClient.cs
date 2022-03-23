// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Data.Batch
{
    /// <summary> The Application service client. </summary>
    public partial class ApplicationClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://batch.core.windows.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly string _batchUrl;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ApplicationClient for mocking. </summary>
        protected ApplicationClient()
        {
        }

        /// <summary> Initializes a new instance of ApplicationClient. </summary>
        /// <param name="batchUrl"> The base URL for all Azure Batch service requests. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="batchUrl"/> or <paramref name="credential"/> is null. </exception>
        public ApplicationClient(string batchUrl, TokenCredential credential, BatchServiceClientOptions options = null)
        {
            Argument.AssertNotNull(batchUrl, nameof(batchUrl));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new BatchServiceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _batchUrl = batchUrl;
            _apiVersion = options.Version;
        }

        /// <summary> This operation returns only Applications and versions that are available for use on Compute Nodes; that is, that can be used in an Package reference. For administrator information about Applications and versions that are not yet available to Compute Nodes, use the Azure portal or the Azure Resource Manager API. </summary>
        /// <param name="applicationId"> The ID of the Application. </param>
        /// <param name="timeout"> The maximum time that the server can spend processing the request, in seconds. The default is 30 seconds. </param>
        /// <param name="clientRequestId"> The caller-generated request identity, in the form of a GUID with no decoration such as curly braces, e.g. 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </param>
        /// <param name="returnClientRequestId"> Whether the server should return the client-request-id in the response. </param>
        /// <param name="ocpDate"> The time the request was issued. Client libraries typically set this to the current system clock time; set it explicitly if you are calling the REST API directly. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   displayName: string,
        ///   versions: [string]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   code: string,
        ///   message: {
        ///     lang: string,
        ///     value: string
        ///   },
        ///   values: [
        ///     {
        ///       key: string,
        ///       value: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetApplicationAsync(string applicationId, int? timeout = null, Guid? clientRequestId = null, bool? returnClientRequestId = null, DateTimeOffset? ocpDate = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = ClientDiagnostics.CreateScope("ApplicationClient.GetApplication");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetApplicationRequest(applicationId, timeout, clientRequestId, returnClientRequestId, ocpDate, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation returns only Applications and versions that are available for use on Compute Nodes; that is, that can be used in an Package reference. For administrator information about Applications and versions that are not yet available to Compute Nodes, use the Azure portal or the Azure Resource Manager API. </summary>
        /// <param name="applicationId"> The ID of the Application. </param>
        /// <param name="timeout"> The maximum time that the server can spend processing the request, in seconds. The default is 30 seconds. </param>
        /// <param name="clientRequestId"> The caller-generated request identity, in the form of a GUID with no decoration such as curly braces, e.g. 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </param>
        /// <param name="returnClientRequestId"> Whether the server should return the client-request-id in the response. </param>
        /// <param name="ocpDate"> The time the request was issued. Client libraries typically set this to the current system clock time; set it explicitly if you are calling the REST API directly. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   displayName: string,
        ///   versions: [string]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   code: string,
        ///   message: {
        ///     lang: string,
        ///     value: string
        ///   },
        ///   values: [
        ///     {
        ///       key: string,
        ///       value: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetApplication(string applicationId, int? timeout = null, Guid? clientRequestId = null, bool? returnClientRequestId = null, DateTimeOffset? ocpDate = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = ClientDiagnostics.CreateScope("ApplicationClient.GetApplication");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetApplicationRequest(applicationId, timeout, clientRequestId, returnClientRequestId, ocpDate, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation returns only Applications and versions that are available for use on Compute Nodes; that is, that can be used in an Package reference. For administrator information about applications and versions that are not yet available to Compute Nodes, use the Azure portal or the Azure Resource Manager API. </summary>
        /// <param name="maxResults"> The maximum number of items to return in the response. A maximum of 1000 applications can be returned. </param>
        /// <param name="timeout"> The maximum time that the server can spend processing the request, in seconds. The default is 30 seconds. </param>
        /// <param name="clientRequestId"> The caller-generated request identity, in the form of a GUID with no decoration such as curly braces, e.g. 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </param>
        /// <param name="returnClientRequestId"> Whether the server should return the client-request-id in the response. </param>
        /// <param name="ocpDate"> The time the request was issued. Client libraries typically set this to the current system clock time; set it explicitly if you are calling the REST API directly. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       id: string,
        ///       displayName: string,
        ///       versions: [string]
        ///     }
        ///   ],
        ///   odata.nextLink: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   code: string,
        ///   message: {
        ///     lang: string,
        ///     value: string
        ///   },
        ///   values: [
        ///     {
        ///       key: string,
        ///       value: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual AsyncPageable<BinaryData> GetApplicationsAsync(int? maxResults = null, int? timeout = null, Guid? clientRequestId = null, bool? returnClientRequestId = null, DateTimeOffset? ocpDate = null, RequestContext context = null)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, "ApplicationClient.GetApplications");
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetApplicationsRequest(maxResults, timeout, clientRequestId, returnClientRequestId, ocpDate, context)
                        : CreateGetApplicationsNextPageRequest(nextLink, maxResults, timeout, clientRequestId, returnClientRequestId, ocpDate, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "odata.nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> This operation returns only Applications and versions that are available for use on Compute Nodes; that is, that can be used in an Package reference. For administrator information about applications and versions that are not yet available to Compute Nodes, use the Azure portal or the Azure Resource Manager API. </summary>
        /// <param name="maxResults"> The maximum number of items to return in the response. A maximum of 1000 applications can be returned. </param>
        /// <param name="timeout"> The maximum time that the server can spend processing the request, in seconds. The default is 30 seconds. </param>
        /// <param name="clientRequestId"> The caller-generated request identity, in the form of a GUID with no decoration such as curly braces, e.g. 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </param>
        /// <param name="returnClientRequestId"> Whether the server should return the client-request-id in the response. </param>
        /// <param name="ocpDate"> The time the request was issued. Client libraries typically set this to the current system clock time; set it explicitly if you are calling the REST API directly. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       id: string,
        ///       displayName: string,
        ///       versions: [string]
        ///     }
        ///   ],
        ///   odata.nextLink: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   code: string,
        ///   message: {
        ///     lang: string,
        ///     value: string
        ///   },
        ///   values: [
        ///     {
        ///       key: string,
        ///       value: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Pageable<BinaryData> GetApplications(int? maxResults = null, int? timeout = null, Guid? clientRequestId = null, bool? returnClientRequestId = null, DateTimeOffset? ocpDate = null, RequestContext context = null)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, "ApplicationClient.GetApplications");
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetApplicationsRequest(maxResults, timeout, clientRequestId, returnClientRequestId, ocpDate, context)
                        : CreateGetApplicationsNextPageRequest(nextLink, maxResults, timeout, clientRequestId, returnClientRequestId, ocpDate, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "odata.nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateGetApplicationsRequest(int? maxResults, int? timeout, Guid? clientRequestId, bool? returnClientRequestId, DateTimeOffset? ocpDate, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_batchUrl, false);
            uri.AppendPath("/applications", false);
            if (maxResults != null)
            {
                uri.AppendQuery("maxresults", maxResults.Value, true);
            }
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            if (returnClientRequestId != null)
            {
                request.Headers.Add("return-client-request-id", returnClientRequestId.Value);
            }
            if (ocpDate != null)
            {
                request.Headers.Add("ocp-date", ocpDate.Value, "R");
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetApplicationRequest(string applicationId, int? timeout, Guid? clientRequestId, bool? returnClientRequestId, DateTimeOffset? ocpDate, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_batchUrl, false);
            uri.AppendPath("/applications/", false);
            uri.AppendPath(applicationId, true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            if (returnClientRequestId != null)
            {
                request.Headers.Add("return-client-request-id", returnClientRequestId.Value);
            }
            if (ocpDate != null)
            {
                request.Headers.Add("ocp-date", ocpDate.Value, "R");
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetApplicationsNextPageRequest(string nextLink, int? maxResults, int? timeout, Guid? clientRequestId, bool? returnClientRequestId, DateTimeOffset? ocpDate, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_batchUrl, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            if (returnClientRequestId != null)
            {
                request.Headers.Add("return-client-request-id", returnClientRequestId.Value);
            }
            if (ocpDate != null)
            {
                request.Headers.Add("ocp-date", ocpDate.Value, "R");
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
