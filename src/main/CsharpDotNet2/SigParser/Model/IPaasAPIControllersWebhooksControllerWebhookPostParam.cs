using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SigParser.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class IPaasAPIControllersWebhooksControllerWebhookPostParam {
    /// <summary>
    /// The URL to post the webhook to.
    /// </summary>
    /// <value>The URL to post the webhook to.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Must be one of: contact.createorupdate, company.createorupdate, email.new.distinct, meeting.new.distinct, meeting.updated.distinct, meeting.deleted.distinct
    /// </summary>
    /// <value>Must be one of: contact.createorupdate, company.createorupdate, email.new.distinct, meeting.new.distinct, meeting.updated.distinct, meeting.deleted.distinct</value>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public string Action { get; set; }

    /// <summary>
    /// contact.createorupdate - this says the contact must have a phone number. If false then contacts then contacts with or without phone numbers will be returned.
    /// </summary>
    /// <value>contact.createorupdate - this says the contact must have a phone number. If false then contacts then contacts with or without phone numbers will be returned.</value>
    [DataMember(Name="hasPhoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasPhoneNumber")]
    public bool? HasPhoneNumber { get; set; }

    /// <summary>
    /// contact.createorupdate - this says the contact must have at least 1 outbound email. If false the contacts with or without outbounde emails will be returned.
    /// </summary>
    /// <value>contact.createorupdate - this says the contact must have at least 1 outbound email. If false the contacts with or without outbounde emails will be returned.</value>
    [DataMember(Name="hasOutboundEmails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasOutboundEmails")]
    public bool? HasOutboundEmails { get; set; }

    /// <summary>
    /// contact.createorupdate - this says the contact must have at least 1 inbound email. If true the contacts with or without inbound emails will be returned.
    /// </summary>
    /// <value>contact.createorupdate - this says the contact must have at least 1 inbound email. If true the contacts with or without inbound emails will be returned.</value>
    [DataMember(Name="hasInboundEmails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasInboundEmails")]
    public bool? HasInboundEmails { get; set; }

    /// <summary>
    /// contact.createorupdate and company.createorupdate - Determines the cron frequency which this webhook will be checked and events pushed to your endpoint.  This helps to reduce the volume of requests going to your server. For example, SigParser may see the same contact being emailed over and over again during the  day so you may not want every update, especially if you have to pay for each webhook.     Times are always evaluated based on UTC time.    This cron expression doesn't include seconds. You could use patterns such as \"@weekly\", \"@daily\" or \"@hourly\" or even an expression such as \"0 2 * * *\" for every 2 hours.    SigParser won't kickoff a webhook job more than once every 15 minutes.     Default: \"@daily\" if not supplied which is midnight UTC. For example, 12 AM (minight) UTC is around 5 PM Pacific Time depending on the time of year.
    /// </summary>
    /// <value>contact.createorupdate and company.createorupdate - Determines the cron frequency which this webhook will be checked and events pushed to your endpoint.  This helps to reduce the volume of requests going to your server. For example, SigParser may see the same contact being emailed over and over again during the  day so you may not want every update, especially if you have to pay for each webhook.     Times are always evaluated based on UTC time.    This cron expression doesn't include seconds. You could use patterns such as \"@weekly\", \"@daily\" or \"@hourly\" or even an expression such as \"0 2 * * *\" for every 2 hours.    SigParser won't kickoff a webhook job more than once every 15 minutes.     Default: \"@daily\" if not supplied which is midnight UTC. For example, 12 AM (minight) UTC is around 5 PM Pacific Time depending on the time of year.</value>
    [DataMember(Name="batch_frequency_cron_expression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batch_frequency_cron_expression")]
    public string BatchFrequencyCronExpression { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IPaasAPIControllersWebhooksControllerWebhookPostParam {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  HasPhoneNumber: ").Append(HasPhoneNumber).Append("\n");
      sb.Append("  HasOutboundEmails: ").Append(HasOutboundEmails).Append("\n");
      sb.Append("  HasInboundEmails: ").Append(HasInboundEmails).Append("\n");
      sb.Append("  BatchFrequencyCronExpression: ").Append(BatchFrequencyCronExpression).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
