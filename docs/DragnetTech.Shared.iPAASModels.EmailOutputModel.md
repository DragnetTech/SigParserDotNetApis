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

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

