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
  public class IPaasAPIModelsParseEmailSignatureV2Model {
    /// <summary>
    /// Email address of the sender of the email.
    /// </summary>
    /// <value>Email address of the sender of the email.</value>
    [DataMember(Name="from_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_address")]
    public string FromAddress { get; set; }

    /// <summary>
    /// Display name for the sender of the email.
    /// </summary>
    /// <value>Display name for the sender of the email.</value>
    [DataMember(Name="from_displayname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_displayname")]
    public string FromDisplayname { get; set; }

    /// <summary>
    /// The best matched company name from the email signature. Be warned that this isn't always a great match.                We suggest using a data vendor like Brandfetch or the free Creative Commons dataset from People Data Labs first and only using the company name from SigParser to fill in the gaps.
    /// </summary>
    /// <value>The best matched company name from the email signature. Be warned that this isn't always a great match.                We suggest using a data vendor like Brandfetch or the free Creative Commons dataset from People Data Labs first and only using the company name from SigParser to fill in the gaps.</value>
    [DataMember(Name="company_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company_name")]
    public string CompanyName { get; set; }

    /// <summary>
    /// Job title for the sender of the email.
    /// </summary>
    /// <value>Job title for the sender of the email.</value>
    [DataMember(Name="job_title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job_title")]
    public string JobTitle { get; set; }

    /// <summary>
    /// Gets or Sets Phones
    /// </summary>
    [DataMember(Name="phones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phones")]
    public List<IPaasAPIModelsParseEmailSignatureV2ModelPhoneDetails> Phones { get; set; }

    /// <summary>
    /// The full address extracted from the signature.
    /// </summary>
    /// <value>The full address extracted from the signature.</value>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets AddressParts
    /// </summary>
    [DataMember(Name="address_parts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_parts")]
    public IPaasAPIModelsParseEmailSignatureV2ModelAddressParts AddressParts { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public List<IPaasAPIModelsParseEmailSignatureV2ModelLink> Links { get; set; }

    /// <summary>
    /// The lines for the signature.
    /// </summary>
    /// <value>The lines for the signature.</value>
    [DataMember(Name="signature", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signature")]
    public string Signature { get; set; }

    /// <summary>
    /// Array of error messages if there are any issues.
    /// </summary>
    /// <value>Array of error messages if there are any issues.</value>
    [DataMember(Name="errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errors")]
    public List<string> Errors { get; set; }

    /// <summary>
    /// Duration in milliseconds it took to process the request.
    /// </summary>
    /// <value>Duration in milliseconds it took to process the request.</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public long? Duration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IPaasAPIModelsParseEmailSignatureV2Model {\n");
      sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
      sb.Append("  FromDisplayname: ").Append(FromDisplayname).Append("\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
      sb.Append("  Phones: ").Append(Phones).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  AddressParts: ").Append(AddressParts).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Signature: ").Append(Signature).Append("\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
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
