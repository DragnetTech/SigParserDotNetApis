# SigParser.Model.IPaasAPIModelsParseEmailSignatureV2Model
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromAddress** | **string** | Email address of the sender of the email. | [optional] 
**FromDisplayname** | **string** | Display name for the sender of the email. | [optional] 
**JobTitle** | **string** | Job title for the sender of the email. | [optional] 
**Phones** | [**List&lt;IPaasAPIModelsParseEmailSignatureV2ModelPhoneDetails&gt;**](IPaasAPIModelsParseEmailSignatureV2ModelPhoneDetails.md) |  | [optional] 
**Address** | **string** | The full address extracted from the signature. | [optional] 
**AddressParts** | [**IPaasAPIModelsParseEmailSignatureV2ModelAddressParts**](IPaasAPIModelsParseEmailSignatureV2ModelAddressParts.md) |  | [optional] 
**Links** | [**List&lt;IPaasAPIModelsParseEmailSignatureV2ModelLink&gt;**](IPaasAPIModelsParseEmailSignatureV2ModelLink.md) |  | [optional] 
**Signature** | **string** | The lines for the signature. | [optional] 
**Errors** | **List&lt;string&gt;** | Array of error messages if there are any issues. | [optional] 
**Duration** | **long?** | Duration in milliseconds it took to process the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

