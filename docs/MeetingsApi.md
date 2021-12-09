# SigParser.Api.MeetingsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiMeetingsDistinctGet**](MeetingsApi.md#apimeetingsdistinctget) | **GET** /api/Meetings/Distinct | Fetch distinct meetings across all the mailboxes. If the same meeting is found in multiple mailboxes then you&#39;ll only get one reference to it.


<a name="apimeetingsdistinctget"></a>
# **ApiMeetingsDistinctGet**
> List<DragnetTechSharedIPAASModelsMeetingOutputModel> ApiMeetingsDistinctGet (DateTime? dateMax, DateTime? dateMin, int? take, int? page, string emailaddress, long? lastmodifiedAfter, string icaluid, string domain)

Fetch distinct meetings across all the mailboxes. If the same meeting is found in multiple mailboxes then you'll only get one reference to it.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiMeetingsDistinctGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new MeetingsApi();
            var dateMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Fetch meetings after this date. (optional) 
            var dateMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Fetch meetings before this date. (optional) 
            var take = 56;  // int? | Number of records to return. Default 100. Minimum is 25. Max 250. (optional) 
            var page = 56;  // int? | Page of results. First page is 1. Default 1. (optional) 
            var emailaddress = emailaddress_example;  // string | Find meetings with an attedee with this email address. This will return all meetings they accepted or declined. (optional) 
            var lastmodifiedAfter = 789;  // long? | Delta feed history date parameter. Keep track of the last value you saw. For the first request use 0 for the modified_after value.  When using this parameter the results are always in the order they were ingested in, not in the order of the emails. (optional) 
            var icaluid = icaluid_example;  // string | iCalUID for the meeting to search for. Will return the best meeting record for this iCalUID across all the mailboxes. (optional) 
            var domain = domain_example;  // string | Fetch meetings by the email domain. Can only use \"take\" and \"page\" with this parameter. Doesn't work for free email providers like gmail.com or yahoo.com along with many other non-corporate domains. (optional) 

            try
            {
                // Fetch distinct meetings across all the mailboxes. If the same meeting is found in multiple mailboxes then you'll only get one reference to it.
                List&lt;DragnetTechSharedIPAASModelsMeetingOutputModel&gt; result = apiInstance.ApiMeetingsDistinctGet(dateMax, dateMin, take, page, emailaddress, lastmodifiedAfter, icaluid, domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeetingsApi.ApiMeetingsDistinctGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dateMax** | **DateTime?**| Fetch meetings after this date. | [optional] 
 **dateMin** | **DateTime?**| Fetch meetings before this date. | [optional] 
 **take** | **int?**| Number of records to return. Default 100. Minimum is 25. Max 250. | [optional] 
 **page** | **int?**| Page of results. First page is 1. Default 1. | [optional] 
 **emailaddress** | **string**| Find meetings with an attedee with this email address. This will return all meetings they accepted or declined. | [optional] 
 **lastmodifiedAfter** | **long?**| Delta feed history date parameter. Keep track of the last value you saw. For the first request use 0 for the modified_after value.  When using this parameter the results are always in the order they were ingested in, not in the order of the emails. | [optional] 
 **icaluid** | **string**| iCalUID for the meeting to search for. Will return the best meeting record for this iCalUID across all the mailboxes. | [optional] 
 **domain** | **string**| Fetch meetings by the email domain. Can only use \&quot;take\&quot; and \&quot;page\&quot; with this parameter. Doesn&#39;t work for free email providers like gmail.com or yahoo.com along with many other non-corporate domains. | [optional] 

### Return type

[**List<DragnetTechSharedIPAASModelsMeetingOutputModel>**](DragnetTechSharedIPAASModelsMeetingOutputModel.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

