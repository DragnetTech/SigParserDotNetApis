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
  public class DragnetTechSharedRelationshipHistory {
    /// <summary>
    /// Month details for the interactions between the two contacts.
    /// </summary>
    /// <value>Month details for the interactions between the two contacts.</value>
    [DataMember(Name="month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "month")]
    public DateTime? Month { get; set; }

    /// <summary>
    /// Number of meetings.
    /// </summary>
    /// <value>Number of meetings.</value>
    [DataMember(Name="meetings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "meetings")]
    public int? Meetings { get; set; }

    /// <summary>
    /// Number of emails.
    /// </summary>
    /// <value>Number of emails.</value>
    [DataMember(Name="emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emails")]
    public int? Emails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DragnetTechSharedRelationshipHistory {\n");
      sb.Append("  Month: ").Append(Month).Append("\n");
      sb.Append("  Meetings: ").Append(Meetings).Append("\n");
      sb.Append("  Emails: ").Append(Emails).Append("\n");
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
