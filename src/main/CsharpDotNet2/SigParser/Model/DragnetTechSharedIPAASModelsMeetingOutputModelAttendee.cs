using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SigParser.Model {

  /// <summary>
  /// A meeting attendee with the declined status of the attendee.
  /// </summary>
  [DataContract]
  public class DragnetTechSharedIPAASModelsMeetingOutputModelAttendee {
    /// <summary>
    /// Email address for the contact. This is always lowercase.
    /// </summary>
    /// <value>Email address for the contact. This is always lowercase.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets Declined
    /// </summary>
    [DataMember(Name="declined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "declined")]
    public bool? Declined { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DragnetTechSharedIPAASModelsMeetingOutputModelAttendee {\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Declined: ").Append(Declined).Append("\n");
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
