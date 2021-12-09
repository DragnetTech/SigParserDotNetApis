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
  public class SigParserEmailParseResponse {
    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public string Error { get; set; }

    /// <summary>
    /// Gets or Sets Contacts
    /// </summary>
    [DataMember(Name="contacts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contacts")]
    public List<SigParserContact> Contacts { get; set; }

    /// <summary>
    /// Gets or Sets IsSpammyLookingEmailMessage
    /// </summary>
    [DataMember(Name="isSpammyLookingEmailMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isSpammyLookingEmailMessage")]
    public bool? IsSpammyLookingEmailMessage { get; set; }

    /// <summary>
    /// Gets or Sets IsSpammyLookingSender
    /// </summary>
    [DataMember(Name="isSpammyLookingSender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isSpammyLookingSender")]
    public bool? IsSpammyLookingSender { get; set; }

    /// <summary>
    /// Gets or Sets IsSpam
    /// </summary>
    [DataMember(Name="isSpam", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isSpam")]
    public bool? IsSpam { get; set; }

    /// <summary>
    /// Gets or Sets FromLastName
    /// </summary>
    [DataMember(Name="from_LastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_LastName")]
    public string FromLastName { get; set; }

    /// <summary>
    /// Gets or Sets FromFirstName
    /// </summary>
    [DataMember(Name="from_FirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_FirstName")]
    public string FromFirstName { get; set; }

    /// <summary>
    /// Gets or Sets FromFax
    /// </summary>
    [DataMember(Name="from_Fax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_Fax")]
    public string FromFax { get; set; }

    /// <summary>
    /// Gets or Sets FromPhone
    /// </summary>
    [DataMember(Name="from_Phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_Phone")]
    public string FromPhone { get; set; }

    /// <summary>
    /// Gets or Sets FromAddress
    /// </summary>
    [DataMember(Name="from_Address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_Address")]
    public string FromAddress { get; set; }

    /// <summary>
    /// Gets or Sets FromAddressParts
    /// </summary>
    [DataMember(Name="from_AddressParts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_AddressParts")]
    public SigParserAddressParts FromAddressParts { get; set; }

    /// <summary>
    /// Gets or Sets FromTitle
    /// </summary>
    [DataMember(Name="from_Title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_Title")]
    public string FromTitle { get; set; }

    /// <summary>
    /// Gets or Sets FromMobilePhone
    /// </summary>
    [DataMember(Name="from_MobilePhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_MobilePhone")]
    public string FromMobilePhone { get; set; }

    /// <summary>
    /// Gets or Sets FromOfficePhone
    /// </summary>
    [DataMember(Name="from_OfficePhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_OfficePhone")]
    public string FromOfficePhone { get; set; }

    /// <summary>
    /// Gets or Sets FromLinkedInUrl
    /// </summary>
    [DataMember(Name="from_LinkedInUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_LinkedInUrl")]
    public string FromLinkedInUrl { get; set; }

    /// <summary>
    /// Gets or Sets FromTwitterUrl
    /// </summary>
    [DataMember(Name="from_TwitterUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_TwitterUrl")]
    public string FromTwitterUrl { get; set; }

    /// <summary>
    /// Gets or Sets FromTwitterHandle
    /// </summary>
    [DataMember(Name="from_TwitterHandle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_TwitterHandle")]
    public string FromTwitterHandle { get; set; }

    /// <summary>
    /// Gets or Sets FromEmailAddress
    /// </summary>
    [DataMember(Name="from_EmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_EmailAddress")]
    public string FromEmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets FromCompanyName
    /// </summary>
    [DataMember(Name="from_CompanyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_CompanyName")]
    public string FromCompanyName { get; set; }

    /// <summary>
    /// Gets or Sets FromWebsite
    /// </summary>
    [DataMember(Name="from_Website", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_Website")]
    public string FromWebsite { get; set; }

    /// <summary>
    /// Gets or Sets FromEmailAddressDomain
    /// </summary>
    [DataMember(Name="from_EmailAddressDomain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_EmailAddressDomain")]
    public string FromEmailAddressDomain { get; set; }

    /// <summary>
    /// Gets or Sets FromEmailAddressDomainWithoutTLD
    /// </summary>
    [DataMember(Name="from_EmailAddressDomainWithoutTLD", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_EmailAddressDomainWithoutTLD")]
    public string FromEmailAddressDomainWithoutTLD { get; set; }

    /// <summary>
    /// Gets or Sets Emails
    /// </summary>
    [DataMember(Name="emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emails")]
    public List<SigParserEmail> Emails { get; set; }

    /// <summary>
    /// Gets or Sets FromLinkedInHandle
    /// </summary>
    [DataMember(Name="from_LinkedInHandle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_LinkedInHandle")]
    public string FromLinkedInHandle { get; set; }

    /// <summary>
    /// Gets or Sets Duration
    /// </summary>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public double? Duration { get; set; }

    /// <summary>
    /// Gets or Sets Cleanedemailbody
    /// </summary>
    [DataMember(Name="cleanedemailbody", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cleanedemailbody")]
    public string Cleanedemailbody { get; set; }

    /// <summary>
    /// Gets or Sets CleanedemailbodyIshtml
    /// </summary>
    [DataMember(Name="cleanedemailbody_ishtml", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cleanedemailbody_ishtml")]
    public string CleanedemailbodyIshtml { get; set; }

    /// <summary>
    /// Gets or Sets CleanedemailbodyPlain
    /// </summary>
    [DataMember(Name="cleanedemailbody_plain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cleanedemailbody_plain")]
    public string CleanedemailbodyPlain { get; set; }

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
      sb.Append("class SigParserEmailParseResponse {\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  Contacts: ").Append(Contacts).Append("\n");
      sb.Append("  IsSpammyLookingEmailMessage: ").Append(IsSpammyLookingEmailMessage).Append("\n");
      sb.Append("  IsSpammyLookingSender: ").Append(IsSpammyLookingSender).Append("\n");
      sb.Append("  IsSpam: ").Append(IsSpam).Append("\n");
      sb.Append("  FromLastName: ").Append(FromLastName).Append("\n");
      sb.Append("  FromFirstName: ").Append(FromFirstName).Append("\n");
      sb.Append("  FromFax: ").Append(FromFax).Append("\n");
      sb.Append("  FromPhone: ").Append(FromPhone).Append("\n");
      sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
      sb.Append("  FromAddressParts: ").Append(FromAddressParts).Append("\n");
      sb.Append("  FromTitle: ").Append(FromTitle).Append("\n");
      sb.Append("  FromMobilePhone: ").Append(FromMobilePhone).Append("\n");
      sb.Append("  FromOfficePhone: ").Append(FromOfficePhone).Append("\n");
      sb.Append("  FromLinkedInUrl: ").Append(FromLinkedInUrl).Append("\n");
      sb.Append("  FromTwitterUrl: ").Append(FromTwitterUrl).Append("\n");
      sb.Append("  FromTwitterHandle: ").Append(FromTwitterHandle).Append("\n");
      sb.Append("  FromEmailAddress: ").Append(FromEmailAddress).Append("\n");
      sb.Append("  FromCompanyName: ").Append(FromCompanyName).Append("\n");
      sb.Append("  FromWebsite: ").Append(FromWebsite).Append("\n");
      sb.Append("  FromEmailAddressDomain: ").Append(FromEmailAddressDomain).Append("\n");
      sb.Append("  FromEmailAddressDomainWithoutTLD: ").Append(FromEmailAddressDomainWithoutTLD).Append("\n");
      sb.Append("  Emails: ").Append(Emails).Append("\n");
      sb.Append("  FromLinkedInHandle: ").Append(FromLinkedInHandle).Append("\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  Cleanedemailbody: ").Append(Cleanedemailbody).Append("\n");
      sb.Append("  CleanedemailbodyIshtml: ").Append(CleanedemailbodyIshtml).Append("\n");
      sb.Append("  CleanedemailbodyPlain: ").Append(CleanedemailbodyPlain).Append("\n");
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
