# SigParser.Model.IPaasAPIControllersWebhooksControllerWebhookPostParam
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | The URL to post the webhook to. | [optional] 
**Action** | **string** | Must be one of: contact.createorupdate, company.createorupdate, email.new.distinct, meeting.new.distinct, meeting.updated.distinct, meeting.deleted.distinct | [optional] 
**HasPhoneNumber** | **bool?** | contact.createorupdate - this says the contact must have a phone number. If false then contacts then contacts with or without phone numbers will be returned. | [optional] 
**HasOutboundEmails** | **bool?** | contact.createorupdate - this says the contact must have at least 1 outbound email. If false the contacts with or without outbounde emails will be returned. | [optional] 
**HasInboundEmails** | **bool?** | contact.createorupdate - this says the contact must have at least 1 inbound email. If true the contacts with or without inbound emails will be returned. | [optional] 
**BatchFrequencyCronExpression** | **string** | contact.createorupdate and company.createorupdate - Determines the cron frequency which this webhook will be checked and events pushed to your endpoint.  This helps to reduce the volume of requests going to your server. For example, SigParser may see the same contact being emailed over and over again during the  day so you may not want every update, especially if you have to pay for each webhook.     Times are always evaluated based on UTC time.    This cron expression doesn&#39;t include seconds. You could use patterns such as \&quot;@weekly\&quot;, \&quot;@daily\&quot; or \&quot;@hourly\&quot; or even an expression such as \&quot;0 2 * * *\&quot; for every 2 hours.    SigParser won&#39;t kickoff a webhook job more than once every 15 minutes.     Default: \&quot;@daily\&quot; if not supplied which is midnight UTC. For example, 12 AM (minight) UTC is around 5 PM Pacific Time depending on the time of year. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

