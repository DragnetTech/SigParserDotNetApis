# SigParser.Model.IPaasAPIModelsParseEmailInputModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subject** | **string** | Email subject. Not required but should be provided in order to have the \&quot;subject\&quot; field populated in the response for the \&quot;emails\&quot; collection. | [optional] 
**FromAddress** | **string** | The sender of the email. Required for us to match the contact data we find in the root email&#39;s signature with an email address. | [optional] 
**FromName** | **string** | The sender of the email. Important to provide as it helps to identify where the signature starts although sometimes we can find the signature without it. | [optional] 
**Htmlbody** | **string** | Either provide this or the PlainBody or both. This will be used for the email content over the plain body as the HTML is how we can get LinkedIn URLs and Twitter URLs for example. | [optional] 
**Plainbody** | **string** | If there isn&#39;t an HTML body we&#39;ll fallback to this value. If all you can provide is a text body then we can still find phone numbers, titles and addresses but features like LinkedIn URLs and Twitter URLs embedded in HTML won&#39;t be discoverable. | [optional] 
**Date** | **string** | A Date string. For example: 2017-01-01T00:00:00 OR Mon, 28 May 2018 23:33:40 +0000 (UTC)  If either of the two above formats don&#39;t match what you&#39;re providing, we fallback to using the standard .NET parsing to parse this date so you can test that your date works with DotNetFiddle. https://dotnetfiddle.net/sJyTJW | [optional] 
**To** | [**List&lt;IPaasAPIModelsParseEmailInputModelEmailRecipient&gt;**](IPaasAPIModelsParseEmailInputModelEmailRecipient.md) |  | [optional] 
**Cc** | [**List&lt;IPaasAPIModelsParseEmailInputModelEmailRecipient&gt;**](IPaasAPIModelsParseEmailInputModelEmailRecipient.md) |  | [optional] 
**Options** | [**IPaasAPIModelsParseEmailInputModelOutputOptions**](IPaasAPIModelsParseEmailInputModelOutputOptions.md) |  | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

