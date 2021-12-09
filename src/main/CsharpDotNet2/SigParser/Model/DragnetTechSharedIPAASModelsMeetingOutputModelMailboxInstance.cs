using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SigParser.Model {

  /// <summary>
  /// Connection details about a specific mailbox instance of a meeting.  These details may change for any given icaluid over time if new information  arrives about the meeting from another mailbox.
  /// </summary>
  [DataContract]
  public class DragnetTechSharedIPAASModelsMeetingOutputModelMailboxInstance {
    /// <summary>
    /// ID of the mailbox which is needed for API requests to fetch the meeting record from Google or Office 365
    /// </summary>
    /// <value>ID of the mailbox which is needed for API requests to fetch the meeting record from Google or Office 365</value>
    [DataMember(Name="mailboxid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mailboxid")]
    public string Mailboxid { get; set; }

    /// <summary>
    /// Name of the mailbox. Generally this is an email address.
    /// </summary>
    /// <value>Name of the mailbox. Generally this is an email address.</value>
    [DataMember(Name="mailbox_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mailbox_name")]
    public string MailboxName { get; set; }

    /// <summary>
    /// ID of the meeting that can be used to fetch the meeting from the API.
    /// </summary>
    /// <value>ID of the meeting that can be used to fetch the meeting from the API.</value>
    [DataMember(Name="meetingid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "meetingid")]
    public string Meetingid { get; set; }

    /// <summary>
    /// ID of the calendar the meeting appeared on.
    /// </summary>
    /// <value>ID of the calendar the meeting appeared on.</value>
    [DataMember(Name="calendarid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "calendarid")]
    public string Calendarid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DragnetTechSharedIPAASModelsMeetingOutputModelMailboxInstance {\n");
      sb.Append("  Mailboxid: ").Append(Mailboxid).Append("\n");
      sb.Append("  MailboxName: ").Append(MailboxName).Append("\n");
      sb.Append("  Meetingid: ").Append(Meetingid).Append("\n");
      sb.Append("  Calendarid: ").Append(Calendarid).Append("\n");
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
