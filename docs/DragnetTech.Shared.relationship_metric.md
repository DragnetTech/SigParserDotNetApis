# SigParser.Model.DragnetTechSharedRelationshipMetric
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Otherperson** | **string** | Email address of the other person in this relationship. | [optional] 
**Type** | **string** | String value indicating the type of relationship with this contact | [optional] 
**Isotherpersoninternal** | **bool?** | Is the \&quot;otherperson\&quot; record an internal contact? These are often the most important relationships you want to look at. | [optional] 
**Name** | **string** | String value indicating most up to date \&quot;Name\&quot; for this contact. | [optional] 
**Title** | **string** | String value indicating most up to date \&quot;Title\&quot; for this contact. | [optional] 
**Emails** | **int?** | Number of emails between these two people. | [optional] 
**PersonSent** | **int?** | Times person sent otherperson an email | [optional] 
**PersonCc** | **int?** | Times person CC&#39;d otherperson | [optional] 
**PersonSentLast** | **DateTime?** | Last time person sent otherperson an email. | [optional] 
**PersonCcLast** | **DateTime?** | Last time person CC&#39;d otherperson | [optional] 
**PersonSentFirst** | **DateTime?** | First email person sent to otherperson | [optional] 
**OtherSent** | **int?** | Times otherperson sent person an email | [optional] 
**OtherCc** | **int?** | Times otherperson CC&#39;d person | [optional] 
**OtherSentLast** | **DateTime?** | Last time otherperson sent person an email | [optional] 
**OtherCcLast** | **DateTime?** | Last time otherperson CC&#39;d person | [optional] 
**OtherSentFirst** | **DateTime?** | First email otherperson sent to person | [optional] 
**Meetings** | **int?** | How many meetings were they on together? | [optional] 
**Lastmeeting** | **DateTime?** | Date of the last meeting | [optional] 
**Firstmeeting** | **DateTime?** | Date of the first detected meeting | [optional] 
**History** | [**List&lt;DragnetTechSharedRelationshipHistory&gt;**](DragnetTechSharedRelationshipHistory.md) | The history of the relationship by months. Months with no activity are not returned.    By default this isn&#39;t returned. To get this returned you must set expand_relationship_metrics_history &#x3D; true.  You can&#39;t set expand_relationship_metrics_history &#x3D; true and expand_relationship_metrics &#x3D; false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

