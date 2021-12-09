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
  public class SigParserEmail {
    /// <summary>
    /// Gets or Sets FromEmailAddress
    /// </summary>
    [DataMember(Name="from_EmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_EmailAddress")]
    public string FromEmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets FromName
    /// </summary>
    [DataMember(Name="from_Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_Name")]
    public string FromName { get; set; }

    /// <summary>
    /// Gets or Sets TextBody
    /// </summary>
    [DataMember(Name="textBody", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "textBody")]
    public string TextBody { get; set; }

    /// <summary>
    /// Gets or Sets HtmlLines
    /// </summary>
    [DataMember(Name="htmlLines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "htmlLines")]
    public List<string> HtmlLines { get; set; }

    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Gets or Sets DidParseCorrectly
    /// </summary>
    [DataMember(Name="didParseCorrectly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "didParseCorrectly")]
    public bool? DidParseCorrectly { get; set; }

    /// <summary>
    /// Gets or Sets To
    /// </summary>
    [DataMember(Name="to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to")]
    public List<SigParserTo> To { get; set; }

    /// <summary>
    /// Gets or Sets Cc
    /// </summary>
    [DataMember(Name="cc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cc")]
    public List<SigParserCc> Cc { get; set; }

    /// <summary>
    /// Gets or Sets HtmlBody
    /// </summary>
    [DataMember(Name="htmlBody", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "htmlBody")]
    public string HtmlBody { get; set; }

    /// <summary>
    /// Gets or Sets SpammyLookingEmail
    /// </summary>
    [DataMember(Name="spammyLookingEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "spammyLookingEmail")]
    public bool? SpammyLookingEmail { get; set; }

    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subject")]
    public string Subject { get; set; }

    /// <summary>
    /// Gets or Sets CleanedBodyHtml
    /// </summary>
    [DataMember(Name="cleanedBodyHtml", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cleanedBodyHtml")]
    public string CleanedBodyHtml { get; set; }

    /// <summary>
    /// Gets or Sets CleanedBodyPlain
    /// </summary>
    [DataMember(Name="cleanedBodyPlain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cleanedBodyPlain")]
    public string CleanedBodyPlain { get; set; }

    /// <summary>
    /// Gets or Sets EmailTypes
    /// </summary>
    [DataMember(Name="emailTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailTypes")]
    public List<string> EmailTypes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SigParserEmail {\n");
      sb.Append("  FromEmailAddress: ").Append(FromEmailAddress).Append("\n");
      sb.Append("  FromName: ").Append(FromName).Append("\n");
      sb.Append("  TextBody: ").Append(TextBody).Append("\n");
      sb.Append("  HtmlLines: ").Append(HtmlLines).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  DidParseCorrectly: ").Append(DidParseCorrectly).Append("\n");
      sb.Append("  To: ").Append(To).Append("\n");
      sb.Append("  Cc: ").Append(Cc).Append("\n");
      sb.Append("  HtmlBody: ").Append(HtmlBody).Append("\n");
      sb.Append("  SpammyLookingEmail: ").Append(SpammyLookingEmail).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  CleanedBodyHtml: ").Append(CleanedBodyHtml).Append("\n");
      sb.Append("  CleanedBodyPlain: ").Append(CleanedBodyPlain).Append("\n");
      sb.Append("  EmailTypes: ").Append(EmailTypes).Append("\n");
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
