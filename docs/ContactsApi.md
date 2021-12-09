# SigParser.Api.ContactsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiContactsListPost**](ContactsApi.md#apicontactslistpost) | **POST** /api/Contacts/List | Get Contact Details based on the Parameter set     Order by allowed is lastmodified
[**ApiContactsPost**](ContactsApi.md#apicontactspost) | **POST** /api/Contacts | Insert/Updates a contact by email address
[**ApiContactsTagListGet**](ContactsApi.md#apicontactstaglistget) | **GET** /api/Contacts/Tag/List | Get list of tags defined in SigParser.
[**ApiContactsTagPost**](ContactsApi.md#apicontactstagpost) | **POST** /api/Contacts/Tag | Performs an operation to tag / untag a contact. Tags can have different types which is why you have to pass the ID instead of the name of the tag.


<a name="apicontactslistpost"></a>
# **ApiContactsListPost**
> List<DragnetTechSharedContactOutputModel> ApiContactsListPost (DragnetTechSharedIPAASModelsRequestContactParam body)

Get Contact Details based on the Parameter set     Order by allowed is lastmodified

This API can be used to fetch single contacts or multiple contacts.                Be sure to notice that this is a POST method and not a GET. This is so that we can add more complexity to the query later which would be more difficult later.                emailaddress is the Primary Key  - -- -- -- -- -- -- -- -  The primary key for contacts is the emailaddress field. The email address for a contact won't change in SigParser. The email address is always lowercase.                  Daily Data Sync  - -- -- -- -- -- -- --                To do a daily data sync of any recently updated or created contacts you should do the following:    1. Make an initial request and set the following:      - **take**: **100**.      - **lastmodified_after**: **2001-01-01T00:00:00Z** or some very old date.      - **orderbyasc**: **true** - Important for the results to be returned properly. The default is false if not specified.  1. Process the contacts returned.  1. Save the **lastmodified** date on the last contact in the response.  1. If there were less than the **take** number of contacts then stop requesting data.  1. If there were the **take** number of contacts then call the API again but this time also pass the parameter **lastmodified_after**  1. Continue to call the API with the last saved **lastmodified_after** field until you get less than the \"take\" number of contacts.                You won't get the same contact back in a single response but will get the same contact back on later responses if that contact is updated between requests.                 Query Contacts by Company  - -- -- -- -- -- -- -- -- -- -- -- -  To query contacts by the company provide the \"domain\" parameter.                Query Contacts by Email Address  - -- -- -- -- -- -- -- -- -- -- -- -  To query contacts by the company provide the \"emailaddress\" parameter.    Contact Status  - -- -- -- -- -- -- -- -- -- -- -- -  The API will only return **Valid** and **Other** status contacts by default.                - **Private** - Never returned from the API. These are contacts someone marked as private in the application.  - **Coworker** - These will only be returned from the API is queried using the **emailaddress** parameter.  - **Ignore** - These are contacts SigParser has automatically determined to likely not be interesting contacts. Oftentimes they're automated systems or spam. You can fetch these if needed by setting the parameter \"include_spam_contacts\" = true.                  Expand Relationship Metrics  - -- -- -- -- -- -- -- -- -- -- -- -- --  This API can return a detailed relationship graph for each contact. You'll see this in the **relationship_metrics** field on the contact.                Be aware this can slow down response times and can also result in much larger responses than normal.                To control the response size these aren't returned by default. To return them you must provide \"expand_relationship_metrics = true\" and \"expand_relationship_metrics_history = true\"                FAQ  - -- -- -- -- -- -- -- --                **Can one email address be mapped to multiple contacts?**                No, only one contact in SigParser can have an email address. Be aware that in a CRM like Salesforce many contacts can have the same email address so you'll need to map the data from SigParser to all of those contacts.                **What is the difference between the *location_* and *address_* fields?**                Location fields are derived from an address in the email signature, phone number or website domain in that order and geocoded to standarize the naming. Address fields are only populated if we found something in the email signature that looks like an address or even just a city/state.                 **How can I detect if an email address is still valid?**                SigParser has a couple fields which expose this.                - **emailstatus** - The status of the email verification for this email address. Valid values are: \"Valid\", \"Invalid\", \"Unknown\", \"Catch All\". Contacts will have null if they haven't been checked yet. Not all plans include this feature so you'll need to check if your plan has this and that you have enough email validation credits.  - **isspam** - Is the email address likely a spammy or automated email address.   - **emailbouncedate** - Date when an email bounce was detected for the contact. Good to filter these out so they don't go to marketing systems.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiContactsListPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ContactsApi();
            var body = new DragnetTechSharedIPAASModelsRequestContactParam(); // DragnetTechSharedIPAASModelsRequestContactParam |  (optional) 

            try
            {
                // Get Contact Details based on the Parameter set     Order by allowed is lastmodified
                List&lt;DragnetTechSharedContactOutputModel&gt; result = apiInstance.ApiContactsListPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ApiContactsListPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DragnetTechSharedIPAASModelsRequestContactParam**](DragnetTechSharedIPAASModelsRequestContactParam.md)|  | [optional] 

### Return type

[**List<DragnetTechSharedContactOutputModel>**](DragnetTechSharedContactOutputModel.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apicontactspost"></a>
# **ApiContactsPost**
> DragnetTechSharedContactOutputModel ApiContactsPost (IPaasAPIControllersContactsControllerContactUpsertModel body)

Insert/Updates a contact by email address

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiContactsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ContactsApi();
            var body = new IPaasAPIControllersContactsControllerContactUpsertModel(); // IPaasAPIControllersContactsControllerContactUpsertModel |  (optional) 

            try
            {
                // Insert/Updates a contact by email address
                DragnetTechSharedContactOutputModel result = apiInstance.ApiContactsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ApiContactsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IPaasAPIControllersContactsControllerContactUpsertModel**](IPaasAPIControllersContactsControllerContactUpsertModel.md)|  | [optional] 

### Return type

[**DragnetTechSharedContactOutputModel**](DragnetTechSharedContactOutputModel.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apicontactstaglistget"></a>
# **ApiContactsTagListGet**
> List<IPaasAPIControllersContactsControllerCustomTagList> ApiContactsTagListGet (string query)

Get list of tags defined in SigParser.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiContactsTagListGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ContactsApi();
            var query = query_example;  // string |  (optional) 

            try
            {
                // Get list of tags defined in SigParser.
                List&lt;IPaasAPIControllersContactsControllerCustomTagList&gt; result = apiInstance.ApiContactsTagListGet(query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ApiContactsTagListGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**|  | [optional] 

### Return type

[**List<IPaasAPIControllersContactsControllerCustomTagList>**](IPaasAPIControllersContactsControllerCustomTagList.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apicontactstagpost"></a>
# **ApiContactsTagPost**
> IPaasAPIControllersContactsControllerTagRequestResponse ApiContactsTagPost (IPaasAPIControllersContactsControllerTagRequestParam body)

Performs an operation to tag / untag a contact. Tags can have different types which is why you have to pass the ID instead of the name of the tag.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiContactsTagPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ContactsApi();
            var body = new IPaasAPIControllersContactsControllerTagRequestParam(); // IPaasAPIControllersContactsControllerTagRequestParam |  (optional) 

            try
            {
                // Performs an operation to tag / untag a contact. Tags can have different types which is why you have to pass the ID instead of the name of the tag.
                IPaasAPIControllersContactsControllerTagRequestResponse result = apiInstance.ApiContactsTagPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ApiContactsTagPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IPaasAPIControllersContactsControllerTagRequestParam**](IPaasAPIControllersContactsControllerTagRequestParam.md)|  | [optional] 

### Return type

[**IPaasAPIControllersContactsControllerTagRequestResponse**](IPaasAPIControllersContactsControllerTagRequestResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

