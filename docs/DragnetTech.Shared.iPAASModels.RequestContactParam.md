# SigParser.Model.DragnetTechSharedIPAASModelsRequestContactParam
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpandRelationshipMetricsType** | **string** | Which contacts should be in the \&quot;relationship_metrics\&quot; field.    INTERNAL &#x3D; Only contacts internal to your organization (ie. your coworkers).   EXTERNAL &#x3D; Only contacts within your organization.  ALL &#x3D; Both INTERNAL and EXTERNAL contacts. | [optional] 
**IncludeIncorrectlyParsedContacts** | **bool?** | Should SigParser return contacts it thinks might have email parsing errors. For example, bad phone numbers. Default \&quot;false\&quot; | [optional] 
**Orderby** | **string** | Order by options:                - lastmodified - Date the contact was last modified (great for fetching a delta of contact changes).  - created - Date the contact was created in SigParser.  - interactions - Total number of emails + meetings the contact has appeared on.    Defaults to lastmodified | [optional] 
**Orderbyasc** | **bool?** | Determines the direction of the sort. | [optional] 
**Page** | **int?** | Page 1 is the first page of results. | [optional] 
**Take** | **int?** | How many records per page. If using \&quot;lastmodified_after\&quot; then this is always at least 25. Max 200. If expand_relationship_metrics is | [optional] 
**Tagid** | **Guid?** | This is the ID of the tag. A tag can have types. This isn&#39;t the name of the tag. It will look like a uuid/Guid | [optional] 
**Emailaddress** | **string** | Find a single contact record by email address. Matches exactly.   We store all email addresses as lowercase so we&#39;ll convert this to lowercase if it uppercase. | [optional] 
**LastmodifiedAfter** | **DateTime?** | Only get contacts with a lastmodified date greater than or equal to this date. If \&quot;take\&quot; is less than 25 then 25 will be used as the \&quot;take\&quot;.  This is a special attribute that allows you to get recently modified contacts. Just store the max value from the last request and use it with the next request. | [optional] 
**ExpandRelationshipMetrics** | **bool?** | Include the relationship_metrics array on each contact in the response. Default &#x3D; false.  This can add a lot of size to the response payload so  so it is suggest you not include it when you don&#39;t need it. | [optional] 
**ExpandRelationshipMetricsHistory** | **bool?** | Expand the history within the relationship metrics. This may expand the response size of the request considerably. | [optional] 
**IncludeSpamContacts** | **bool?** | Should SigParser return contacts it thinks are bots or not real relationship contacts. Default \&quot;false\&quot; | [optional] 
**Domain** | **string** | Fetch contacts by email domain. Won&#39;t return contacts in an email domain that is public like gmail.com or yahoo.com.  The @ symbol is optional. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

