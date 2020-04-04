// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.AI.FormRecognizer.Custom;
using Azure.AI.FormRecognizer.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.FormRecognizer
{
    internal partial class ServiceClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal ServiceRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ServiceClient for mocking. </summary>
        protected ServiceClient()
        {
        }
        /// <summary> Initializes a new instance of ServiceClient. </summary>
        internal ServiceClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint)
        {
            RestClient = new ServiceRestClient(clientDiagnostics, pipeline, endpoint);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Create and train a custom model. The request must include a source parameter that is either an externally accessible Azure storage blob container Uri (preferably a Shared Access Signature Uri) or valid path to a data folder in a locally mounted drive. When local paths are specified, they must follow the Linux/Unix path format and be an absolute path rooted to the input mount configuration setting value e.g., if &apos;{Mounts:Input}&apos; configuration setting value is &apos;/input&apos; then a valid source path would be &apos;/input/contosodataset&apos;. All data to be trained is expected to be under the source folder or sub folders under it. Models are trained using documents that are of the following content type - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos;, &apos;image/tiff&apos;. Other type of content is ignored. </summary>
        /// <param name="trainRequest"> Training request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> TrainCustomModelAsyncAsync(TrainRequest_internal trainRequest, CancellationToken cancellationToken = default)
        {
            return (await RestClient.TrainCustomModelAsyncAsync(trainRequest, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Create and train a custom model. The request must include a source parameter that is either an externally accessible Azure storage blob container Uri (preferably a Shared Access Signature Uri) or valid path to a data folder in a locally mounted drive. When local paths are specified, they must follow the Linux/Unix path format and be an absolute path rooted to the input mount configuration setting value e.g., if &apos;{Mounts:Input}&apos; configuration setting value is &apos;/input&apos; then a valid source path would be &apos;/input/contosodataset&apos;. All data to be trained is expected to be under the source folder or sub folders under it. Models are trained using documents that are of the following content type - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos;, &apos;image/tiff&apos;. Other type of content is ignored. </summary>
        /// <param name="trainRequest"> Training request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response TrainCustomModelAsync(TrainRequest_internal trainRequest, CancellationToken cancellationToken = default)
        {
            return RestClient.TrainCustomModelAsync(trainRequest, cancellationToken).GetRawResponse();
        }

        /// <summary> Get detailed information about a custom model. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="includeKeys"> Include list of extracted keys in model information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Model_internal>> GetCustomModelAsync(Guid modelId, bool? includeKeys = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetCustomModelAsync(modelId, includeKeys, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Get detailed information about a custom model. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="includeKeys"> Include list of extracted keys in model information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Model_internal> GetCustomModel(Guid modelId, bool? includeKeys = null, CancellationToken cancellationToken = default)
        {
            return RestClient.GetCustomModel(modelId, includeKeys, cancellationToken);
        }

        /// <summary> Mark model for deletion. Model artifacts will be permanently removed within a predetermined period. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteCustomModelAsync(Guid modelId, CancellationToken cancellationToken = default)
        {
            return await RestClient.DeleteCustomModelAsync(modelId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Mark model for deletion. Model artifacts will be permanently removed within a predetermined period. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteCustomModel(Guid modelId, CancellationToken cancellationToken = default)
        {
            return RestClient.DeleteCustomModel(modelId, cancellationToken);
        }

        /// <summary> Extract key-value pairs, tables, and semantic values from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeWithCustomModelAsync(Guid modelId, ContentType contentType, Stream fileStream, bool? includeTextDetails = null, CancellationToken cancellationToken = default)
        {
            return (await RestClient.AnalyzeWithCustomModelAsync(modelId, contentType, fileStream, includeTextDetails, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Extract key-value pairs, tables, and semantic values from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeWithCustomModel(Guid modelId, ContentType contentType, Stream fileStream, bool? includeTextDetails = null, CancellationToken cancellationToken = default)
        {
            return RestClient.AnalyzeWithCustomModel(modelId, contentType, fileStream, includeTextDetails, cancellationToken).GetRawResponse();
        }

        /// <summary> Extract key-value pairs, tables, and semantic values from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeWithCustomModelAsync(Guid modelId, bool? includeTextDetails = null, SourcePath_internal fileStream = null, CancellationToken cancellationToken = default)
        {
            return (await RestClient.AnalyzeWithCustomModelAsync(modelId, includeTextDetails, fileStream, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Extract key-value pairs, tables, and semantic values from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeWithCustomModel(Guid modelId, bool? includeTextDetails = null, SourcePath_internal fileStream = null, CancellationToken cancellationToken = default)
        {
            return RestClient.AnalyzeWithCustomModel(modelId, includeTextDetails, fileStream, cancellationToken).GetRawResponse();
        }

        /// <summary> Obtain current status and the result of the analyze form operation. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="resultId"> Analyze operation result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AnalyzeOperationResult_internal>> GetAnalyzeFormResultAsync(Guid modelId, Guid resultId, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAnalyzeFormResultAsync(modelId, resultId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Obtain current status and the result of the analyze form operation. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="resultId"> Analyze operation result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AnalyzeOperationResult_internal> GetAnalyzeFormResult(Guid modelId, Guid resultId, CancellationToken cancellationToken = default)
        {
            return RestClient.GetAnalyzeFormResult(modelId, resultId, cancellationToken);
        }

        /// <summary> Extract field text and semantic values from a given receipt document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeReceiptAsyncAsync(ContentType contentType, Stream fileStream, bool? includeTextDetails = null, CancellationToken cancellationToken = default)
        {
            return (await RestClient.AnalyzeReceiptAsyncAsync(contentType, fileStream, includeTextDetails, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Extract field text and semantic values from a given receipt document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeReceiptAsync(ContentType contentType, Stream fileStream, bool? includeTextDetails = null, CancellationToken cancellationToken = default)
        {
            return RestClient.AnalyzeReceiptAsync(contentType, fileStream, includeTextDetails, cancellationToken).GetRawResponse();
        }

        /// <summary> Extract field text and semantic values from a given receipt document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeReceiptAsyncAsync(bool? includeTextDetails = null, SourcePath_internal fileStream = null, CancellationToken cancellationToken = default)
        {
            return (await RestClient.AnalyzeReceiptAsyncAsync(includeTextDetails, fileStream, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Extract field text and semantic values from a given receipt document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeReceiptAsync(bool? includeTextDetails = null, SourcePath_internal fileStream = null, CancellationToken cancellationToken = default)
        {
            return RestClient.AnalyzeReceiptAsync(includeTextDetails, fileStream, cancellationToken).GetRawResponse();
        }

        /// <summary> Track the progress and obtain the result of the analyze receipt operation. </summary>
        /// <param name="resultId"> Analyze operation result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AnalyzeOperationResult_internal>> GetAnalyzeReceiptResultAsync(Guid resultId, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAnalyzeReceiptResultAsync(resultId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Track the progress and obtain the result of the analyze receipt operation. </summary>
        /// <param name="resultId"> Analyze operation result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AnalyzeOperationResult_internal> GetAnalyzeReceiptResult(Guid resultId, CancellationToken cancellationToken = default)
        {
            return RestClient.GetAnalyzeReceiptResult(resultId, cancellationToken);
        }

        /// <summary> Extract text and layout information from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeLayoutAsyncAsync(ContentType contentType, Stream fileStream, CancellationToken cancellationToken = default)
        {
            return (await RestClient.AnalyzeLayoutAsyncAsync(contentType, fileStream, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Extract text and layout information from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeLayoutAsync(ContentType contentType, Stream fileStream, CancellationToken cancellationToken = default)
        {
            return RestClient.AnalyzeLayoutAsync(contentType, fileStream, cancellationToken).GetRawResponse();
        }

        /// <summary> Extract text and layout information from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeLayoutAsyncAsync(SourcePath_internal fileStream = null, CancellationToken cancellationToken = default)
        {
            return (await RestClient.AnalyzeLayoutAsyncAsync(fileStream, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Extract text and layout information from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeLayoutAsync(SourcePath_internal fileStream = null, CancellationToken cancellationToken = default)
        {
            return RestClient.AnalyzeLayoutAsync(fileStream, cancellationToken).GetRawResponse();
        }

        /// <summary> Track the progress and obtain the result of the analyze layout operation. </summary>
        /// <param name="resultId"> Analyze operation result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AnalyzeOperationResult_internal>> GetAnalyzeLayoutResultAsync(Guid resultId, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAnalyzeLayoutResultAsync(resultId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Track the progress and obtain the result of the analyze layout operation. </summary>
        /// <param name="resultId"> Analyze operation result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AnalyzeOperationResult_internal> GetAnalyzeLayoutResult(Guid resultId, CancellationToken cancellationToken = default)
        {
            return RestClient.GetAnalyzeLayoutResult(resultId, cancellationToken);
        }

        /// <summary> Get information about all custom models. </summary>
        /// <param name="op"> Specify whether to return summary or full list of models. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ModelInfo_internal> GetCustomModelsAsync(GetModelOptions? op = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ModelInfo_internal>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.GetCustomModelsAsync(op, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.ModelList, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<ModelInfo_internal>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.GetCustomModelsNextPageAsync(nextLink, op, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.ModelList, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get information about all custom models. </summary>
        /// <param name="op"> Specify whether to return summary or full list of models. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ModelInfo_internal> GetCustomModels(GetModelOptions? op = null, CancellationToken cancellationToken = default)
        {
            Page<ModelInfo_internal> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.GetCustomModels(op, cancellationToken);
                return Page.FromValues(response.Value.ModelList, response.Value.NextLink, response.GetRawResponse());
            }
            Page<ModelInfo_internal> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.GetCustomModelsNextPage(nextLink, op, cancellationToken);
                return Page.FromValues(response.Value.ModelList, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
