# SigParser - the C# library for the SigParser API

This library makes it easy for .NET applications to consume the various SigParser APIs. You'll need to generate an API key in order to use these APIs.

Install from Nuget: https://www.nuget.org/packages/SigParser/


<a name="getting-started"></a>
## Getting Started

```csharp
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;
```

```csharp
using System;
using System.Diagnostics;
using SigParser.Api;
using SigParser.Client;
using SigParser.Model;

namespace Example
{
    public class Example
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
                List<DragnetTechSharedIPAASModelsCompanyOutputModel> result = apiInstance.ApiCompaniesGet(lastmodifiedAfter, take, domain);
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://ipaas.sigparer.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CompaniesApi* | [**ApiCompaniesGet**](docs/CompaniesApi.md#apicompaniesget) | **GET** /api/Companies | Fetch details about companies by the email domain.
*ContactsApi* | [**ApiContactsListPost**](docs/ContactsApi.md#apicontactslistpost) | **POST** /api/Contacts/List | Get Contact Details based on the Parameter set     Order by allowed is lastmodified
*ContactsApi* | [**ApiContactsPost**](docs/ContactsApi.md#apicontactspost) | **POST** /api/Contacts | Insert/Updates a contact by email address
*ContactsApi* | [**ApiContactsTagListGet**](docs/ContactsApi.md#apicontactstaglistget) | **GET** /api/Contacts/Tag/List | Get list of tags defined in SigParser.
*ContactsApi* | [**ApiContactsTagPost**](docs/ContactsApi.md#apicontactstagpost) | **POST** /api/Contacts/Tag | Performs an operation to tag / untag a contact. Tags can have different types which is why you have to pass the ID instead of the name of the tag.
*EmailsApi* | [**ApiEmailsDistinctGet**](docs/EmailsApi.md#apiemailsdistinctget) | **GET** /api/Emails/Distinct | Fetch distinct emails across all the mailboxes. If the same emails is found in 10 mailboxes then only one instance of it will be returned.
*MeetingsApi* | [**ApiMeetingsDistinctGet**](docs/MeetingsApi.md#apimeetingsdistinctget) | **GET** /api/Meetings/Distinct | Fetch distinct meetings across all the mailboxes. If the same meeting is found in multiple mailboxes then you'll only get one reference to it.
*ParseApi* | [**ApiEmailPost**](docs/ParseApi.md#apiemailpost) | **POST** /api/Email | Legacy email parsing API. Obselete.
*ParseApi* | [**ApiMimeParseStringPost**](docs/ParseApi.md#apimimeparsestringpost) | **POST** /api/Mime/ParseString | Legacy email parsing API for MIME. Obsolete.
*ParseApi* | [**ApiParseEmailContactJSONPost**](docs/ParseApi.md#apiparseemailcontactjsonpost) | **POST** /api/Parse/Email/Contact/JSON | Email signature parser JSON (stateless)
*ParseApi* | [**ApiParseEmailContactMIMEPost**](docs/ParseApi.md#apiparseemailcontactmimepost) | **POST** /api/Parse/Email/Contact/MIME | Email signature parser MIME/EML (stateless)
*ParseApi* | [**ApiParseEmailContactMSGPost**](docs/ParseApi.md#apiparseemailcontactmsgpost) | **POST** /api/Parse/Email/Contact/MSG | Email signature parser for MSG (stateless)
*ParseApi* | [**ApiParseEmailMessageJSONPost**](docs/ParseApi.md#apiparseemailmessagejsonpost) | **POST** /api/Parse/Email/Message/JSON | Split email JSON (stateless)
*ParseApi* | [**ApiParseEmailMessageMIMEPost**](docs/ParseApi.md#apiparseemailmessagemimepost) | **POST** /api/Parse/Email/Message/MIME | Split email EML/MIME (stateless)
*ParseApi* | [**ApiParseEmailMessageMSGPost**](docs/ParseApi.md#apiparseemailmessagemsgpost) | **POST** /api/Parse/Email/Message/MSG | Split email MSG (stateless)
*ParseApi* | [**ApiParseFeedbackPost**](docs/ParseApi.md#apiparsefeedbackpost) | **POST** /api/Parse/Feedback | Report parsing feedback
*UserApi* | [**ApiUserInvalidateDelete**](docs/UserApi.md#apiuserinvalidatedelete) | **DELETE** /api/User/Invalidate | Revoke the data access API key for this request. Doesn't revoke the email parsing API key. OAuth providers should try to call this when disconnecting a connection if possible.
*UserApi* | [**ApiUserMeGet**](docs/UserApi.md#apiusermeget) | **GET** /api/User/Me | Get the User Information [ Username , EnterpriseId ]
*WebhooksApi* | [**ApiWebhooksDelete**](docs/WebhooksApi.md#apiwebhooksdelete) | **DELETE** /api/Webhooks | Delete the webhook.
*WebhooksApi* | [**ApiWebhooksGet**](docs/WebhooksApi.md#apiwebhooksget) | **GET** /api/Webhooks | Get a webhook by ID.
*WebhooksApi* | [**ApiWebhooksListGet**](docs/WebhooksApi.md#apiwebhookslistget) | **GET** /api/Webhooks/List | List all the webhooks for the current team.
*WebhooksApi* | [**ApiWebhooksPost**](docs/WebhooksApi.md#apiwebhookspost) | **POST** /api/Webhooks | Create a new webhook. See the \"action\" parameter for the types (contacts, companies, meetings, emails...) of webhooks.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [SigParser.Model.DragnetTechSharedContactOutputModel](docs/DragnetTechSharedContactOutputModel.md)
 - [SigParser.Model.DragnetTechSharedIPAASModelsCompanyOutputModel](docs/DragnetTechSharedIPAASModelsCompanyOutputModel.md)
 - [SigParser.Model.DragnetTechSharedIPAASModelsEmailOutputModel](docs/DragnetTechSharedIPAASModelsEmailOutputModel.md)
 - [SigParser.Model.DragnetTechSharedIPAASModelsEmailOutputModelAttachment](docs/DragnetTechSharedIPAASModelsEmailOutputModelAttachment.md)
 - [SigParser.Model.DragnetTechSharedIPAASModelsEmailOutputModelMailbox](docs/DragnetTechSharedIPAASModelsEmailOutputModelMailbox.md)
 - [SigParser.Model.DragnetTechSharedIPAASModelsEmailOutputModelPerson](docs/DragnetTechSharedIPAASModelsEmailOutputModelPerson.md)
 - [SigParser.Model.DragnetTechSharedIPAASModelsMeetingOutputModel](docs/DragnetTechSharedIPAASModelsMeetingOutputModel.md)
 - [SigParser.Model.DragnetTechSharedIPAASModelsMeetingOutputModelAttendee](docs/DragnetTechSharedIPAASModelsMeetingOutputModelAttendee.md)
 - [SigParser.Model.DragnetTechSharedIPAASModelsMeetingOutputModelMailboxInstance](docs/DragnetTechSharedIPAASModelsMeetingOutputModelMailboxInstance.md)
 - [SigParser.Model.DragnetTechSharedIPAASModelsRequestContactParam](docs/DragnetTechSharedIPAASModelsRequestContactParam.md)
 - [SigParser.Model.DragnetTechSharedIPAASModelsTag](docs/DragnetTechSharedIPAASModelsTag.md)
 - [SigParser.Model.DragnetTechSharedRelationshipHistory](docs/DragnetTechSharedRelationshipHistory.md)
 - [SigParser.Model.DragnetTechSharedRelationshipMetric](docs/DragnetTechSharedRelationshipMetric.md)
 - [SigParser.Model.IPaasAPIControllersContactsControllerContactUpsertModel](docs/IPaasAPIControllersContactsControllerContactUpsertModel.md)
 - [SigParser.Model.IPaasAPIControllersContactsControllerCustomTagList](docs/IPaasAPIControllersContactsControllerCustomTagList.md)
 - [SigParser.Model.IPaasAPIControllersContactsControllerTagRequestParam](docs/IPaasAPIControllersContactsControllerTagRequestParam.md)
 - [SigParser.Model.IPaasAPIControllersContactsControllerTagRequestResponse](docs/IPaasAPIControllersContactsControllerTagRequestResponse.md)
 - [SigParser.Model.IPaasAPIControllersParseControllerFeedbackResponseModel](docs/IPaasAPIControllersParseControllerFeedbackResponseModel.md)
 - [SigParser.Model.IPaasAPIControllersUserControllerReturnMe](docs/IPaasAPIControllersUserControllerReturnMe.md)
 - [SigParser.Model.IPaasAPIControllersWebhooksControllerDeleteResponse](docs/IPaasAPIControllersWebhooksControllerDeleteResponse.md)
 - [SigParser.Model.IPaasAPIControllersWebhooksControllerWebhookPostParam](docs/IPaasAPIControllersWebhooksControllerWebhookPostParam.md)
 - [SigParser.Model.IPaasAPIControllersWebhooksControllerWebhookReturnModel](docs/IPaasAPIControllersWebhooksControllerWebhookReturnModel.md)
 - [SigParser.Model.IPaasAPIModelsParseCleanedBodyOutput](docs/IPaasAPIModelsParseCleanedBodyOutput.md)
 - [SigParser.Model.IPaasAPIModelsParseEmail](docs/IPaasAPIModelsParseEmail.md)
 - [SigParser.Model.IPaasAPIModelsParseEmailInputModel](docs/IPaasAPIModelsParseEmailInputModel.md)
 - [SigParser.Model.IPaasAPIModelsParseEmailInputModelEmailRecipient](docs/IPaasAPIModelsParseEmailInputModelEmailRecipient.md)
 - [SigParser.Model.IPaasAPIModelsParseEmailInputModelOutputOptions](docs/IPaasAPIModelsParseEmailInputModelOutputOptions.md)
 - [SigParser.Model.IPaasAPIModelsParseEmailRecipient](docs/IPaasAPIModelsParseEmailRecipient.md)
 - [SigParser.Model.IPaasAPIModelsParseEmailSignatureV2Model](docs/IPaasAPIModelsParseEmailSignatureV2Model.md)
 - [SigParser.Model.IPaasAPIModelsParseEmailSignatureV2ModelAddressParts](docs/IPaasAPIModelsParseEmailSignatureV2ModelAddressParts.md)
 - [SigParser.Model.IPaasAPIModelsParseEmailSignatureV2ModelLink](docs/IPaasAPIModelsParseEmailSignatureV2ModelLink.md)
 - [SigParser.Model.IPaasAPIModelsParseEmailSignatureV2ModelPhoneDetails](docs/IPaasAPIModelsParseEmailSignatureV2ModelPhoneDetails.md)
 - [SigParser.Model.SigParserAddressParts](docs/SigParserAddressParts.md)
 - [SigParser.Model.SigParserCc](docs/SigParserCc.md)
 - [SigParser.Model.SigParserContact](docs/SigParserContact.md)
 - [SigParser.Model.SigParserEmail](docs/SigParserEmail.md)
 - [SigParser.Model.SigParserEmailParseResponse](docs/SigParserEmailParseResponse.md)
 - [SigParser.Model.SigParserTo](docs/SigParserTo.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="x-api-key"></a>
### x-api-key

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header


# Generated Information
This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: v1
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CsharpDotNet2ClientCodegen