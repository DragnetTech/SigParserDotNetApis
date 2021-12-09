# SigParser.Api.EmailsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiEmailsDistinctGet**](EmailsApi.md#apiemailsdistinctget) | **GET** /api/Emails/Distinct | Fetch distinct emails across all the mailboxes. If the same emails is found in 10 mailboxes then only one instance of it will be returned.


<a name="apiemailsdistinctget"></a>
# **ApiEmailsDistinctGet**
> List<DragnetTechSharedIPAASModelsEmailOutputModel> ApiEmailsDistinctGet (long? ingestedAfter, int? take, int? page, string emailaddress, Guid? id, string domain)

Fetch distinct emails across all the mailboxes. If the same emails is found in 10 mailboxes then only one instance of it will be returned.

Primary Key  - -- -- -- -- -- -- -- -- -- -- -                Unlike meetings, emails don't have a unique identifier like iCalUID that can be used. Instead you should generate a unique string to represent the ID of the email by joining them all together. Or you could make a table with a 4 column primary key.                - date  - from - email address of the sender  - subject - Hash this so you get a consistent length if length matters.  - to_and_cc_hash - A hash value of the concatenated email addresses in the To and CC fields.                That will generate a unique row per email. This structure works well because you can query emails by date range. If you don't want to do multiple columns you could just combine all of these into one text field.     Delta Request  - -- -- -- -- -- -- -- -- -- --                Use the **ingested_after** parameter to request the last max **ingestion_key** seen.                 The **ingestion_key** is just a timestamp value and isn't the primary key. This can change for an email if a mailbox is removed from SigParser and another email has to take it's place.                 Maximum 250 emails per request  - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -                You are limited to requesting 250 email records per request. If you need more than 250 then you'll need to use the **Delta request** pattern to fetch emails in batches.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiEmailsDistinctGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new EmailsApi();
            var ingestedAfter = 789;  // long? | Delta feed history date parameter. Keep track of the last value you saw. For the first request use 0 for the ingested_after value.  When using this parameter the results are always in the order they were ingested in, not in the order of the emails. (optional) 
            var take = 56;  // int? | Number of records to return. Default 100. Minimum is 25. Max 250. (optional) 
            var page = 56;  // int? | Page of results. First page is 1. Default 1. (optional) 
            var emailaddress = emailaddress_example;  // string | Fetch emails for a specific contact.   Emails are always in descending order. Use \"take\" and \"page\" to navigate thru the pages of emails. (optional) 
            var id = new Guid?(); // Guid? | ID of the message to retrieve. (optional) 
            var domain = domain_example;  // string | Fetch emails by the email domain. Can only use \"take\" and \"page\" with this parameter. Doesn't work for free email providers like gmail.com or yahoo.com along with many other non-corporate domains. (optional) 

            try
            {
                // Fetch distinct emails across all the mailboxes. If the same emails is found in 10 mailboxes then only one instance of it will be returned.
                List&lt;DragnetTechSharedIPAASModelsEmailOutputModel&gt; result = apiInstance.ApiEmailsDistinctGet(ingestedAfter, take, page, emailaddress, id, domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.ApiEmailsDistinctGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ingestedAfter** | **long?**| Delta feed history date parameter. Keep track of the last value you saw. For the first request use 0 for the ingested_after value.  When using this parameter the results are always in the order they were ingested in, not in the order of the emails. | [optional] 
 **take** | **int?**| Number of records to return. Default 100. Minimum is 25. Max 250. | [optional] 
 **page** | **int?**| Page of results. First page is 1. Default 1. | [optional] 
 **emailaddress** | **string**| Fetch emails for a specific contact.   Emails are always in descending order. Use \&quot;take\&quot; and \&quot;page\&quot; to navigate thru the pages of emails. | [optional] 
 **id** | [**Guid?**](.md)| ID of the message to retrieve. | [optional] 
 **domain** | **string**| Fetch emails by the email domain. Can only use \&quot;take\&quot; and \&quot;page\&quot; with this parameter. Doesn&#39;t work for free email providers like gmail.com or yahoo.com along with many other non-corporate domains. | [optional] 

### Return type

[**List<DragnetTechSharedIPAASModelsEmailOutputModel>**](DragnetTechSharedIPAASModelsEmailOutputModel.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

