# SigParser.Model.DragnetTechSharedIPAASModelsEmailOutputModelMailbox
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mailboxtype** | **string** | Google, Office365, IMAP, Exchange, PST | [optional] 
**Mailboxid** | **string** |  | [optional] 
**MailboxName** | **string** | Name of the emailbox where the email came from. This is almost always the email address. | [optional] 
**Messageid** | **string** | ID for the message in the email account. This ID could be used to query the message from the Gmail API or from the Office 365 Graph API.   If this is an IMAP account it will be a UID number. | [optional] 
**Conversationid** | **string** | The mailbox specific conversation ID for this instance of the message. | [optional] 
**Id** | **Guid?** | SigParser internal ID for the email. Use this when fetching a particular email. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

