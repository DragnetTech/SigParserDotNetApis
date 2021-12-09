# SigParser.Api.WebhooksApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiWebhooksDelete**](WebhooksApi.md#apiwebhooksdelete) | **DELETE** /api/Webhooks | Delete the webhook.
[**ApiWebhooksGet**](WebhooksApi.md#apiwebhooksget) | **GET** /api/Webhooks | Get a webhook by ID.
[**ApiWebhooksListGet**](WebhooksApi.md#apiwebhookslistget) | **GET** /api/Webhooks/List | List all the webhooks for the current team.
[**ApiWebhooksPost**](WebhooksApi.md#apiwebhookspost) | **POST** /api/Webhooks | Create a new webhook. See the \&quot;action\&quot; parameter for the types (contacts, companies, meetings, emails...) of webhooks.


<a name="apiwebhooksdelete"></a>
# **ApiWebhooksDelete**
> IPaasAPIControllersWebhooksControllerDeleteResponse ApiWebhooksDelete (Guid? id)

Delete the webhook.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiWebhooksDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new WebhooksApi();
            var id = new Guid?(); // Guid? |  (optional) 

            try
            {
                // Delete the webhook.
                IPaasAPIControllersWebhooksControllerDeleteResponse result = apiInstance.ApiWebhooksDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.ApiWebhooksDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)|  | [optional] 

### Return type

[**IPaasAPIControllersWebhooksControllerDeleteResponse**](IPaasAPIControllersWebhooksControllerDeleteResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiwebhooksget"></a>
# **ApiWebhooksGet**
> IPaasAPIControllersWebhooksControllerWebhookReturnModel ApiWebhooksGet (Guid? id)

Get a webhook by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiWebhooksGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new WebhooksApi();
            var id = new Guid?(); // Guid? |  (optional) 

            try
            {
                // Get a webhook by ID.
                IPaasAPIControllersWebhooksControllerWebhookReturnModel result = apiInstance.ApiWebhooksGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.ApiWebhooksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)|  | [optional] 

### Return type

[**IPaasAPIControllersWebhooksControllerWebhookReturnModel**](IPaasAPIControllersWebhooksControllerWebhookReturnModel.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiwebhookslistget"></a>
# **ApiWebhooksListGet**
> List<IPaasAPIControllersWebhooksControllerWebhookReturnModel> ApiWebhooksListGet ()

List all the webhooks for the current team.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiWebhooksListGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new WebhooksApi();

            try
            {
                // List all the webhooks for the current team.
                List&lt;IPaasAPIControllersWebhooksControllerWebhookReturnModel&gt; result = apiInstance.ApiWebhooksListGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.ApiWebhooksListGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<IPaasAPIControllersWebhooksControllerWebhookReturnModel>**](IPaasAPIControllersWebhooksControllerWebhookReturnModel.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiwebhookspost"></a>
# **ApiWebhooksPost**
> IPaasAPIControllersWebhooksControllerWebhookReturnModel ApiWebhooksPost (IPaasAPIControllersWebhooksControllerWebhookPostParam body)

Create a new webhook. See the \"action\" parameter for the types (contacts, companies, meetings, emails...) of webhooks.

Use this to subscribe a webhook from SigParser. Webhook response structures are always the same format at the corresponding API response model up above.                Action Types  - -- -- -- -- -- -- -- -                - **contact.createorupdate** - A contact was created or updated in SigParser. This is a \"Batched\" webhook type. See below.      - This webhook has some additional parameters to control which contacts are returned:          - hasPhoneNumber - true or false          - hasOutboundEmails - true or false          - hasInboundEmails - true or false  - **company.createorupdate** - A company was created or updated. This is a \"Batched\" webhook type. See below.  - **email.new.distinct** - A new email was found. This is distinct to mailboxes. You typically won't get a notification twice for the same email unless the emails are reprocessed.   - **meeting.new.distinct** - A new meeting was detected.  - **meeting.updated.distinct** - The meeting was updated in some way.  - **meeting.deleted.distinct** - The meeting was deleted or cancelled from all the calendars being tracked by SigParser. A meeting can become uncancelled and would show up int he meeting.updated.distinct webhook.     Retries  - -- -- -- -- -- -- -- -- --  SigParser will retry posting the webhook every 10 minutes for 1 hour. After that it will abandon the webhook.                Batched webhooks  - -- -- -- -- -- -- -- -- -- --  SigParser is processing data for emails and meetings and contacts constantly throughout the day. Oftentimes the same contact or company is being updated hundreds or thousands of times per day. If SigParser fired a webhook for each of these updates it would overwhelm any listeners.                In order to reduce the number of API requests some webhooks are \"batched\" on a schedule. This means SigParser only submits the webhooks based on a schedule.                Use the \"batch_frequency_cron_expression\" parameter to set how often to schedule the sending of messages. The default is \"@daily\". The minimum frequency is every 15 minutes.                Missed Webhook Sync  - -- -- -- -- -- -- -- -- -- -- -- --  While webhooks are nice for quicker updates they suffer from the problem of missed messages. What if your consumer endpoint goes down? In this case we still advise all webhook consumers to keep a data sync running on the APIs to ensure nothing is missed.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiWebhooksPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new WebhooksApi();
            var body = new IPaasAPIControllersWebhooksControllerWebhookPostParam(); // IPaasAPIControllersWebhooksControllerWebhookPostParam |  (optional) 

            try
            {
                // Create a new webhook. See the \"action\" parameter for the types (contacts, companies, meetings, emails...) of webhooks.
                IPaasAPIControllersWebhooksControllerWebhookReturnModel result = apiInstance.ApiWebhooksPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.ApiWebhooksPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IPaasAPIControllersWebhooksControllerWebhookPostParam**](IPaasAPIControllersWebhooksControllerWebhookPostParam.md)|  | [optional] 

### Return type

[**IPaasAPIControllersWebhooksControllerWebhookReturnModel**](IPaasAPIControllersWebhooksControllerWebhookReturnModel.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

