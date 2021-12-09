using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SigParser.Model {

  /// <summary>
  /// Details about a meeting.     If you are storing this meeting details in your own database you should store the icaluid field as your primary key.
  /// </summary>
  [DataContract]
  public class DragnetTechSharedIPAASModelsMeetingOutputModel {
    /// <summary>
    /// This should be used to fetch emails with the /api/Emails/Distinct API  When using ingested_after parameter you should save the max ingestion_key value in the response and make the next request with that value in the ingested_after field.
    /// </summary>
    /// <value>This should be used to fetch emails with the /api/Emails/Distinct API  When using ingested_after parameter you should save the max ingestion_key value in the response and make the next request with that value in the ingested_after field.</value>
    [DataMember(Name="lastmodified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastmodified")]
    public long? Lastmodified { get; set; }

    /// <summary>
    /// Gets or Sets MailboxInstance
    /// </summary>
    [DataMember(Name="mailbox_instance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mailbox_instance")]
    public DragnetTechSharedIPAASModelsMeetingOutputModelMailboxInstance MailboxInstance { get; set; }

    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subject")]
    public string Subject { get; set; }

    /// <summary>
    /// Time time of the meeting.
    /// </summary>
    /// <value>Time time of the meeting.</value>
    [DataMember(Name="start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start")]
    public DateTime? Start { get; set; }

    /// <summary>
    /// End time of the meeting.
    /// </summary>
    /// <value>End time of the meeting.</value>
    [DataMember(Name="end", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end")]
    public DateTime? End { get; set; }

    /// <summary>
    /// A unique ID which can be used to track meetings across calendars.
    /// </summary>
    /// <value>A unique ID which can be used to track meetings across calendars.</value>
    [DataMember(Name="icaluid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icaluid")]
    public string Icaluid { get; set; }

    /// <summary>
    /// What is the location of this meeting?
    /// </summary>
    /// <value>What is the location of this meeting?</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// Is this a recurring meeting?
    /// </summary>
    /// <value>Is this a recurring meeting?</value>
    [DataMember(Name="recurring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurring")]
    public bool? Recurring { get; set; }

    /// <summary>
    /// All of the invited attendees to the meeting.
    /// </summary>
    /// <value>All of the invited attendees to the meeting.</value>
    [DataMember(Name="attendees", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attendees")]
    public List<DragnetTechSharedIPAASModelsMeetingOutputModelAttendee> Attendees { get; set; }

    /// <summary>
    /// Email address of the organizer of the meeting? Use this to tell who created the meeting.
    /// </summary>
    /// <value>Email address of the organizer of the meeting? Use this to tell who created the meeting.</value>
    [DataMember(Name="organizer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organizer")]
    public string Organizer { get; set; }

    /// <summary>
    /// Time the meeting was detected as cancelled.   This time may be delayed from the actual time the meeting was cancelled.    Suggestion: If the meeting is cancelled before the start time you want to ignore this meeting when calculating metrics.  But if the meeting is cancelled after the meeting has taken place you still want to include the meeting in your metrics.
    /// </summary>
    /// <value>Time the meeting was detected as cancelled.   This time may be delayed from the actual time the meeting was cancelled.    Suggestion: If the meeting is cancelled before the start time you want to ignore this meeting when calculating metrics.  But if the meeting is cancelled after the meeting has taken place you still want to include the meeting in your metrics.</value>
    [DataMember(Name="cancelled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancelled")]
    public DateTime? Cancelled { get; set; }

    /// <summary>
    /// The sensitivity level for the meeting.     null = (default)  \"private\" = Google, Office 365, Exchange - This is the value most often used by all connectors.  \"public\" = Google  \"personal\" = Office 365, Exchange  \"confidential\" =  Office 365, Exchange and possible for Google but not really used.                https://developers.google.com/calendar/api/v3/reference/events#resource-representations  https://docs.microsoft.com/en-us/graph/api/resources/event?view=graph-rest-beta
    /// </summary>
    /// <value>The sensitivity level for the meeting.     null = (default)  \"private\" = Google, Office 365, Exchange - This is the value most often used by all connectors.  \"public\" = Google  \"personal\" = Office 365, Exchange  \"confidential\" =  Office 365, Exchange and possible for Google but not really used.                https://developers.google.com/calendar/api/v3/reference/events#resource-representations  https://docs.microsoft.com/en-us/graph/api/resources/event?view=graph-rest-beta</value>
    [DataMember(Name="sensitivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sensitivity")]
    public string Sensitivity { get; set; }

    /// <summary>
    /// The \"show_as\" value for a meeting. This determines how it is displayed in the email application. The value of this largely depends on the type of email API this meeting was consumed from.  Allowed options are:                null = Default value.  busy = Office 365, Google (most common value)  free = Office 365  tentative = Office 365, Google  oof = Office 365, Google  workingelsewhere = Office 365
    /// </summary>
    /// <value>The \"show_as\" value for a meeting. This determines how it is displayed in the email application. The value of this largely depends on the type of email API this meeting was consumed from.  Allowed options are:                null = Default value.  busy = Office 365, Google (most common value)  free = Office 365  tentative = Office 365, Google  oof = Office 365, Google  workingelsewhere = Office 365</value>
    [DataMember(Name="show_as", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "show_as")]
    public string ShowAs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DragnetTechSharedIPAASModelsMeetingOutputModel {\n");
      sb.Append("  Lastmodified: ").Append(Lastmodified).Append("\n");
      sb.Append("  MailboxInstance: ").Append(MailboxInstance).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  Start: ").Append(Start).Append("\n");
      sb.Append("  End: ").Append(End).Append("\n");
      sb.Append("  Icaluid: ").Append(Icaluid).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Recurring: ").Append(Recurring).Append("\n");
      sb.Append("  Attendees: ").Append(Attendees).Append("\n");
      sb.Append("  Organizer: ").Append(Organizer).Append("\n");
      sb.Append("  Cancelled: ").Append(Cancelled).Append("\n");
      sb.Append("  Sensitivity: ").Append(Sensitivity).Append("\n");
      sb.Append("  ShowAs: ").Append(ShowAs).Append("\n");
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
