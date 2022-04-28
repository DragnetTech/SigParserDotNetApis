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
  public class DragnetTechSharedRelationshipMetric {
    /// <summary>
    /// Email address of the other person in this relationship.
    /// </summary>
    /// <value>Email address of the other person in this relationship.</value>
    [DataMember(Name="otherperson", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otherperson")]
    public string Otherperson { get; set; }

    /// <summary>
    /// String value indicating the type of relationship with this contact
    /// </summary>
    /// <value>String value indicating the type of relationship with this contact</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Is the \"otherperson\" record an internal contact? These are often the most important relationships you want to look at.
    /// </summary>
    /// <value>Is the \"otherperson\" record an internal contact? These are often the most important relationships you want to look at.</value>
    [DataMember(Name="isotherpersoninternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isotherpersoninternal")]
    public bool? Isotherpersoninternal { get; set; }

    /// <summary>
    /// String value indicating most up to date \"Name\" for this contact.
    /// </summary>
    /// <value>String value indicating most up to date \"Name\" for this contact.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// String value indicating most up to date \"Title\" for this contact.
    /// </summary>
    /// <value>String value indicating most up to date \"Title\" for this contact.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Number of emails between these two people.
    /// </summary>
    /// <value>Number of emails between these two people.</value>
    [DataMember(Name="emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emails")]
    public int? Emails { get; set; }

    /// <summary>
    /// Times person sent otherperson an email
    /// </summary>
    /// <value>Times person sent otherperson an email</value>
    [DataMember(Name="person_sent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "person_sent")]
    public int? PersonSent { get; set; }

    /// <summary>
    /// Times person CC'd otherperson
    /// </summary>
    /// <value>Times person CC'd otherperson</value>
    [DataMember(Name="person_cc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "person_cc")]
    public int? PersonCc { get; set; }

    /// <summary>
    /// Last time person sent otherperson an email.
    /// </summary>
    /// <value>Last time person sent otherperson an email.</value>
    [DataMember(Name="person_sent_last", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "person_sent_last")]
    public DateTime? PersonSentLast { get; set; }

    /// <summary>
    /// Last time person CC'd otherperson
    /// </summary>
    /// <value>Last time person CC'd otherperson</value>
    [DataMember(Name="person_cc_last", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "person_cc_last")]
    public DateTime? PersonCcLast { get; set; }

    /// <summary>
    /// First email person sent to otherperson
    /// </summary>
    /// <value>First email person sent to otherperson</value>
    [DataMember(Name="person_sent_first", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "person_sent_first")]
    public DateTime? PersonSentFirst { get; set; }

    /// <summary>
    /// Times otherperson sent person an email
    /// </summary>
    /// <value>Times otherperson sent person an email</value>
    [DataMember(Name="other_sent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "other_sent")]
    public int? OtherSent { get; set; }

    /// <summary>
    /// Times otherperson CC'd person
    /// </summary>
    /// <value>Times otherperson CC'd person</value>
    [DataMember(Name="other_cc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "other_cc")]
    public int? OtherCc { get; set; }

    /// <summary>
    /// Last time otherperson sent person an email
    /// </summary>
    /// <value>Last time otherperson sent person an email</value>
    [DataMember(Name="other_sent_last", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "other_sent_last")]
    public DateTime? OtherSentLast { get; set; }

    /// <summary>
    /// Last time otherperson CC'd person
    /// </summary>
    /// <value>Last time otherperson CC'd person</value>
    [DataMember(Name="other_cc_last", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "other_cc_last")]
    public DateTime? OtherCcLast { get; set; }

    /// <summary>
    /// First email otherperson sent to person
    /// </summary>
    /// <value>First email otherperson sent to person</value>
    [DataMember(Name="other_sent_first", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "other_sent_first")]
    public DateTime? OtherSentFirst { get; set; }

    /// <summary>
    /// How many meetings were they on together?
    /// </summary>
    /// <value>How many meetings were they on together?</value>
    [DataMember(Name="meetings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "meetings")]
    public int? Meetings { get; set; }

    /// <summary>
    /// Date of the last meeting
    /// </summary>
    /// <value>Date of the last meeting</value>
    [DataMember(Name="lastmeeting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastmeeting")]
    public DateTime? Lastmeeting { get; set; }

    /// <summary>
    /// Date of the first detected meeting
    /// </summary>
    /// <value>Date of the first detected meeting</value>
    [DataMember(Name="firstmeeting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstmeeting")]
    public DateTime? Firstmeeting { get; set; }

    /// <summary>
    /// The history of the relationship by months. Months with no activity are not returned.    By default this isn't returned. To get this returned you must set expand_relationship_metrics_history = true.  You can't set expand_relationship_metrics_history = true and expand_relationship_metrics = false.
    /// </summary>
    /// <value>The history of the relationship by months. Months with no activity are not returned.    By default this isn't returned. To get this returned you must set expand_relationship_metrics_history = true.  You can't set expand_relationship_metrics_history = true and expand_relationship_metrics = false.</value>
    [DataMember(Name="history", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "history")]
    public List<DragnetTechSharedRelationshipHistory> History { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DragnetTechSharedRelationshipMetric {\n");
      sb.Append("  Otherperson: ").Append(Otherperson).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Isotherpersoninternal: ").Append(Isotherpersoninternal).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Emails: ").Append(Emails).Append("\n");
      sb.Append("  PersonSent: ").Append(PersonSent).Append("\n");
      sb.Append("  PersonCc: ").Append(PersonCc).Append("\n");
      sb.Append("  PersonSentLast: ").Append(PersonSentLast).Append("\n");
      sb.Append("  PersonCcLast: ").Append(PersonCcLast).Append("\n");
      sb.Append("  PersonSentFirst: ").Append(PersonSentFirst).Append("\n");
      sb.Append("  OtherSent: ").Append(OtherSent).Append("\n");
      sb.Append("  OtherCc: ").Append(OtherCc).Append("\n");
      sb.Append("  OtherSentLast: ").Append(OtherSentLast).Append("\n");
      sb.Append("  OtherCcLast: ").Append(OtherCcLast).Append("\n");
      sb.Append("  OtherSentFirst: ").Append(OtherSentFirst).Append("\n");
      sb.Append("  Meetings: ").Append(Meetings).Append("\n");
      sb.Append("  Lastmeeting: ").Append(Lastmeeting).Append("\n");
      sb.Append("  Firstmeeting: ").Append(Firstmeeting).Append("\n");
      sb.Append("  History: ").Append(History).Append("\n");
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
