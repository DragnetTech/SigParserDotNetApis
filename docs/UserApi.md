# SigParser.Api.UserApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiUserInvalidateDelete**](UserApi.md#apiuserinvalidatedelete) | **DELETE** /api/User/Invalidate | Revoke the data access API key for this request. Doesn&#39;t revoke the email parsing API key. OAuth providers should try to call this when disconnecting a connection if possible.
[**ApiUserMeGet**](UserApi.md#apiusermeget) | **GET** /api/User/Me | Get the User Information [ Username , EnterpriseId ]


<a name="apiuserinvalidatedelete"></a>
# **ApiUserInvalidateDelete**
> IPaasAPIControllersUserControllerReturnMe ApiUserInvalidateDelete ()

Revoke the data access API key for this request. Doesn't revoke the email parsing API key. OAuth providers should try to call this when disconnecting a connection if possible.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiUserInvalidateDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                // Revoke the data access API key for this request. Doesn't revoke the email parsing API key. OAuth providers should try to call this when disconnecting a connection if possible.
                IPaasAPIControllersUserControllerReturnMe result = apiInstance.ApiUserInvalidateDelete();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserInvalidateDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**IPaasAPIControllersUserControllerReturnMe**](IPaasAPIControllersUserControllerReturnMe.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiusermeget"></a>
# **ApiUserMeGet**
> IPaasAPIControllersUserControllerReturnMe ApiUserMeGet ()

Get the User Information [ Username , EnterpriseId ]

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiUserMeGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                // Get the User Information [ Username , EnterpriseId ]
                IPaasAPIControllersUserControllerReturnMe result = apiInstance.ApiUserMeGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserMeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**IPaasAPIControllersUserControllerReturnMe**](IPaasAPIControllersUserControllerReturnMe.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

