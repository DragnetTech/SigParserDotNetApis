# SigParser.Model.IPaasAPIModelsParseEmail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CleanedBodyPlain** | **string** | Email without the signature | [optional] 
**CleanedBodyHtml** | **string** | Email without the signature | [optional] 
**BodyPlain** | **string** | Plain text version of the body of this email with the reply chain stripped off but includes the signature. This should always be populated. | [optional] 
**BodyHtml** | **string** | SigParser&#39;s attempt at producing an HTML email body for just this email or reply chain email. Only produced if the original email was HTML.  Will not include the reply headers like \&quot;From\&quot; and \&quot;To\&quot; or \&quot;Email sent from...\&quot;. Email signature is not stripped out. Cannot handle emails with  namespaces in the HTML which is rare but can happen. In cases where the email can&#39;t be parsed, the original full HTML will be included in the first section. | [optional] 
**Subject** | **string** |  | [optional] 
**Date** | **DateTime?** | Date is only available if it was parsed out from the email or if it was passed in for the root email. | [optional] 
**FromEmailAddress** | **string** |  | [optional] 
**FromName** | **string** |  | [optional] 
**To** | [**List&lt;IPaasAPIModelsParseEmailRecipient&gt;**](IPaasAPIModelsParseEmailRecipient.md) |  | [optional] 
**Cc** | [**List&lt;IPaasAPIModelsParseEmailRecipient&gt;**](IPaasAPIModelsParseEmailRecipient.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

