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
    public interface IContactsApi
    {
        /// <summary>
        /// Get Contact Details based on the Parameter set     Order by allowed is lastmodified This API can be used to fetch single contacts or multiple contacts.                Be sure to notice that this is a POST method and not a GET. This is so that we can add more complexity to the query later which would be more difficult later.                emailaddress is the Primary Key  - -- -- -- -- -- -- -- -  The primary key for contacts is the emailaddress field. The email address for a contact won&#39;t change in SigParser. The email address is always lowercase.                  Daily Data Sync  - -- -- -- -- -- -- --                To do a daily data sync of any recently updated or created contacts you should do the following:    1. Make an initial request and set the following:      - **take**: **100**.      - **lastmodified_after**: **2001-01-01T00:00:00Z** or some very old date.      - **orderbyasc**: **true** - Important for the results to be returned properly. The default is false if not specified.  1. Process the contacts returned.  1. Save the **lastmodified** date on the last contact in the response.  1. If there were less than the **take** number of contacts then stop requesting data.  1. If there were the **take** number of contacts then call the API again but this time also pass the parameter **lastmodified_after**  1. Continue to call the API with the last saved **lastmodified_after** field until you get less than the \&quot;take\&quot; number of contacts.                You won&#39;t get the same contact back in a single response but will get the same contact back on later responses if that contact is updated between requests.                 Query Contacts by Company  - -- -- -- -- -- -- -- -- -- -- -- -  To query contacts by the company provide the \&quot;domain\&quot; parameter.                Query Contacts by Email Address  - -- -- -- -- -- -- -- -- -- -- -- -  To query contacts by the company provide the \&quot;emailaddress\&quot; parameter.    Contact Status  - -- -- -- -- -- -- -- -- -- -- -- -  The API will only return **Valid** and **Other** status contacts by default.                - **Private** - Never returned from the API. These are contacts someone marked as private in the application.  - **Coworker** - These will only be returned from the API is queried using the **emailaddress** parameter.  - **Ignore** - These are contacts SigParser has automatically determined to likely not be interesting contacts. Oftentimes they&#39;re automated systems or spam. You can fetch these if needed by setting the parameter \&quot;include_spam_contacts\&quot; &#x3D; true.                  Expand Relationship Metrics  - -- -- -- -- -- -- -- -- -- -- -- -- --  This API can return a detailed relationship graph for each contact. You&#39;ll see this in the **relationship_metrics** field on the contact.                Be aware this can slow down response times and can also result in much larger responses than normal.                To control the response size these aren&#39;t returned by default. To return them you must provide \&quot;expand_relationship_metrics &#x3D; true\&quot; and \&quot;expand_relationship_metrics_history &#x3D; true\&quot;                FAQ  - -- -- -- -- -- -- -- --                **Can one email address be mapped to multiple contacts?**                No, only one contact in SigParser can have an email address. Be aware that in a CRM like Salesforce many contacts can have the same email address so you&#39;ll need to map the data from SigParser to all of those contacts.                **What is the difference between the *location_* and *address_* fields?**                Location fields are derived from an address in the email signature, phone number or website domain in that order and geocoded to standarize the naming. Address fields are only populated if we found something in the email signature that looks like an address or even just a city/state.                 **How can I detect if an email address is still valid?**                SigParser has a couple fields which expose this.                - **emailstatus** - The status of the email verification for this email address. Valid values are: \&quot;Valid\&quot;, \&quot;Invalid\&quot;, \&quot;Unknown\&quot;, \&quot;Catch All\&quot;. Contacts will have null if they haven&#39;t been checked yet. Not all plans include this feature so you&#39;ll need to check if your plan has this and that you have enough email validation credits.  - **isspam** - Is the email address likely a spammy or automated email address.   - **emailbouncedate** - Date when an email bounce was detected for the contact. Good to filter these out so they don&#39;t go to marketing systems.
        /// </summary>
        /// <param name="body"></param>
        /// <returns>List&lt;DragnetTechSharedContactOutputModel&gt;</returns>
        List<DragnetTechSharedContactOutputModel> ApiContactsListPost (DragnetTechSharedIPAASModelsRequestContactParam body);
        /// <summary>
        /// Insert/Updates a contact by email address 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>DragnetTechSharedContactOutputModel</returns>
        DragnetTechSharedContactOutputModel ApiContactsPost (IPaasAPIControllersContactsControllerContactUpsertModel body);
        /// <summary>
        /// Get list of tags defined in SigParser. 
        /// </summary>
        /// <param name="query"></param>
        /// <returns>List&lt;IPaasAPIControllersContactsControllerCustomTagList&gt;</returns>
        List<IPaasAPIControllersContactsControllerCustomTagList> ApiContactsTagListGet (string query);
        /// <summary>
        /// Performs an operation to tag / untag a contact. Tags can have different types which is why you have to pass the ID instead of the name of the tag. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>IPaasAPIControllersContactsControllerTagRequestResponse</returns>
        IPaasAPIControllersContactsControllerTagRequestResponse ApiContactsTagPost (IPaasAPIControllersContactsControllerTagRequestParam body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContactsApi : IContactsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ContactsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContactsApi(String basePath)
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
        /// Get Contact Details based on the Parameter set     Order by allowed is lastmodified This API can be used to fetch single contacts or multiple contacts.                Be sure to notice that this is a POST method and not a GET. This is so that we can add more complexity to the query later which would be more difficult later.                emailaddress is the Primary Key  - -- -- -- -- -- -- -- -  The primary key for contacts is the emailaddress field. The email address for a contact won&#39;t change in SigParser. The email address is always lowercase.                  Daily Data Sync  - -- -- -- -- -- -- --                To do a daily data sync of any recently updated or created contacts you should do the following:    1. Make an initial request and set the following:      - **take**: **100**.      - **lastmodified_after**: **2001-01-01T00:00:00Z** or some very old date.      - **orderbyasc**: **true** - Important for the results to be returned properly. The default is false if not specified.  1. Process the contacts returned.  1. Save the **lastmodified** date on the last contact in the response.  1. If there were less than the **take** number of contacts then stop requesting data.  1. If there were the **take** number of contacts then call the API again but this time also pass the parameter **lastmodified_after**  1. Continue to call the API with the last saved **lastmodified_after** field until you get less than the \&quot;take\&quot; number of contacts.                You won&#39;t get the same contact back in a single response but will get the same contact back on later responses if that contact is updated between requests.                 Query Contacts by Company  - -- -- -- -- -- -- -- -- -- -- -- -  To query contacts by the company provide the \&quot;domain\&quot; parameter.                Query Contacts by Email Address  - -- -- -- -- -- -- -- -- -- -- -- -  To query contacts by the company provide the \&quot;emailaddress\&quot; parameter.    Contact Status  - -- -- -- -- -- -- -- -- -- -- -- -  The API will only return **Valid** and **Other** status contacts by default.                - **Private** - Never returned from the API. These are contacts someone marked as private in the application.  - **Coworker** - These will only be returned from the API is queried using the **emailaddress** parameter.  - **Ignore** - These are contacts SigParser has automatically determined to likely not be interesting contacts. Oftentimes they&#39;re automated systems or spam. You can fetch these if needed by setting the parameter \&quot;include_spam_contacts\&quot; &#x3D; true.                  Expand Relationship Metrics  - -- -- -- -- -- -- -- -- -- -- -- -- --  This API can return a detailed relationship graph for each contact. You&#39;ll see this in the **relationship_metrics** field on the contact.                Be aware this can slow down response times and can also result in much larger responses than normal.                To control the response size these aren&#39;t returned by default. To return them you must provide \&quot;expand_relationship_metrics &#x3D; true\&quot; and \&quot;expand_relationship_metrics_history &#x3D; true\&quot;                FAQ  - -- -- -- -- -- -- -- --                **Can one email address be mapped to multiple contacts?**                No, only one contact in SigParser can have an email address. Be aware that in a CRM like Salesforce many contacts can have the same email address so you&#39;ll need to map the data from SigParser to all of those contacts.                **What is the difference between the *location_* and *address_* fields?**                Location fields are derived from an address in the email signature, phone number or website domain in that order and geocoded to standarize the naming. Address fields are only populated if we found something in the email signature that looks like an address or even just a city/state.                 **How can I detect if an email address is still valid?**                SigParser has a couple fields which expose this.                - **emailstatus** - The status of the email verification for this email address. Valid values are: \&quot;Valid\&quot;, \&quot;Invalid\&quot;, \&quot;Unknown\&quot;, \&quot;Catch All\&quot;. Contacts will have null if they haven&#39;t been checked yet. Not all plans include this feature so you&#39;ll need to check if your plan has this and that you have enough email validation credits.  - **isspam** - Is the email address likely a spammy or automated email address.   - **emailbouncedate** - Date when an email bounce was detected for the contact. Good to filter these out so they don&#39;t go to marketing systems.
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>List&lt;DragnetTechSharedContactOutputModel&gt;</returns>            
        public List<DragnetTechSharedContactOutputModel> ApiContactsListPost (DragnetTechSharedIPAASModelsRequestContactParam body)
        {
            
    
            var path = "/api/Contacts/List";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiContactsListPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiContactsListPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DragnetTechSharedContactOutputModel>) ApiClient.Deserialize(response.Content, typeof(List<DragnetTechSharedContactOutputModel>), response.Headers);
        }
    
        /// <summary>
        /// Insert/Updates a contact by email address 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>DragnetTechSharedContactOutputModel</returns>            
        public DragnetTechSharedContactOutputModel ApiContactsPost (IPaasAPIControllersContactsControllerContactUpsertModel body)
        {
            
    
            var path = "/api/Contacts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiContactsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiContactsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DragnetTechSharedContactOutputModel) ApiClient.Deserialize(response.Content, typeof(DragnetTechSharedContactOutputModel), response.Headers);
        }
    
        /// <summary>
        /// Get list of tags defined in SigParser. 
        /// </summary>
        /// <param name="query"></param> 
        /// <returns>List&lt;IPaasAPIControllersContactsControllerCustomTagList&gt;</returns>            
        public List<IPaasAPIControllersContactsControllerCustomTagList> ApiContactsTagListGet (string query)
        {
            
    
            var path = "/api/Contacts/Tag/List";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiContactsTagListGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiContactsTagListGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<IPaasAPIControllersContactsControllerCustomTagList>) ApiClient.Deserialize(response.Content, typeof(List<IPaasAPIControllersContactsControllerCustomTagList>), response.Headers);
        }
    
        /// <summary>
        /// Performs an operation to tag / untag a contact. Tags can have different types which is why you have to pass the ID instead of the name of the tag. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>IPaasAPIControllersContactsControllerTagRequestResponse</returns>            
        public IPaasAPIControllersContactsControllerTagRequestResponse ApiContactsTagPost (IPaasAPIControllersContactsControllerTagRequestParam body)
        {
            
    
            var path = "/api/Contacts/Tag";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiContactsTagPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiContactsTagPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIControllersContactsControllerTagRequestResponse) ApiClient.Deserialize(response.Content, typeof(IPaasAPIControllersContactsControllerTagRequestResponse), response.Headers);
        }
    
    }
}
