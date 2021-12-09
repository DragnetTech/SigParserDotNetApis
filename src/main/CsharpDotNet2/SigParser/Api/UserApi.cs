using System;
using System.Collections.Generic;
using RestSharp;
using SigParser.Client;
using SigParser.Model;

namespace SigParser.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserApi
    {
        /// <summary>
        /// Revoke the data access API key for this request. Doesn&#39;t revoke the email parsing API key. OAuth providers should try to call this when disconnecting a connection if possible. 
        /// </summary>
        /// <returns>IPaasAPIControllersUserControllerReturnMe</returns>
        IPaasAPIControllersUserControllerReturnMe ApiUserInvalidateDelete ();
        /// <summary>
        /// Get the User Information [ Username , EnterpriseId ] 
        /// </summary>
        /// <returns>IPaasAPIControllersUserControllerReturnMe</returns>
        IPaasAPIControllersUserControllerReturnMe ApiUserMeGet ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserApi : IUserApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Revoke the data access API key for this request. Doesn&#39;t revoke the email parsing API key. OAuth providers should try to call this when disconnecting a connection if possible. 
        /// </summary>
        /// <returns>IPaasAPIControllersUserControllerReturnMe</returns>            
        public IPaasAPIControllersUserControllerReturnMe ApiUserInvalidateDelete ()
        {
            
    
            var path = "/api/User/Invalidate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiUserInvalidateDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiUserInvalidateDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIControllersUserControllerReturnMe) ApiClient.Deserialize(response.Content, typeof(IPaasAPIControllersUserControllerReturnMe), response.Headers);
        }
    
        /// <summary>
        /// Get the User Information [ Username , EnterpriseId ] 
        /// </summary>
        /// <returns>IPaasAPIControllersUserControllerReturnMe</returns>            
        public IPaasAPIControllersUserControllerReturnMe ApiUserMeGet ()
        {
            
    
            var path = "/api/User/Me";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiUserMeGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiUserMeGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIControllersUserControllerReturnMe) ApiClient.Deserialize(response.Content, typeof(IPaasAPIControllersUserControllerReturnMe), response.Headers);
        }
    
    }
}
