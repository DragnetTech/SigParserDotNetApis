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
    public interface IWebhooksApi
    {
        /// <summary>
        /// Delete the webhook. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IPaasAPIControllersWebhooksControllerDeleteResponse</returns>
        IPaasAPIControllersWebhooksControllerDeleteResponse ApiWebhooksDelete (Guid? id);
        /// <summary>
        /// Get a webhook by ID. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IPaasAPIControllersWebhooksControllerWebhookReturnModel</returns>
        IPaasAPIControllersWebhooksControllerWebhookReturnModel ApiWebhooksGet (Guid? id);
        /// <summary>
        /// List all the webhooks for the current team. 
        /// </summary>
        /// <returns>List&lt;IPaasAPIControllersWebhooksControllerWebhookReturnModel&gt;</returns>
        List<IPaasAPIControllersWebhooksControllerWebhookReturnModel> ApiWebhooksListGet ();
        /// <summary>
        /// Create a new webhook. See the \&quot;action\&quot; parameter for the types (contacts, companies, meetings, emails...) of webhooks. Use this to subscribe a webhook from SigParser. Webhook response structures are always the same format at the corresponding API response model up above.                Action Types  - -- -- -- -- -- -- -- -                - **contact.createorupdate** - A contact was created or updated in SigParser. This is a \&quot;Batched\&quot; webhook type. See below.      - This webhook has some additional parameters to control which contacts are returned:          - hasPhoneNumber - true or false          - hasOutboundEmails - true or false          - hasInboundEmails - true or false  - **company.createorupdate** - A company was created or updated. This is a \&quot;Batched\&quot; webhook type. See below.  - **email.new.distinct** - A new email was found. This is distinct to mailboxes. You typically won&#39;t get a notification twice for the same email unless the emails are reprocessed.   - **meeting.new.distinct** - A new meeting was detected.  - **meeting.updated.distinct** - The meeting was updated in some way.  - **meeting.deleted.distinct** - The meeting was deleted or cancelled from all the calendars being tracked by SigParser. A meeting can become uncancelled and would show up int he meeting.updated.distinct webhook.     Retries  - -- -- -- -- -- -- -- -- --  SigParser will retry posting the webhook every 10 minutes for 1 hour. After that it will abandon the webhook.                Batched webhooks  - -- -- -- -- -- -- -- -- -- --  SigParser is processing data for emails and meetings and contacts constantly throughout the day. Oftentimes the same contact or company is being updated hundreds or thousands of times per day. If SigParser fired a webhook for each of these updates it would overwhelm any listeners.                In order to reduce the number of API requests some webhooks are \&quot;batched\&quot; on a schedule. This means SigParser only submits the webhooks based on a schedule.                Use the \&quot;batch_frequency_cron_expression\&quot; parameter to set how often to schedule the sending of messages. The default is \&quot;@daily\&quot;. The minimum frequency is every 15 minutes.                Missed Webhook Sync  - -- -- -- -- -- -- -- -- -- -- -- --  While webhooks are nice for quicker updates they suffer from the problem of missed messages. What if your consumer endpoint goes down? In this case we still advise all webhook consumers to keep a data sync running on the APIs to ensure nothing is missed.
        /// </summary>
        /// <param name="body"></param>
        /// <returns>IPaasAPIControllersWebhooksControllerWebhookReturnModel</returns>
        IPaasAPIControllersWebhooksControllerWebhookReturnModel ApiWebhooksPost (IPaasAPIControllersWebhooksControllerWebhookPostParam body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebhooksApi : IWebhooksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WebhooksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebhooksApi(String basePath)
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
        /// Delete the webhook. 
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>IPaasAPIControllersWebhooksControllerDeleteResponse</returns>            
        public IPaasAPIControllersWebhooksControllerDeleteResponse ApiWebhooksDelete (Guid? id)
        {
            
    
            var path = "/api/Webhooks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhooksDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhooksDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIControllersWebhooksControllerDeleteResponse) ApiClient.Deserialize(response.Content, typeof(IPaasAPIControllersWebhooksControllerDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// Get a webhook by ID. 
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>IPaasAPIControllersWebhooksControllerWebhookReturnModel</returns>            
        public IPaasAPIControllersWebhooksControllerWebhookReturnModel ApiWebhooksGet (Guid? id)
        {
            
    
            var path = "/api/Webhooks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhooksGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhooksGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIControllersWebhooksControllerWebhookReturnModel) ApiClient.Deserialize(response.Content, typeof(IPaasAPIControllersWebhooksControllerWebhookReturnModel), response.Headers);
        }
    
        /// <summary>
        /// List all the webhooks for the current team. 
        /// </summary>
        /// <returns>List&lt;IPaasAPIControllersWebhooksControllerWebhookReturnModel&gt;</returns>            
        public List<IPaasAPIControllersWebhooksControllerWebhookReturnModel> ApiWebhooksListGet ()
        {
            
    
            var path = "/api/Webhooks/List";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhooksListGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhooksListGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<IPaasAPIControllersWebhooksControllerWebhookReturnModel>) ApiClient.Deserialize(response.Content, typeof(List<IPaasAPIControllersWebhooksControllerWebhookReturnModel>), response.Headers);
        }
    
        /// <summary>
        /// Create a new webhook. See the \&quot;action\&quot; parameter for the types (contacts, companies, meetings, emails...) of webhooks. Use this to subscribe a webhook from SigParser. Webhook response structures are always the same format at the corresponding API response model up above.                Action Types  - -- -- -- -- -- -- -- -                - **contact.createorupdate** - A contact was created or updated in SigParser. This is a \&quot;Batched\&quot; webhook type. See below.      - This webhook has some additional parameters to control which contacts are returned:          - hasPhoneNumber - true or false          - hasOutboundEmails - true or false          - hasInboundEmails - true or false  - **company.createorupdate** - A company was created or updated. This is a \&quot;Batched\&quot; webhook type. See below.  - **email.new.distinct** - A new email was found. This is distinct to mailboxes. You typically won&#39;t get a notification twice for the same email unless the emails are reprocessed.   - **meeting.new.distinct** - A new meeting was detected.  - **meeting.updated.distinct** - The meeting was updated in some way.  - **meeting.deleted.distinct** - The meeting was deleted or cancelled from all the calendars being tracked by SigParser. A meeting can become uncancelled and would show up int he meeting.updated.distinct webhook.     Retries  - -- -- -- -- -- -- -- -- --  SigParser will retry posting the webhook every 10 minutes for 1 hour. After that it will abandon the webhook.                Batched webhooks  - -- -- -- -- -- -- -- -- -- --  SigParser is processing data for emails and meetings and contacts constantly throughout the day. Oftentimes the same contact or company is being updated hundreds or thousands of times per day. If SigParser fired a webhook for each of these updates it would overwhelm any listeners.                In order to reduce the number of API requests some webhooks are \&quot;batched\&quot; on a schedule. This means SigParser only submits the webhooks based on a schedule.                Use the \&quot;batch_frequency_cron_expression\&quot; parameter to set how often to schedule the sending of messages. The default is \&quot;@daily\&quot;. The minimum frequency is every 15 minutes.                Missed Webhook Sync  - -- -- -- -- -- -- -- -- -- -- -- --  While webhooks are nice for quicker updates they suffer from the problem of missed messages. What if your consumer endpoint goes down? In this case we still advise all webhook consumers to keep a data sync running on the APIs to ensure nothing is missed.
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>IPaasAPIControllersWebhooksControllerWebhookReturnModel</returns>            
        public IPaasAPIControllersWebhooksControllerWebhookReturnModel ApiWebhooksPost (IPaasAPIControllersWebhooksControllerWebhookPostParam body)
        {
            
    
            var path = "/api/Webhooks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhooksPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhooksPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIControllersWebhooksControllerWebhookReturnModel) ApiClient.Deserialize(response.Content, typeof(IPaasAPIControllersWebhooksControllerWebhookReturnModel), response.Headers);
        }
    
    }
}
