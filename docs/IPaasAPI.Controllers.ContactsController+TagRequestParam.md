# SigParser.Model.IPaasAPIControllersContactsControllerTagRequestParam
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TagId** | **Guid?** | The ID of the tag. You can get this by either calling the Tag/List method OR in the SigParser app by opening a tag details page and getting it from the URL. | [optional] 
**Emailaddresses** | **List&lt;string&gt;** | A list of email addresses to either Tag or Untag. We suggest only sending 250 or so email addresses at a time. It is safe to call this repeatedly on a contact as it won&#39;t duplicate tags. | [optional] 
**Operation** | **string** | Either the word \&quot;Tag\&quot; or \&quot;Untag\&quot; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

