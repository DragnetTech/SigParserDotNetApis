# SigParser.Model.IPaasAPIModelsParseEmailInputModelOutputOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OutputCleanedEmailHtmlDepth** | **int?** | Performance setting (default 1): Control to what depth the fields cleanedemailbody, emails.cleanedBodyHTML are generated with HTML.                Generating these fields can be expensive so this is meant to help improve performance for some customers that don&#39;t need these fields.                0 would mean no HTML output. 1 would mean only the root email gets a cleaned version. 2 means the root email and the next previous email in the chain.                The plain text versions will still be set.                If you don&#39;t ever need the data in these fields then set to 0 to get a slightly faster average response. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

