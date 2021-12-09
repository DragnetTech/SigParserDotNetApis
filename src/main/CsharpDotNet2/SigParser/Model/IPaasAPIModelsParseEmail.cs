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
  public class IPaasAPIModelsParseEmail {
    /// <summary>
    /// Email without the signature
    /// </summary>
    /// <value>Email without the signature</value>
    [DataMember(Name="CleanedBodyPlain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CleanedBodyPlain")]
    public string CleanedBodyPlain { get; set; }

    /// <summary>
    /// Email without the signature
    /// </summary>
    /// <value>Email without the signature</value>
    [DataMember(Name="CleanedBodyHtml", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CleanedBodyHtml")]
    public string CleanedBodyHtml { get; set; }

    /// <summary>
    /// Plain text version of the body of this email with the reply chain stripped off but includes the signature. This should always be populated.
    /// </summary>
    /// <value>Plain text version of the body of this email with the reply chain stripped off but includes the signature. This should always be populated.</value>
    [DataMember(Name="BodyPlain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BodyPlain")]
    public string BodyPlain { get; set; }

    /// <summary>
    /// SigParser's attempt at producing an HTML email body for just this email or reply chain email. Only produced if the original email was HTML.  Will not include the reply headers like \"From\" and \"To\" or \"Email sent from...\". Email signature is not stripped out. Cannot handle emails with  namespaces in the HTML which is rare but can happen. In cases where the email can't be parsed, the original full HTML will be included in the first section.
    /// </summary>
    /// <value>SigParser's attempt at producing an HTML email body for just this email or reply chain email. Only produced if the original email was HTML.  Will not include the reply headers like \"From\" and \"To\" or \"Email sent from...\". Email signature is not stripped out. Cannot handle emails with  namespaces in the HTML which is rare but can happen. In cases where the email can't be parsed, the original full HTML will be included in the first section.</value>
    [DataMember(Name="BodyHtml", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BodyHtml")]
    public string BodyHtml { get; set; }

    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    [DataMember(Name="Subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Subject")]
    public string Subject { get; set; }

    /// <summary>
    /// Date is only available if it was parsed out from the email or if it was passed in for the root email.
    /// </summary>
    /// <value>Date is only available if it was parsed out from the email or if it was passed in for the root email.</value>
    [DataMember(Name="Date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Gets or Sets FromEmailAddress
    /// </summary>
    [DataMember(Name="FromEmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FromEmailAddress")]
    public string FromEmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets FromName
    /// </summary>
    [DataMember(Name="FromName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FromName")]
    public string FromName { get; set; }

    /// <summary>
    /// Gets or Sets To
    /// </summary>
    [DataMember(Name="To", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "To")]
    public List<IPaasAPIModelsParseEmailRecipient> To { get; set; }

    /// <summary>
    /// Gets or Sets Cc
    /// </summary>
    [DataMember(Name="Cc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Cc")]
    public List<IPaasAPIModelsParseEmailRecipient> Cc { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IPaasAPIModelsParseEmail {\n");
      sb.Append("  CleanedBodyPlain: ").Append(CleanedBodyPlain).Append("\n");
      sb.Append("  CleanedBodyHtml: ").Append(CleanedBodyHtml).Append("\n");
      sb.Append("  BodyPlain: ").Append(BodyPlain).Append("\n");
      sb.Append("  BodyHtml: ").Append(BodyHtml).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  FromEmailAddress: ").Append(FromEmailAddress).Append("\n");
      sb.Append("  FromName: ").Append(FromName).Append("\n");
      sb.Append("  To: ").Append(To).Append("\n");
      sb.Append("  Cc: ").Append(Cc).Append("\n");
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
