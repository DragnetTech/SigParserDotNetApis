# SigParser.Model.IPaasAPIModelsParseCleanedBodyOutput
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | **List&lt;string&gt;** |  | [optional] 
**CleanedBodyPlain** | **string** | The email with the signature and reply chains removed. If the email was originally HTML then this is the HTML converted to text. | [optional] 
**CleanedBodyHtml** | **string** | The body of the email. | [optional] 
**IsSpammyLookingEmailMessage** | **bool?** | Is this email a spammy looking message or a non-human type sender. You likely don&#39;t want to use the CleeanedBody fields when rendering this message but you could if you wanted to. | [optional] 
**IsSpammyLookingSender** | **bool?** | Does the sender of this message look like they&#39;re a spammer. | [optional] 
**EmailTypes** | **List&lt;string&gt;** | The known type of email that this is. Useful for determining how you want to display this in a user interface. Other types will be added over time.                - NormalEmail - A normal email from a human. Over time as we build handlers for new types of emails.  - MeetingNotification  - BouncedNotification  - ZenDeskSupportChain  - SecureMessage - Secure messages only include a link and some way to access the email. These are sensitive emails. | [optional] 
**Emails** | [**List&lt;IPaasAPIModelsParseEmail&gt;**](IPaasAPIModelsParseEmail.md) | Collection of all the emails extracted from the body. The first email is the most recent and the last one is the oldest. The parse quality drops off the deeper you go though since there is a bigger chance for corrupted headers. | [optional] 
**Subject** | **string** | Subject of the email as it was passed into the function or extracted from the header of the email. | [optional] 
**Date** | **DateTime?** |  | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**FullPlainTextBody** | **string** |  | [optional] 
**FullHtmlBody** | **string** |  | [optional] 
**MsgType** | **string** | Type of the .msg file. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

