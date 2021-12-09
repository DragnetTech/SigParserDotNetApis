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
    public interface ICompaniesApi
    {
        /// <summary>
        /// Fetch details about companies by the email domain. 
        /// </summary>
        /// <param name="lastmodifiedAfter">Use this to get a delta of all the changes since your query. Save the last \&quot;lastmodified\&quot; value.  This will not return companies with a status of Private, Ignored or Coworker.</param>
        /// <param name="take">How many records to return. The minimum count is 25. Maximum 250.</param>
        /// <param name="domain">Lookup a specific company by domain. Private companies are never returned but Coworker and Ignore accounts are. Domain names must be lowercase.</param>
        /// <returns>List&lt;DragnetTechSharedIPAASModelsCompanyOutputModel&gt;</returns>
        List<DragnetTechSharedIPAASModelsCompanyOutputModel> ApiCompaniesGet (long? lastmodifiedAfter, int? take, string domain);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CompaniesApi : ICompaniesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompaniesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CompaniesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CompaniesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CompaniesApi(String basePath)
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
        /// Fetch details about companies by the email domain. 
        /// </summary>
        /// <param name="lastmodifiedAfter">Use this to get a delta of all the changes since your query. Save the last \&quot;lastmodified\&quot; value.  This will not return companies with a status of Private, Ignored or Coworker.</param> 
        /// <param name="take">How many records to return. The minimum count is 25. Maximum 250.</param> 
        /// <param name="domain">Lookup a specific company by domain. Private companies are never returned but Coworker and Ignore accounts are. Domain names must be lowercase.</param> 
        /// <returns>List&lt;DragnetTechSharedIPAASModelsCompanyOutputModel&gt;</returns>            
        public List<DragnetTechSharedIPAASModelsCompanyOutputModel> ApiCompaniesGet (long? lastmodifiedAfter, int? take, string domain)
        {
            
    
            var path = "/api/Companies";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (lastmodifiedAfter != null) queryParams.Add("lastmodified_after", ApiClient.ParameterToString(lastmodifiedAfter)); // query parameter
 if (take != null) queryParams.Add("take", ApiClient.ParameterToString(take)); // query parameter
 if (domain != null) queryParams.Add("domain", ApiClient.ParameterToString(domain)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiCompaniesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiCompaniesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DragnetTechSharedIPAASModelsCompanyOutputModel>) ApiClient.Deserialize(response.Content, typeof(List<DragnetTechSharedIPAASModelsCompanyOutputModel>), response.Headers);
        }
    
    }
}
