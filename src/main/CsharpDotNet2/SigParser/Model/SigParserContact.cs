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
  public class SigParserContact {
    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets EmailAddress
    /// </summary>
    [DataMember(Name="emailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailAddress")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets EmailAddressDomain
    /// </summary>
    [DataMember(Name="emailAddressDomain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailAddressDomain")]
    public string EmailAddressDomain { get; set; }

    /// <summary>
    /// Gets or Sets EmailAddressDomainWithoutTLD
    /// </summary>
    [DataMember(Name="emailAddressDomainWithoutTLD", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailAddressDomainWithoutTLD")]
    public string EmailAddressDomainWithoutTLD { get; set; }

    /// <summary>
    /// Gets or Sets PhoneNumber
    /// </summary>
    [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phoneNumber")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Gets or Sets MobilePhone
    /// </summary>
    [DataMember(Name="mobilePhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobilePhone")]
    public string MobilePhone { get; set; }

    /// <summary>
    /// Gets or Sets OfficePhone
    /// </summary>
    [DataMember(Name="officePhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "officePhone")]
    public string OfficePhone { get; set; }

    /// <summary>
    /// Gets or Sets Fax
    /// </summary>
    [DataMember(Name="fax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fax")]
    public string Fax { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets TwitterUrl
    /// </summary>
    [DataMember(Name="twitterUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twitterUrl")]
    public string TwitterUrl { get; set; }

    /// <summary>
    /// Gets or Sets TwitterHandle
    /// </summary>
    [DataMember(Name="twitterHandle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twitterHandle")]
    public string TwitterHandle { get; set; }

    /// <summary>
    /// Gets or Sets LinkedInUrl
    /// </summary>
    [DataMember(Name="linkedInUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedInUrl")]
    public string LinkedInUrl { get; set; }

    /// <summary>
    /// Gets or Sets LinkedInHandle
    /// </summary>
    [DataMember(Name="linkedInHandle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedInHandle")]
    public string LinkedInHandle { get; set; }

    /// <summary>
    /// Gets or Sets CompanyName
    /// </summary>
    [DataMember(Name="companyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "companyName")]
    public string CompanyName { get; set; }

    /// <summary>
    /// Gets or Sets Website
    /// </summary>
    [DataMember(Name="website", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "website")]
    public string Website { get; set; }

    /// <summary>
    /// Gets or Sets NameSource
    /// </summary>
    [DataMember(Name="nameSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nameSource")]
    public string NameSource { get; set; }

    /// <summary>
    /// Gets or Sets NameQuality
    /// </summary>
    [DataMember(Name="nameQuality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nameQuality")]
    public int? NameQuality { get; set; }

    /// <summary>
    /// Gets or Sets AddressParts
    /// </summary>
    [DataMember(Name="addressParts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressParts")]
    public SigParserAddressParts AddressParts { get; set; }

    /// <summary>
    /// Gets or Sets IsSpammy
    /// </summary>
    [DataMember(Name="isSpammy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isSpammy")]
    public bool? IsSpammy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SigParserContact {\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
      sb.Append("  EmailAddressDomain: ").Append(EmailAddressDomain).Append("\n");
      sb.Append("  EmailAddressDomainWithoutTLD: ").Append(EmailAddressDomainWithoutTLD).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
      sb.Append("  OfficePhone: ").Append(OfficePhone).Append("\n");
      sb.Append("  Fax: ").Append(Fax).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  TwitterUrl: ").Append(TwitterUrl).Append("\n");
      sb.Append("  TwitterHandle: ").Append(TwitterHandle).Append("\n");
      sb.Append("  LinkedInUrl: ").Append(LinkedInUrl).Append("\n");
      sb.Append("  LinkedInHandle: ").Append(LinkedInHandle).Append("\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  Website: ").Append(Website).Append("\n");
      sb.Append("  NameSource: ").Append(NameSource).Append("\n");
      sb.Append("  NameQuality: ").Append(NameQuality).Append("\n");
      sb.Append("  AddressParts: ").Append(AddressParts).Append("\n");
      sb.Append("  IsSpammy: ").Append(IsSpammy).Append("\n");
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
