# SigParser.Api.ParseApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiEmailPost**](ParseApi.md#apiemailpost) | **POST** /api/Email | Legacy email parsing API. Obselete.
[**ApiMimeParseStringPost**](ParseApi.md#apimimeparsestringpost) | **POST** /api/Mime/ParseString | Legacy email parsing API for MIME. Obsolete.
[**ApiParseEmailContactJSONPost**](ParseApi.md#apiparseemailcontactjsonpost) | **POST** /api/Parse/Email/Contact/JSON | Email signature parser JSON (stateless)
[**ApiParseEmailContactMIMEPost**](ParseApi.md#apiparseemailcontactmimepost) | **POST** /api/Parse/Email/Contact/MIME | Email signature parser MIME/EML (stateless)
[**ApiParseEmailContactMSGPost**](ParseApi.md#apiparseemailcontactmsgpost) | **POST** /api/Parse/Email/Contact/MSG | Email signature parser for MSG (stateless)
[**ApiParseEmailMessageJSONPost**](ParseApi.md#apiparseemailmessagejsonpost) | **POST** /api/Parse/Email/Message/JSON | Split email JSON (stateless)
[**ApiParseEmailMessageMIMEPost**](ParseApi.md#apiparseemailmessagemimepost) | **POST** /api/Parse/Email/Message/MIME | Split email EML/MIME (stateless)
[**ApiParseEmailMessageMSGPost**](ParseApi.md#apiparseemailmessagemsgpost) | **POST** /api/Parse/Email/Message/MSG | Split email MSG (stateless)
[**ApiParseFeedbackPost**](ParseApi.md#apiparsefeedbackpost) | **POST** /api/Parse/Feedback | Report parsing feedback


<a name="apiemailpost"></a>
# **ApiEmailPost**
> SigParserEmailParseResponse ApiEmailPost (IPaasAPIModelsParseEmailInputModel body)

Legacy email parsing API. Obselete.

This API is no longer available for new users. If you are currently using this API we suggest you move to one of the other email parsing APIs next time you're making changes to your code. Those new APIs provide more fit for purpose results.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiEmailPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ParseApi();
            var body = new IPaasAPIModelsParseEmailInputModel(); // IPaasAPIModelsParseEmailInputModel |  (optional) 

            try
            {
                // Legacy email parsing API. Obselete.
                SigParserEmailParseResponse result = apiInstance.ApiEmailPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParseApi.ApiEmailPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IPaasAPIModelsParseEmailInputModel**](IPaasAPIModelsParseEmailInputModel.md)|  | [optional] 

### Return type

[**SigParserEmailParseResponse**](SigParserEmailParseResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apimimeparsestringpost"></a>
# **ApiMimeParseStringPost**
> IPaasAPIModelsParseCleanedBodyOutput ApiMimeParseStringPost ()

Legacy email parsing API for MIME. Obsolete.

This is no longer available to new users. If you're an existing users you should migrate off of this and over to /api/Parse/Email/Message/MIME    Post the MIME encoded email text in the body to this API. If you have EML files then you need to post the contents of the EML file.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiMimeParseStringPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ParseApi();

            try
            {
                // Legacy email parsing API for MIME. Obsolete.
                IPaasAPIModelsParseCleanedBodyOutput result = apiInstance.ApiMimeParseStringPost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParseApi.ApiMimeParseStringPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**IPaasAPIModelsParseCleanedBodyOutput**](IPaasAPIModelsParseCleanedBodyOutput.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiparseemailcontactjsonpost"></a>
# **ApiParseEmailContactJSONPost**
> IPaasAPIModelsParseEmailSignatureV2Model ApiParseEmailContactJSONPost (IPaasAPIModelsParseEmailInputModel body)

Email signature parser JSON (stateless)

Capture the email signature details for the sender of an email. This also will detect inline phone numbers such as \"My phone number is 777-333-4444\".                Only use JSON as a last resort  - -- -- -- -- -- -- -  Use MIME or MSG endpoints if you have either of those formats available to you. MIME and MSG just require passing the contents. JSON requires mapping the fields properly and this is where most people have issues with the API.                Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don't store any of the data within the email. We store some statistics about the call but none of the email content will be store.     Mapping Tips  - -- -- -- -- -- -- -  If you don't have those as options then you can build the JSON structure representing your email and pass it.                You must set the **from_address** field for each email and it must match the signature of the email. We do a lot to try and avoid false matches and this can cause signature match rejections.                 Common Troubleshooting  - -- -- -- -- -- -- -- -- -- -- -- --  **Does the from_address match the signature?**                SigParser is very defensive when attempting to identify a signature to ensure quality data. If the email address in the from_address field doesn't match the email signature then the signature won't be identified.                **Does the from_name match the signature?**                While from_name isn't required it is required that when it is provided that it not be a different person on the email chain.     **Are you setting htmlbody and plainbody properly?**                Almost all email clients will provide you with both the HTML body and the plain text body. You need to use both. Some emails only have HTML, some have plain text and some have both. SigParser will choose which to use but you should be sure to pass both if available.    **Did you properly escape the JSON strings?**    A common issue is not escaping the JSON strings properly before sending the data to SigParser.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiParseEmailContactJSONPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ParseApi();
            var body = new IPaasAPIModelsParseEmailInputModel(); // IPaasAPIModelsParseEmailInputModel |  (optional) 

            try
            {
                // Email signature parser JSON (stateless)
                IPaasAPIModelsParseEmailSignatureV2Model result = apiInstance.ApiParseEmailContactJSONPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParseApi.ApiParseEmailContactJSONPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IPaasAPIModelsParseEmailInputModel**](IPaasAPIModelsParseEmailInputModel.md)|  | [optional] 

### Return type

[**IPaasAPIModelsParseEmailSignatureV2Model**](IPaasAPIModelsParseEmailSignatureV2Model.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiparseemailcontactmimepost"></a>
# **ApiParseEmailContactMIMEPost**
> IPaasAPIModelsParseEmailSignatureV2Model ApiParseEmailContactMIMEPost (System.IO.Stream mimeFile)

Email signature parser MIME/EML (stateless)

Capture the email signature details for the sender of an email. This also will detect inline phone numbers such as \"My phone number is 777-333-4444\".    Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don't store any of the data within the email. We store some statistics about the call but none of the email content will be store.                 Message Body  - -- -- -- -- -- --  The message body should contain the MIME encoded contents only. Do not pass JSON.                *FYI: EML files are just MIME encoded files.*    A MIME email looks like this:                ```  MIME-Version: 1.0  Date: Thu, 9 Sep 2021 15:21:50 -0700  Message-ID: <CAL5Lp9VjUOJyab=+3XQ0ymZMLHT4uC8KGRo1GDLrCQjh07oL6Q@mail.gmail.com>  Subject: Test email  From: Paul Mendoza <pmendoza@sigparser.com>  To: Outlook Tester <outlook.tester@salesforceemail.com>  Content-Type: multipart/alternative; boundary=\"000000000000cd5df405cb976cd0\"    - -000000000000cd5df405cb976cd0  Content-Type: text/plain; charset=\"UTF-8\"    This is a test email.    Thanks  *Paul Mendoza*, Principal Software Engineer    - -000000000000cd5df405cb976cd0  Content-Type: text/html; charset=\"UTF-8\"  Content-Transfer-Encoding: quoted-printable    <div dir=3D\"ltr\">This is a test email.=C2=A0<div><br></div><div>Thanks<br c=  lear=3D\"all\"><div><div dir=3D\"ltr\" class=3D\"gmail_signature\" data-smartmail=  =3D\"gmail_signature\"><div dir=3D\"ltr\"><div dir=3D\"ltr\"><div dir=3D\"ltr\"><di=  v dir=3D\"ltr\"><div dir=3D\"ltr\"><div dir=3D\"ltr\"><div dir=3D\"ltr\"><font colo=  r=3D\"#3d85c6\" face=3D\"tahoma, sans-serif\" style=3D\"font-size:12.8px\"><b>Pau=  l Mendoza</b></font><font color=3D\"#3d85c6\" face=3D\"tahoma, sans-serif\" sty=  le=3D\"font-size:12.8px;font-weight:bold\">,=C2=A0</font><font color=3D\"#3d85=  c6\" face=3D\"tahoma, sans-serif\"><span style=3D\"font-size:12.8px\">Principal =  Software Engineer</span></font></div></div></div></div></div></div></div></=  div></div></div></div>    - -000000000000cd5df405cb976cd0- -    ```

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiParseEmailContactMIMEPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ParseApi();
            var mimeFile = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                // Email signature parser MIME/EML (stateless)
                IPaasAPIModelsParseEmailSignatureV2Model result = apiInstance.ApiParseEmailContactMIMEPost(mimeFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParseApi.ApiParseEmailContactMIMEPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mimeFile** | **System.IO.Stream**|  | [optional] 

### Return type

[**IPaasAPIModelsParseEmailSignatureV2Model**](IPaasAPIModelsParseEmailSignatureV2Model.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiparseemailcontactmsgpost"></a>
# **ApiParseEmailContactMSGPost**
> IPaasAPIModelsParseEmailSignatureV2Model ApiParseEmailContactMSGPost (System.IO.Stream msgFile)

Email signature parser for MSG (stateless)

Capture the email signature details for the sender of an email. This also will detect inline phone numbers such as \"My phone number is 777-333-4444\".     MSG files are an export format from Microsoft Outlook and Exchange exports in some cases. They are binary so you can't look at the files but they should open in Outlook.                Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don't store any of the data within the email. We store some statistics about the call but none of the email content will be store.                 Message Body  - -- -- -- -- -- --  The message body should contain the MSG encoded contents only. Do not pass JSON.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiParseEmailContactMSGPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ParseApi();
            var msgFile = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                // Email signature parser for MSG (stateless)
                IPaasAPIModelsParseEmailSignatureV2Model result = apiInstance.ApiParseEmailContactMSGPost(msgFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParseApi.ApiParseEmailContactMSGPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **msgFile** | **System.IO.Stream**|  | [optional] 

### Return type

[**IPaasAPIModelsParseEmailSignatureV2Model**](IPaasAPIModelsParseEmailSignatureV2Model.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiparseemailmessagejsonpost"></a>
# **ApiParseEmailMessageJSONPost**
> IPaasAPIModelsParseCleanedBodyOutput ApiParseEmailMessageJSONPost (IPaasAPIModelsParseEmailInputModel body)

Split email JSON (stateless)

Parse the email into sections. Also useful if you need to get an email with the email signature stripped off.                 Only use JSON as a last resort  - -- -- -- -- -- -- -  Use MIME or MSG endpoints if you have either of those formats available to you. MIME and MSG just require passing the contents. JSON requires mapping the fields properly and this is where most people have issues with the API.                Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don't store any of the data within the email. We store some statistics about the call but none of the email content will be store.     Mapping Tips  - -- -- -- -- -- -- -  If you don't have those as options then you can build the JSON structure representing your email and pass it.                You must set the **from_address** field for each email and it must match the signature of the email. We do a lot to try and avoid false matches and this can cause signature match rejections.                 Common Troubleshooting  - -- -- -- -- -- -- -- -- -- -- -- --  **Does the from_address match the signature?**                SigParser is very defensive when attempting to identify a signature to ensure quality data. If the email address in the from_address field doesn't match the email signature then the signature won't be identified.                **Does the from_name match the signature?**                While from_name isn't required it is required that when it is provided that it not be a different person on the email chain.     **Are you setting htmlbody and plainbody properly?**                Almost all email clients will provide you with both the HTML body and the plain text body. You need to use both. Some emails only have HTML, some have plain text and some have both. SigParser will choose which to use but you should be sure to pass both if available.    **Did you properly escape the JSON strings?**    A common issue is not escaping the JSON strings properly before sending the data to SigParser.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiParseEmailMessageJSONPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ParseApi();
            var body = new IPaasAPIModelsParseEmailInputModel(); // IPaasAPIModelsParseEmailInputModel |  (optional) 

            try
            {
                // Split email JSON (stateless)
                IPaasAPIModelsParseCleanedBodyOutput result = apiInstance.ApiParseEmailMessageJSONPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParseApi.ApiParseEmailMessageJSONPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IPaasAPIModelsParseEmailInputModel**](IPaasAPIModelsParseEmailInputModel.md)|  | [optional] 

### Return type

[**IPaasAPIModelsParseCleanedBodyOutput**](IPaasAPIModelsParseCleanedBodyOutput.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiparseemailmessagemimepost"></a>
# **ApiParseEmailMessageMIMEPost**
> IPaasAPIModelsParseCleanedBodyOutput ApiParseEmailMessageMIMEPost (System.IO.Stream mimeFile)

Split email EML/MIME (stateless)

Parse the email into sections. Useful if you need to get an email with the email signature stripped off.    Message Body  - -- -- -- -- -- --  The message body form field should contain the MIME encoded contents only. Do not pass JSON.                *FYI: EML files are just MIME encoded files.*    A MIME email looks like this:                ```  MIME-Version: 1.0  Date: Thu, 9 Sep 2021 15:21:50 -0700  Message-ID: <CAL5Lp9VjUOJyab=+3XQ0ymZMLHT4uC8KGRo1GDLrCQjh07oL6Q@mail.gmail.com>  Subject: Test email  From: Paul Mendoza <pmendoza@sigparser.com>  To: Outlook Tester <outlook.tester@salesforceemail.com>  Content-Type: multipart/alternative; boundary=\"000000000000cd5df405cb976cd0\"    - -000000000000cd5df405cb976cd0  Content-Type: text/plain; charset=\"UTF-8\"    This is a test email.    Thanks  *Paul Mendoza*, Principal Software Engineer    - -000000000000cd5df405cb976cd0  Content-Type: text/html; charset=\"UTF-8\"  Content-Transfer-Encoding: quoted-printable    <div dir=3D\"ltr\">This is a test email.=C2=A0<div><br></div><div>Thanks<br c=  lear=3D\"all\"><div><div dir=3D\"ltr\" class=3D\"gmail_signature\" data-smartmail=  =3D\"gmail_signature\"><div dir=3D\"ltr\"><div dir=3D\"ltr\"><div dir=3D\"ltr\"><di=  v dir=3D\"ltr\"><div dir=3D\"ltr\"><div dir=3D\"ltr\"><div dir=3D\"ltr\"><font colo=  r=3D\"#3d85c6\" face=3D\"tahoma, sans-serif\" style=3D\"font-size:12.8px\"><b>Pau=  l Mendoza</b></font><font color=3D\"#3d85c6\" face=3D\"tahoma, sans-serif\" sty=  le=3D\"font-size:12.8px;font-weight:bold\">,=C2=A0</font><font color=3D\"#3d85=  c6\" face=3D\"tahoma, sans-serif\"><span style=3D\"font-size:12.8px\">Principal =  Software Engineer</span></font></div></div></div></div></div></div></div></=  div></div></div></div>    - -000000000000cd5df405cb976cd0- -  ```

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiParseEmailMessageMIMEPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ParseApi();
            var mimeFile = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                // Split email EML/MIME (stateless)
                IPaasAPIModelsParseCleanedBodyOutput result = apiInstance.ApiParseEmailMessageMIMEPost(mimeFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParseApi.ApiParseEmailMessageMIMEPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mimeFile** | **System.IO.Stream**|  | [optional] 

### Return type

[**IPaasAPIModelsParseCleanedBodyOutput**](IPaasAPIModelsParseCleanedBodyOutput.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiparseemailmessagemsgpost"></a>
# **ApiParseEmailMessageMSGPost**
> IPaasAPIModelsParseCleanedBodyOutput ApiParseEmailMessageMSGPost (System.IO.Stream msgFile)

Split email MSG (stateless)

Parse the email into sections. Useful if you need to get an email with the email signature stripped off.                MSG files are an export format from Microsoft Outlook and Exchange exports in some cases. They are binary so you can't look at the files but they should open in Outlook.                Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don't store any of the data within the email. We store some statistics about the call but none of the email content will be store.                 Message Body  - -- -- -- -- -- --  The message body should contain the MSG encoded contents only. Do not pass JSON.

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiParseEmailMessageMSGPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ParseApi();
            var msgFile = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                // Split email MSG (stateless)
                IPaasAPIModelsParseCleanedBodyOutput result = apiInstance.ApiParseEmailMessageMSGPost(msgFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParseApi.ApiParseEmailMessageMSGPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **msgFile** | **System.IO.Stream**|  | [optional] 

### Return type

[**IPaasAPIModelsParseCleanedBodyOutput**](IPaasAPIModelsParseCleanedBodyOutput.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiparsefeedbackpost"></a>
# **ApiParseFeedbackPost**
> IPaasAPIControllersParseControllerFeedbackResponseModel ApiParseFeedbackPost (System.IO.Stream emailcontents, string filetype, string command, string description, string feedbackEmail)

Report parsing feedback

Submit feedback on a parsing issue to SigParser's algorithm development team. This will be added to our queue of emails to investigate.                The email will be stored by SigParser and the development/support teams will be able to see and investigate the issue. You can pass the SIGNATURE only as the emailcontents if you need to.                Parameters  - -- -- -- -- -- -- -- -- -- -  These parameters must all be supplied as FORM values.                - **emailcontents** - File upload of the the JSON, MIME or MSG version of the email. This should be what you submitted to one of the APIs.  - **filetype** - Either MSG, MIME, JSON or SIGNATURE. This should be the format of the file you're uploading.  - **command** - Either \"Contact\" for the signature parsing APIs or \"Message\" for the message splitting APIs.  - **description** - Details about the parsing error. For example, what was the bad value and what did the user expect?  - **feedback_email** - What email address should feedback about this parsing error be sent to?

### Example
```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class ApiParseFeedbackPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: x-api-key
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ParseApi();
            var emailcontents = new System.IO.Stream(); // System.IO.Stream | File contents for MSG or EML file. (optional) 
            var filetype = filetype_example;  // string | Either MSG, MIME, JSON or SIGNATURE. This should be the format of the file you're uploading. (optional) 
            var command = command_example;  // string | Either \"Contact\" for the signature parsing APIs or \"Message\" for the message splitting APIs. (optional) 
            var description = description_example;  // string | Details about the parsing error. For example, what was the bad value and what did the user expect? (optional) 
            var feedbackEmail = feedbackEmail_example;  // string | What email address should feedback about this parsing error be sent to? (optional) 

            try
            {
                // Report parsing feedback
                IPaasAPIControllersParseControllerFeedbackResponseModel result = apiInstance.ApiParseFeedbackPost(emailcontents, filetype, command, description, feedbackEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParseApi.ApiParseFeedbackPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailcontents** | **System.IO.Stream**| File contents for MSG or EML file. | [optional] 
 **filetype** | **string**| Either MSG, MIME, JSON or SIGNATURE. This should be the format of the file you&#39;re uploading. | [optional] 
 **command** | **string**| Either \&quot;Contact\&quot; for the signature parsing APIs or \&quot;Message\&quot; for the message splitting APIs. | [optional] 
 **description** | **string**| Details about the parsing error. For example, what was the bad value and what did the user expect? | [optional] 
 **feedbackEmail** | **string**| What email address should feedback about this parsing error be sent to? | [optional] 

### Return type

[**IPaasAPIControllersParseControllerFeedbackResponseModel**](IPaasAPIControllersParseControllerFeedbackResponseModel.md)

### Authorization

[x-api-key](../README.md#x-api-key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

