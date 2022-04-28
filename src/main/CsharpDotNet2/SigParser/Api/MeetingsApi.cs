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
    public interface IMeetingsApi
    {
        /// <summary>
        /// Fetch distinct meetings across all the mailboxes. If the same meeting is found in multiple mailboxes then you&#39;ll only get one reference to it. 
        /// </summary>
        /// <param name="dateMax">Fetch meetings after this date.</param>
        /// <param name="dateMin">Fetch meetings before this date.</param>
        /// <param name="take">Number of records to return. Default 100. Minimum is 25. Max 250.</param>
        /// <param name="page">Page of results. First page is 1. Default 1.</param>
        /// <param name="emailaddress">Find meetings with an attedee with this email address. This will return all meetings they accepted or declined.</param>
        /// <param name="lastmodifiedAfter">Delta feed history date parameter. Keep track of the last value you saw. For the first request use 0 for the modified_after value.  When using this parameter the results are always in the order they were ingested in, not in the order of the emails.</param>
        /// <param name="icaluid">iCalUID for the meeting to search for. Will return the best meeting record for this iCalUID across all the mailboxes.</param>
        /// <param name="domain">Fetch meetings by the email domain. Can only use \&quot;take\&quot; and \&quot;page\&quot; with this parameter. Doesn&#39;t work for free email providers like gmail.com or yahoo.com along with many other non-corporate domains.</param>
        /// <returns>List&lt;DragnetTechSharedIPAASModelsMeetingOutputModel&gt;</returns>
        List<DragnetTechSharedIPAASModelsMeetingOutputModel> ApiMeetingsDistinctGet (DateTime? dateMax, DateTime? dateMin, int? take, int? page, string emailaddress, long? lastmodifiedAfter, string icaluid, string domain);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MeetingsApi : IMeetingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MeetingsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MeetingsApi(String basePath)
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
        /// Fetch distinct meetings across all the mailboxes. If the same meeting is found in multiple mailboxes then you&#39;ll only get one reference to it. 
        /// </summary>
        /// <param name="dateMax">Fetch meetings after this date.</param> 
        /// <param name="dateMin">Fetch meetings before this date.</param> 
        /// <param name="take">Number of records to return. Default 100. Minimum is 25. Max 250.</param> 
        /// <param name="page">Page of results. First page is 1. Default 1.</param> 
        /// <param name="emailaddress">Find meetings with an attedee with this email address. This will return all meetings they accepted or declined.</param> 
        /// <param name="lastmodifiedAfter">Delta feed history date parameter. Keep track of the last value you saw. For the first request use 0 for the modified_after value.  When using this parameter the results are always in the order they were ingested in, not in the order of the emails.</param> 
        /// <param name="icaluid">iCalUID for the meeting to search for. Will return the best meeting record for this iCalUID across all the mailboxes.</param> 
        /// <param name="domain">Fetch meetings by the email domain. Can only use \&quot;take\&quot; and \&quot;page\&quot; with this parameter. Doesn&#39;t work for free email providers like gmail.com or yahoo.com along with many other non-corporate domains.</param> 
        /// <returns>List&lt;DragnetTechSharedIPAASModelsMeetingOutputModel&gt;</returns>            
        public List<DragnetTechSharedIPAASModelsMeetingOutputModel> ApiMeetingsDistinctGet (DateTime? dateMax, DateTime? dateMin, int? take, int? page, string emailaddress, long? lastmodifiedAfter, string icaluid, string domain)
        {
            
    
            var path = "/api/Meetings/Distinct";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (dateMax != null) queryParams.Add("date_max", ApiClient.ParameterToString(dateMax)); // query parameter
 if (dateMin != null) queryParams.Add("date_min", ApiClient.ParameterToString(dateMin)); // query parameter
 if (take != null) queryParams.Add("take", ApiClient.ParameterToString(take)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (emailaddress != null) queryParams.Add("emailaddress", ApiClient.ParameterToString(emailaddress)); // query parameter
 if (lastmodifiedAfter != null) queryParams.Add("lastmodified_after", ApiClient.ParameterToString(lastmodifiedAfter)); // query parameter
 if (icaluid != null) queryParams.Add("icaluid", ApiClient.ParameterToString(icaluid)); // query parameter
 if (domain != null) queryParams.Add("domain", ApiClient.ParameterToString(domain)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiMeetingsDistinctGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiMeetingsDistinctGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DragnetTechSharedIPAASModelsMeetingOutputModel>) ApiClient.Deserialize(response.Content, typeof(List<DragnetTechSharedIPAASModelsMeetingOutputModel>), response.Headers);
        }
    
    }
}
