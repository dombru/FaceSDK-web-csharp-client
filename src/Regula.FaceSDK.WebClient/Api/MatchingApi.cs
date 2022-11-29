/*
 * Regula FaceSDK Web API
 *
 * Regula FaceSDK Web API # Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 4.1.3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using Regula.FaceSDK.WebClient.Client;
using Regula.FaceSDK.WebClient.Model;

namespace Regula.FaceSDK.WebClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMatchingApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Detect facial coordinates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <returns>DetectResponse</returns>
        DetectResponse Detect (DetectRequest detectRequest, string xRequestID = default(string));

        /// <summary>
        /// Detect facial coordinates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <returns>ApiResponse of DetectResponse</returns>
        ApiResponse<DetectResponse> DetectWithHttpInfo (DetectRequest detectRequest, string xRequestID = default(string));
        /// <summary>
        /// Compare provided face images in all combinations and return the similarity score for each pair.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <returns>MatchResponse</returns>
        MatchResponse Match (MatchRequest matchRequest, string xRequestID = default(string));

        /// <summary>
        /// Compare provided face images in all combinations and return the similarity score for each pair.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <returns>ApiResponse of MatchResponse</returns>
        ApiResponse<MatchResponse> MatchWithHttpInfo (MatchRequest matchRequest, string xRequestID = default(string));
        /// <summary>
        /// Match and Search in one request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchAndSearchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <returns>MatchAndSearchResponse</returns>
        MatchAndSearchResponse MatchAndSearch (MatchAndSearchRequest matchAndSearchRequest, string xRequestID = default(string));

        /// <summary>
        /// Match and Search in one request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchAndSearchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <returns>ApiResponse of MatchAndSearchResponse</returns>
        ApiResponse<MatchAndSearchResponse> MatchAndSearchWithHttpInfo (MatchAndSearchRequest matchAndSearchRequest, string xRequestID = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Detect facial coordinates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of DetectResponse</returns>
        System.Threading.Tasks.Task<DetectResponse> DetectAsync (DetectRequest detectRequest, string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Detect facial coordinates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (DetectResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DetectResponse>> DetectWithHttpInfoAsync (DetectRequest detectRequest, string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Compare provided face images in all combinations and return the similarity score for each pair.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of MatchResponse</returns>
        System.Threading.Tasks.Task<MatchResponse> MatchAsync (MatchRequest matchRequest, string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Compare provided face images in all combinations and return the similarity score for each pair.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (MatchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MatchResponse>> MatchWithHttpInfoAsync (MatchRequest matchRequest, string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Match and Search in one request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchAndSearchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of MatchAndSearchResponse</returns>
        System.Threading.Tasks.Task<MatchAndSearchResponse> MatchAndSearchAsync (MatchAndSearchRequest matchAndSearchRequest, string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Match and Search in one request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchAndSearchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (MatchAndSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MatchAndSearchResponse>> MatchAndSearchWithHttpInfoAsync (MatchAndSearchRequest matchAndSearchRequest, string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MatchingApi : IMatchingApi
    {
        private Regula.FaceSDK.WebClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MatchingApi(String basePath)
        {
            this.Configuration = new Regula.FaceSDK.WebClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Regula.FaceSDK.WebClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchingApi"/> class
        /// </summary>
        /// <returns></returns>
        public MatchingApi()
        {
            this.Configuration = Regula.FaceSDK.WebClient.Client.Configuration.Default;

            ExceptionFactory = Regula.FaceSDK.WebClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MatchingApi(Regula.FaceSDK.WebClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Regula.FaceSDK.WebClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Regula.FaceSDK.WebClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Regula.FaceSDK.WebClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Regula.FaceSDK.WebClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Detect facial coordinates 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <returns>DetectResponse</returns>
        public DetectResponse Detect (DetectRequest detectRequest, string xRequestID = default(string))
        {
             ApiResponse<DetectResponse> localVarResponse = DetectWithHttpInfo(detectRequest, xRequestID);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Detect facial coordinates 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <returns>ApiResponse of DetectResponse</returns>
        public ApiResponse<DetectResponse> DetectWithHttpInfo (DetectRequest detectRequest, string xRequestID = default(string))
        {
            // verify the required parameter 'detectRequest' is set
            if (detectRequest == null)
                throw new ApiException(400, "Missing required parameter 'detectRequest' when calling MatchingApi->Detect");

            var localVarPath = "/api/detect";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xRequestID != null) localVarHeaderParams.Add("X-RequestID", this.Configuration.ApiClient.ParameterToString(xRequestID)); // header parameter
            if (detectRequest != null && detectRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(detectRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = detectRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Detect", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DetectResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DetectResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DetectResponse)));
        }

        /// <summary>
        /// Detect facial coordinates 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of DetectResponse</returns>
        public async System.Threading.Tasks.Task<DetectResponse> DetectAsync (DetectRequest detectRequest, string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<DetectResponse> localVarResponse = await DetectWithHttpInfoAsync(detectRequest, xRequestID, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Detect facial coordinates 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (DetectResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DetectResponse>> DetectWithHttpInfoAsync (DetectRequest detectRequest, string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'detectRequest' is set
            if (detectRequest == null)
                throw new ApiException(400, "Missing required parameter 'detectRequest' when calling MatchingApi->Detect");

            var localVarPath = "/api/detect";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xRequestID != null) localVarHeaderParams.Add("X-RequestID", this.Configuration.ApiClient.ParameterToString(xRequestID)); // header parameter
            if (detectRequest != null && detectRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(detectRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = detectRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Detect", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DetectResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DetectResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DetectResponse)));
        }

        /// <summary>
        /// Compare provided face images in all combinations and return the similarity score for each pair. 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <returns>MatchResponse</returns>
        public MatchResponse Match (MatchRequest matchRequest, string xRequestID = default(string))
        {
             ApiResponse<MatchResponse> localVarResponse = MatchWithHttpInfo(matchRequest, xRequestID);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Compare provided face images in all combinations and return the similarity score for each pair. 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <returns>ApiResponse of MatchResponse</returns>
        public ApiResponse<MatchResponse> MatchWithHttpInfo (MatchRequest matchRequest, string xRequestID = default(string))
        {
            // verify the required parameter 'matchRequest' is set
            if (matchRequest == null)
                throw new ApiException(400, "Missing required parameter 'matchRequest' when calling MatchingApi->Match");

            var localVarPath = "/api/match";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xRequestID != null) localVarHeaderParams.Add("X-RequestID", this.Configuration.ApiClient.ParameterToString(xRequestID)); // header parameter
            if (matchRequest != null && matchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(matchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = matchRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Match", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MatchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MatchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MatchResponse)));
        }

        /// <summary>
        /// Compare provided face images in all combinations and return the similarity score for each pair. 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of MatchResponse</returns>
        public async System.Threading.Tasks.Task<MatchResponse> MatchAsync (MatchRequest matchRequest, string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<MatchResponse> localVarResponse = await MatchWithHttpInfoAsync(matchRequest, xRequestID, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Compare provided face images in all combinations and return the similarity score for each pair. 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (MatchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MatchResponse>> MatchWithHttpInfoAsync (MatchRequest matchRequest, string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'matchRequest' is set
            if (matchRequest == null)
                throw new ApiException(400, "Missing required parameter 'matchRequest' when calling MatchingApi->Match");

            var localVarPath = "/api/match";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xRequestID != null) localVarHeaderParams.Add("X-RequestID", this.Configuration.ApiClient.ParameterToString(xRequestID)); // header parameter
            if (matchRequest != null && matchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(matchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = matchRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Match", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MatchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MatchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MatchResponse)));
        }

        /// <summary>
        /// Match and Search in one request 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchAndSearchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <returns>MatchAndSearchResponse</returns>
        public MatchAndSearchResponse MatchAndSearch (MatchAndSearchRequest matchAndSearchRequest, string xRequestID = default(string))
        {
             ApiResponse<MatchAndSearchResponse> localVarResponse = MatchAndSearchWithHttpInfo(matchAndSearchRequest, xRequestID);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Match and Search in one request 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchAndSearchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <returns>ApiResponse of MatchAndSearchResponse</returns>
        public ApiResponse<MatchAndSearchResponse> MatchAndSearchWithHttpInfo (MatchAndSearchRequest matchAndSearchRequest, string xRequestID = default(string))
        {
            // verify the required parameter 'matchAndSearchRequest' is set
            if (matchAndSearchRequest == null)
                throw new ApiException(400, "Missing required parameter 'matchAndSearchRequest' when calling MatchingApi->MatchAndSearch");

            var localVarPath = "/api/match_and_search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xRequestID != null) localVarHeaderParams.Add("X-RequestID", this.Configuration.ApiClient.ParameterToString(xRequestID)); // header parameter
            if (matchAndSearchRequest != null && matchAndSearchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(matchAndSearchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = matchAndSearchRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MatchAndSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MatchAndSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MatchAndSearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MatchAndSearchResponse)));
        }

        /// <summary>
        /// Match and Search in one request 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchAndSearchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of MatchAndSearchResponse</returns>
        public async System.Threading.Tasks.Task<MatchAndSearchResponse> MatchAndSearchAsync (MatchAndSearchRequest matchAndSearchRequest, string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<MatchAndSearchResponse> localVarResponse = await MatchAndSearchWithHttpInfoAsync(matchAndSearchRequest, xRequestID, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Match and Search in one request 
        /// </summary>
        /// <exception cref="Regula.FaceSDK.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="matchAndSearchRequest"></param>
        /// <param name="xRequestID"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (MatchAndSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MatchAndSearchResponse>> MatchAndSearchWithHttpInfoAsync (MatchAndSearchRequest matchAndSearchRequest, string xRequestID = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'matchAndSearchRequest' is set
            if (matchAndSearchRequest == null)
                throw new ApiException(400, "Missing required parameter 'matchAndSearchRequest' when calling MatchingApi->MatchAndSearch");

            var localVarPath = "/api/match_and_search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xRequestID != null) localVarHeaderParams.Add("X-RequestID", this.Configuration.ApiClient.ParameterToString(xRequestID)); // header parameter
            if (matchAndSearchRequest != null && matchAndSearchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(matchAndSearchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = matchAndSearchRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MatchAndSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MatchAndSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MatchAndSearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MatchAndSearchResponse)));
        }

    }
}
