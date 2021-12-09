# SigParser.Model.DragnetTechSharedIPAASModelsMeetingOutputModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Lastmodified** | **long?** | This should be used to fetch emails with the /api/Emails/Distinct API  When using ingested_after parameter you should save the max ingestion_key value in the response and make the next request with that value in the ingested_after field. | [optional] 
**MailboxInstance** | [**DragnetTechSharedIPAASModelsMeetingOutputModelMailboxInstance**](DragnetTechSharedIPAASModelsMeetingOutputModelMailboxInstance.md) |  | [optional] 
**Subject** | **string** |  | [optional] 
**Start** | **DateTime?** | Time time of the meeting. | [optional] 
**End** | **DateTime?** | End time of the meeting. | [optional] 
**Icaluid** | **string** | A unique ID which can be used to track meetings across calendars. | [optional] 
**Location** | **string** | What is the location of this meeting? | [optional] 
**Recurring** | **bool?** | Is this a recurring meeting? | [optional] 
**Attendees** | [**List&lt;DragnetTechSharedIPAASModelsMeetingOutputModelAttendee&gt;**](DragnetTechSharedIPAASModelsMeetingOutputModelAttendee.md) | All of the invited attendees to the meeting. | [optional] 
**Organizer** | **string** | Email address of the organizer of the meeting? Use this to tell who created the meeting. | [optional] 
**Cancelled** | **DateTime?** | Time the meeting was detected as cancelled.   This time may be delayed from the actual time the meeting was cancelled.    Suggestion: If the meeting is cancelled before the start time you want to ignore this meeting when calculating metrics.  But if the meeting is cancelled after the meeting has taken place you still want to include the meeting in your metrics. | [optional] 
**Sensitivity** | **string** | The sensitivity level for the meeting.     null &#x3D; (default)  \&quot;private\&quot; &#x3D; Google, Office 365, Exchange - This is the value most often used by all connectors.  \&quot;public\&quot; &#x3D; Google  \&quot;personal\&quot; &#x3D; Office 365, Exchange  \&quot;confidential\&quot; &#x3D;  Office 365, Exchange and possible for Google but not really used.                https://developers.google.com/calendar/api/v3/reference/events#resource-representations  https://docs.microsoft.com/en-us/graph/api/resources/event?view&#x3D;graph-rest-beta | [optional] 
**ShowAs** | **string** | The \&quot;show_as\&quot; value for a meeting. This determines how it is displayed in the email application. The value of this largely depends on the type of email API this meeting was consumed from.  Allowed options are:                null &#x3D; Default value.  busy &#x3D; Office 365, Google (most common value)  free &#x3D; Office 365  tentative &#x3D; Office 365, Google  oof &#x3D; Office 365, Google  workingelsewhere &#x3D; Office 365 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

