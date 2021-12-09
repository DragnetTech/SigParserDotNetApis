using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SigParser.Model {

  /// <summary>
  /// Input model for an email to parse content from.
  /// </summary>
  [DataContract]
  public class IPaasAPIModelsParseEmailInputModel {
    /// <summary>
    /// Email subject. Not required but should be provided in order to have the \"subject\" field populated in the response for the \"emails\" collection.
    /// </summary>
    /// <value>Email subject. Not required but should be provided in order to have the \"subject\" field populated in the response for the \"emails\" collection.</value>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subject")]
    public string Subject { get; set; }

    /// <summary>
    /// The sender of the email. Required for us to match the contact data we find in the root email's signature with an email address.
    /// </summary>
    /// <value>The sender of the email. Required for us to match the contact data we find in the root email's signature with an email address.</value>
    [DataMember(Name="from_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_address")]
    public string FromAddress { get; set; }

    /// <summary>
    /// The sender of the email. Important to provide as it helps to identify where the signature starts although sometimes we can find the signature without it.
    /// </summary>
    /// <value>The sender of the email. Important to provide as it helps to identify where the signature starts although sometimes we can find the signature without it.</value>
    [DataMember(Name="from_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_name")]
    public string FromName { get; set; }

    /// <summary>
    /// Either provide this or the PlainBody or both. This will be used for the email content over the plain body as the HTML is how we can get LinkedIn URLs and Twitter URLs for example.
    /// </summary>
    /// <value>Either provide this or the PlainBody or both. This will be used for the email content over the plain body as the HTML is how we can get LinkedIn URLs and Twitter URLs for example.</value>
    [DataMember(Name="htmlbody", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "htmlbody")]
    public string Htmlbody { get; set; }

    /// <summary>
    /// If there isn't an HTML body we'll fallback to this value. If all you can provide is a text body then we can still find phone numbers, titles and addresses but features like LinkedIn URLs and Twitter URLs embedded in HTML won't be discoverable.
    /// </summary>
    /// <value>If there isn't an HTML body we'll fallback to this value. If all you can provide is a text body then we can still find phone numbers, titles and addresses but features like LinkedIn URLs and Twitter URLs embedded in HTML won't be discoverable.</value>
    [DataMember(Name="plainbody", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plainbody")]
    public string Plainbody { get; set; }

    /// <summary>
    /// A Date string. For example: 2017-01-01T00:00:00 OR Mon, 28 May 2018 23:33:40 +0000 (UTC)  If either of the two above formats don't match what you're providing, we fallback to using the standard .NET parsing to parse this date so you can test that your date works with DotNetFiddle. https://dotnetfiddle.net/sJyTJW
    /// </summary>
    /// <value>A Date string. For example: 2017-01-01T00:00:00 OR Mon, 28 May 2018 23:33:40 +0000 (UTC)  If either of the two above formats don't match what you're providing, we fallback to using the standard .NET parsing to parse this date so you can test that your date works with DotNetFiddle. https://dotnetfiddle.net/sJyTJW</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public string Date { get; set; }

    /// <summary>
    /// Gets or Sets To
    /// </summary>
    [DataMember(Name="to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to")]
    public List<IPaasAPIModelsParseEmailInputModelEmailRecipient> To { get; set; }

    /// <summary>
    /// Gets or Sets Cc
    /// </summary>
    [DataMember(Name="cc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cc")]
    public List<IPaasAPIModelsParseEmailInputModelEmailRecipient> Cc { get; set; }

    /// <summary>
    /// Gets or Sets Options
    /// </summary>
    [DataMember(Name="options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "options")]
    public IPaasAPIModelsParseEmailInputModelOutputOptions Options { get; set; }

    /// <summary>
    /// Gets or Sets Headers
    /// </summary>
    [DataMember(Name="headers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headers")]
    public Dictionary<string, string> Headers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IPaasAPIModelsParseEmailInputModel {\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
      sb.Append("  FromName: ").Append(FromName).Append("\n");
      sb.Append("  Htmlbody: ").Append(Htmlbody).Append("\n");
      sb.Append("  Plainbody: ").Append(Plainbody).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  To: ").Append(To).Append("\n");
      sb.Append("  Cc: ").Append(Cc).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
      sb.Append("  Headers: ").Append(Headers).Append("\n");
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
