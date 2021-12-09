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
  public class IPaasAPIModelsParseEmailSignatureV2ModelPhoneDetails {
    /// <summary>
    /// What time of phone number is this?                - Phone - Unlabled phone or type not known.  - Mobile  - Office  - Direct  - Fax  - Voip  - Home - This is very rare to ever have a home phone.
    /// </summary>
    /// <value>What time of phone number is this?                - Phone - Unlabled phone or type not known.  - Mobile  - Office  - Direct  - Fax  - Voip  - Home - This is very rare to ever have a home phone.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Phone number with the original formatting.
    /// </summary>
    /// <value>Phone number with the original formatting.</value>
    [DataMember(Name="phone_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone_number")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Possible options:                - MyCellIs  - Signature
    /// </summary>
    /// <value>Possible options:                - MyCellIs  - Signature</value>
    [DataMember(Name="match_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "match_type")]
    public string MatchType { get; set; }

    /// <summary>
    /// Line we found the phone number on.
    /// </summary>
    /// <value>Line we found the phone number on.</value>
    [DataMember(Name="line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line")]
    public string Line { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IPaasAPIModelsParseEmailSignatureV2ModelPhoneDetails {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  MatchType: ").Append(MatchType).Append("\n");
      sb.Append("  Line: ").Append(Line).Append("\n");
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
