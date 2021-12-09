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
    public interface IEmailsApi
    {
        /// <summary>
        /// Fetch distinct emails across all the mailboxes. If the same emails is found in 10 mailboxes then only one instance of it will be returned. Primary Key  - -- -- -- -- -- -- -- -- -- -- -                Unlike meetings, emails don&#39;t have a unique identifier like iCalUID that can be used. Instead you should generate a unique string to represent the ID of the email by joining them all together. Or you could make a table with a 4 column primary key.                - date  - from - email address of the sender  - subject - Hash this so you get a consistent length if length matters.  - to_and_cc_hash - A hash value of the concatenated email addresses in the To and CC fields.                That will generate a unique row per email. This structure works well because you can query emails by date range. If you don&#39;t want to do multiple columns you could just combine all of these into one text field.     Delta Request  - -- -- -- -- -- -- -- -- -- --                Use the **ingested_after** parameter to request the last max **ingestion_key** seen.                 The **ingestion_key** is just a timestamp value and isn&#39;t the primary key. This can change for an email if a mailbox is removed from SigParser and another email has to take it&#39;s place.                 Maximum 250 emails per request  - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -                You are limited to requesting 250 email records per request. If you need more than 250 then you&#39;ll need to use the **Delta request** pattern to fetch emails in batches.
        /// </summary>
        /// <param name="ingestedAfter">Delta feed history date parameter. Keep track of the last value you saw. For the first request use 0 for the ingested_after value.  When using this parameter the results are always in the order they were ingested in, not in the order of the emails.</param>
        /// <param name="take">Number of records to return. Default 100. Minimum is 25. Max 250.</param>
        /// <param name="page">Page of results. First page is 1. Default 1.</param>
        /// <param name="emailaddress">Fetch emails for a specific contact.   Emails are always in descending order. Use \&quot;take\&quot; and \&quot;page\&quot; to navigate thru the pages of emails.</param>
        /// <param name="id">ID of the message to retrieve.</param>
        /// <param name="domain">Fetch emails by the email domain. Can only use \&quot;take\&quot; and \&quot;page\&quot; with this parameter. Doesn&#39;t work for free email providers like gmail.com or yahoo.com along with many other non-corporate domains.</param>
        /// <returns>List&lt;DragnetTechSharedIPAASModelsEmailOutputModel&gt;</returns>
        List<DragnetTechSharedIPAASModelsEmailOutputModel> ApiEmailsDistinctGet (long? ingestedAfter, int? take, int? page, string emailaddress, Guid? id, string domain);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EmailsApi : IEmailsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EmailsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailsApi(String basePath)
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
        /// Fetch distinct emails across all the mailboxes. If the same emails is found in 10 mailboxes then only one instance of it will be returned. Primary Key  - -- -- -- -- -- -- -- -- -- -- -                Unlike meetings, emails don&#39;t have a unique identifier like iCalUID that can be used. Instead you should generate a unique string to represent the ID of the email by joining them all together. Or you could make a table with a 4 column primary key.                - date  - from - email address of the sender  - subject - Hash this so you get a consistent length if length matters.  - to_and_cc_hash - A hash value of the concatenated email addresses in the To and CC fields.                That will generate a unique row per email. This structure works well because you can query emails by date range. If you don&#39;t want to do multiple columns you could just combine all of these into one text field.     Delta Request  - -- -- -- -- -- -- -- -- -- --                Use the **ingested_after** parameter to request the last max **ingestion_key** seen.                 The **ingestion_key** is just a timestamp value and isn&#39;t the primary key. This can change for an email if a mailbox is removed from SigParser and another email has to take it&#39;s place.                 Maximum 250 emails per request  - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -                You are limited to requesting 250 email records per request. If you need more than 250 then you&#39;ll need to use the **Delta request** pattern to fetch emails in batches.
        /// </summary>
        /// <param name="ingestedAfter">Delta feed history date parameter. Keep track of the last value you saw. For the first request use 0 for the ingested_after value.  When using this parameter the results are always in the order they were ingested in, not in the order of the emails.</param> 
        /// <param name="take">Number of records to return. Default 100. Minimum is 25. Max 250.</param> 
        /// <param name="page">Page of results. First page is 1. Default 1.</param> 
        /// <param name="emailaddress">Fetch emails for a specific contact.   Emails are always in descending order. Use \&quot;take\&quot; and \&quot;page\&quot; to navigate thru the pages of emails.</param> 
        /// <param name="id">ID of the message to retrieve.</param> 
        /// <param name="domain">Fetch emails by the email domain. Can only use \&quot;take\&quot; and \&quot;page\&quot; with this parameter. Doesn&#39;t work for free email providers like gmail.com or yahoo.com along with many other non-corporate domains.</param> 
        /// <returns>List&lt;DragnetTechSharedIPAASModelsEmailOutputModel&gt;</returns>            
        public List<DragnetTechSharedIPAASModelsEmailOutputModel> ApiEmailsDistinctGet (long? ingestedAfter = null, int? take = null, int? page = null, string emailaddress = null, Guid? id = null, string domain = null)
        {
            
    
            var path = "/api/Emails/Distinct";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ingestedAfter != null) queryParams.Add("ingested_after", ApiClient.ParameterToString(ingestedAfter)); // query parameter
 if (take != null) queryParams.Add("take", ApiClient.ParameterToString(take)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (emailaddress != null) queryParams.Add("emailaddress", ApiClient.ParameterToString(emailaddress)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (domain != null) queryParams.Add("domain", ApiClient.ParameterToString(domain)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEmailsDistinctGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEmailsDistinctGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DragnetTechSharedIPAASModelsEmailOutputModel>) ApiClient.Deserialize(response.Content, typeof(List<DragnetTechSharedIPAASModelsEmailOutputModel>), response.Headers);
        }
    
    }
}
