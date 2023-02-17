/* 
 * bSDD API prototype
 *
 * API to access the buildingSMART Data Dictionary
 *
 * OpenAPI spec version: v1
 * Contact: bsdd_support@buildingsmart.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IPropertyApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Property details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Namespace URI of the property, e.g. http://identifier.buildingsmart.org/uri/buildingsmart/ifc-4.3/prop/AirConditioning</param>
        /// <param name="languageCode">Language Code (optional)</param>
        /// <returns>PropertyContractV2</returns>
        PropertyContractV2 ApiPropertyV2Get (string namespaceUri, string languageCode = null);

        /// <summary>
        /// Get Property details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Namespace URI of the property, e.g. http://identifier.buildingsmart.org/uri/buildingsmart/ifc-4.3/prop/AirConditioning</param>
        /// <param name="languageCode">Language Code (optional)</param>
        /// <returns>ApiResponse of PropertyContractV2</returns>
        ApiResponse<PropertyContractV2> ApiPropertyV2GetWithHttpInfo (string namespaceUri, string languageCode = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Property details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Namespace URI of the property, e.g. http://identifier.buildingsmart.org/uri/buildingsmart/ifc-4.3/prop/AirConditioning</param>
        /// <param name="languageCode">Language Code (optional)</param>
        /// <returns>Task of PropertyContractV2</returns>
        System.Threading.Tasks.Task<PropertyContractV2> ApiPropertyV2GetAsync (string namespaceUri, string languageCode = null);

        /// <summary>
        /// Get Property details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Namespace URI of the property, e.g. http://identifier.buildingsmart.org/uri/buildingsmart/ifc-4.3/prop/AirConditioning</param>
        /// <param name="languageCode">Language Code (optional)</param>
        /// <returns>Task of ApiResponse (PropertyContractV2)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropertyContractV2>> ApiPropertyV2GetAsyncWithHttpInfo (string namespaceUri, string languageCode = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class PropertyApi : IPropertyApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PropertyApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyApi"/> class
        /// </summary>
        /// <returns></returns>
        public PropertyApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PropertyApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        /// Get Property details 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Namespace URI of the property, e.g. http://identifier.buildingsmart.org/uri/buildingsmart/ifc-4.3/prop/AirConditioning</param>
        /// <param name="languageCode">Language Code (optional)</param>
        /// <returns>PropertyContractV2</returns>
        public PropertyContractV2 ApiPropertyV2Get (string namespaceUri, string languageCode = null)
        {
             ApiResponse<PropertyContractV2> localVarResponse = ApiPropertyV2GetWithHttpInfo(namespaceUri, languageCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Property details 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Namespace URI of the property, e.g. http://identifier.buildingsmart.org/uri/buildingsmart/ifc-4.3/prop/AirConditioning</param>
        /// <param name="languageCode">Language Code (optional)</param>
        /// <returns>ApiResponse of PropertyContractV2</returns>
        public ApiResponse< PropertyContractV2 > ApiPropertyV2GetWithHttpInfo (string namespaceUri, string languageCode = null)
        {
            // verify the required parameter 'namespaceUri' is set
            if (namespaceUri == null)
                throw new ApiException(400, "Missing required parameter 'namespaceUri' when calling PropertyApi->ApiPropertyV2Get");

            var localVarPath = "/api/Property/v2";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (namespaceUri != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "namespaceUri", namespaceUri)); // query parameter
            if (languageCode != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "languageCode", languageCode)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiPropertyV2Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PropertyContractV2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PropertyContractV2) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyContractV2)));
        }

        /// <summary>
        /// Get Property details 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Namespace URI of the property, e.g. http://identifier.buildingsmart.org/uri/buildingsmart/ifc-4.3/prop/AirConditioning</param>
        /// <param name="languageCode">Language Code (optional)</param>
        /// <returns>Task of PropertyContractV2</returns>
        public async System.Threading.Tasks.Task<PropertyContractV2> ApiPropertyV2GetAsync (string namespaceUri, string languageCode = null)
        {
             ApiResponse<PropertyContractV2> localVarResponse = await ApiPropertyV2GetAsyncWithHttpInfo(namespaceUri, languageCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Property details 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Namespace URI of the property, e.g. http://identifier.buildingsmart.org/uri/buildingsmart/ifc-4.3/prop/AirConditioning</param>
        /// <param name="languageCode">Language Code (optional)</param>
        /// <returns>Task of ApiResponse (PropertyContractV2)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropertyContractV2>> ApiPropertyV2GetAsyncWithHttpInfo (string namespaceUri, string languageCode = null)
        {
            // verify the required parameter 'namespaceUri' is set
            if (namespaceUri == null)
                throw new ApiException(400, "Missing required parameter 'namespaceUri' when calling PropertyApi->ApiPropertyV2Get");

            var localVarPath = "/api/Property/v2";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (namespaceUri != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "namespaceUri", namespaceUri)); // query parameter
            if (languageCode != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "languageCode", languageCode)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiPropertyV2Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PropertyContractV2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PropertyContractV2) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyContractV2)));
        }

    }
}