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
**InternalContactMostActive** | **string** | The internal contact who has the most active relationship with this company. | [optional] 
**InternalContactLatest** | **string** | The internal contact who has most recently interacted with this company. | [optional] 
**InternalContactLatestDate** | **DateTime?** | The date of the latest communication with this company. | [optional] 
**InternalContactFirst** | **string** | The internal contact who first established communications with this company. | [optional] 
**InternalContactFirstDate** | **DateTime?** | The date of first established communication with this company. | [optional] 
**RelationshipsCoworker** | **int?** | The number of internal contacts who have an established relationship with a contact at this company. | [optional] 
**RelationshipsOther** | **int?** | A count of relationships with this company that are not internal contacts and not within the same company. | [optional] 
**CoworkerRelationshipsEmailaddresses** | **List&lt;string&gt;** | Email addresses of the top 5 Coworkers (internal) to your company who know this contact the best based on interactions. | [optional] 
**CompanyRelationshipsEmailaddresses** | **List&lt;string&gt;** | Email addresses of the top 5 contacts who work at the same company who have been on emails and meetings. | [optional] 
**OtherRelationshipsEmailaddresses** | **List&lt;string&gt;** | Email addresses of the top 5 people who have been on emails with this contact from other companies. | [optional] 
**Tags** | [**List&lt;DragnetTechSharedIPAASModelsTag&gt;**](DragnetTechSharedIPAASModelsTag.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

