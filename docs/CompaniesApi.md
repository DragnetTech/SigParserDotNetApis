# SigParser.Api.CompaniesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiCompaniesGet**](CompaniesApi.md#apicompaniesget) | **GET** /api/Companies | Fetch details about companies by the email domain.


<a name="apicompaniesget"></a>
# **ApiCompaniesGet**
> List<DragnetTechSharedIPAASModelsCompanyOutputModel> ApiCompaniesGet (long? lastmodifiedAfter, int? take, string domain)

Fetch details about companies by the email domain.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiCompaniesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new CompaniesApi();
            var lastmodifiedAfter = 789;  // long? | Use this to get a delta of all the changes since your query. Save the last \"lastmodified\" value.  This will not return companies with a status of Private, Ignored or Coworker. (optional) 
            var take = 56;  // int? | How many records to return. The minimum count is 25. Maximum 250. (optional) 
            var domain = domain_example;  // string | Lookup a specific company by domain. Private companies are never returned but Coworker and Ignore accounts are. Domain names must be lowercase. (optional) 

            try
            {
                // Fetch details about companies by the email domain.
                List&lt;DragnetTechSharedIPAASModelsCompanyOutputModel&gt; result = apiInstance.ApiCompaniesGet(lastmodifiedAfter, take, domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.ApiCompaniesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lastmodifiedAfter** | **long?**| Use this to get a delta of all the changes since your query. Save the last \&quot;lastmodified\&quot; value.  This will not return companies with a status of Private, Ignored or Coworker. | [optional] 
 **take** | **int?**| How many records to return. The minimum count is 25. Maximum 250. | [optional] 
 **domain** | **string**| Lookup a specific company by domain. Private companies are never returned but Coworker and Ignore accounts are. Domain names must be lowercase. | [optional] 

### Return type

[**List<DragnetTechSharedIPAASModelsCompanyOutputModel>**](DragnetTechSharedIPAASModelsCompanyOutputModel.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

