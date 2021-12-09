# SigParser.Model.DragnetTechSharedIPAASModelsCompanyOutputModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Valid, Other, Coworker, Private, Ignore.    Other possible values may be added later. | [optional] 
**Name** | **string** | The best name SigParser has found or that has been set by a user. | [optional] 
**Lastmodified** | **long?** | Numeric value representing when this record was last modified.   This has precision down to the millisecond so you shouldn&#39;t convert it to a date with less precision. | [optional] 
**Contacts** | **int?** | Number of Valid or Other contacts on this account. Coworker, Private and Ignore contacts are ignored when counting. | [optional] 
**InboundEmails** | **int?** | Total emails from people at this company to your company. | [optional] 
**OutboundEmails** | **int?** | Total emails from your company to this company. | [optional] 
**Meetings** | **int?** | Meetings with this company&#39;s employees. | [optional] 
**LastInteraction** | **DateTime?** | Last time there was an email or a meeting with this company. | [optional] 
**Domain** | **string** | The email domain name for this company.   This is a primary key for the table so if the company has multiple domain names then there will be a Company record for each domain. | [optional] 
**ClosestInternalContact** | **string** | Email address of someone in your company with the best relationsip with this account. | [optional] 
**Tags** | [**List&lt;DragnetTechSharedIPAASModelsTag&gt;**](DragnetTechSharedIPAASModelsTag.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

