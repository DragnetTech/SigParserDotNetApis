# SigParser.Model.DragnetTechSharedIPAASModelsEmailOutputModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IngestionKey** | **long?** | This should be used to fetch emails with the /api/Emails/Distinct API  When using ingested_after parameter you should save the max ingestion_key value in the response and make the next request with that value in the ingested_after field. | [optional] 
**Mailboxinstance** | [**DragnetTechSharedIPAASModelsEmailOutputModelMailbox**](DragnetTechSharedIPAASModelsEmailOutputModelMailbox.md) |  | [optional] 
**Date** | **DateTime?** | Date and time for the email. | [optional] 
**From** | [**DragnetTechSharedIPAASModelsEmailOutputModelPerson**](DragnetTechSharedIPAASModelsEmailOutputModelPerson.md) |  | [optional] 
**To** | [**List&lt;DragnetTechSharedIPAASModelsEmailOutputModelPerson&gt;**](DragnetTechSharedIPAASModelsEmailOutputModelPerson.md) | People in the \&quot;To\&quot; field | [optional] 
**Cc** | [**List&lt;DragnetTechSharedIPAASModelsEmailOutputModelPerson&gt;**](DragnetTechSharedIPAASModelsEmailOutputModelPerson.md) | People in the \&quot;CC\&quot; field. | [optional] 
**Attachments** | [**List&lt;DragnetTechSharedIPAASModelsEmailOutputModelAttachment&gt;**](DragnetTechSharedIPAASModelsEmailOutputModelAttachment.md) | All of the attachements on this email. Does not include embedded attachments. | [optional] 
**Subject** | **string** | Subject line for the email. | [optional] 
**References** | **List&lt;string&gt;** | The Message-IDs of other messages in the reply chain. https://datatracker.ietf.org/doc/html/rfc4021#page-11 | [optional] 
**InReplyTo** | **string** | Message-ID of the email that this email was in response to. | [optional] 
**InternetMessageid** | **string** | This comes from the MIME Message-ID field. This is a globally unique value. Although it&#39;s optional most messages will have this.  See https://datatracker.ietf.org/doc/html/rfc2392#section-2 | [optional] 
**ConversationIndex** | **int?** | Zero based index for the position of the email in an email chain. Can be null. This is a calculated value. | [optional] 
**VirtualConversationid** | **string** | A derived conversation ID for this email conversation. This can change for a message if a new root message is discovered later. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

