# SigParser.Model.IPaasAPIModelsParseEmailSignatureV2Model
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromAddress** | **string** | Email address of the sender of the email. | [optional] 
**FromDisplayname** | **string** | Display name for the sender of the email. | [optional] 
**CompanyName** | **string** | The best matched company name from the email signature. Be warned that this isn&#39;t always a great match.                We suggest using a data vendor like Brandfetch or the free Creative Commons dataset from People Data Labs first and only using the company name from SigParser to fill in the gaps. | [optional] 
**JobTitle** | **string** | Job title for the sender of the email. | [optional] 
**Phones** | [**List&lt;IPaasAPIModelsParseEmailSignatureV2ModelPhoneDetails&gt;**](IPaasAPIModelsParseEmailSignatureV2ModelPhoneDetails.md) |  | [optional] 
**Address** | **string** | The full address extracted from the signature. | [optional] 
**AddressParts** | [**IPaasAPIModelsParseEmailSignatureV2ModelAddressParts**](IPaasAPIModelsParseEmailSignatureV2ModelAddressParts.md) |  | [optional] 
**Links** | [**List&lt;IPaasAPIModelsParseEmailSignatureV2ModelLink&gt;**](IPaasAPIModelsParseEmailSignatureV2ModelLink.md) |  | [optional] 
**Signature** | **string** | The lines for the signature. | [optional] 
**Errors** | **List&lt;string&gt;** | Array of error messages if there are any issues. | [optional] 
**Duration** | **long?** | Duration in milliseconds it took to process the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

