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
  public class IPaasAPIControllersContactsControllerContactUpsertModel {
    /// <summary>
    /// Required. Email address for the contact. If a contact already exists with the same email address they contact will be updated.   Undefined or null or blank values in the request will not overwrite existing values.
    /// </summary>
    /// <value>Required. Email address for the contact. If a contact already exists with the same email address they contact will be updated.   Undefined or null or blank values in the request will not overwrite existing values.</value>
    [DataMember(Name="emailaddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailaddress")]
    public string Emailaddress { get; set; }

    /// <summary>
    /// Name of the contact. If name and firstname and lastname are provided then name is used.
    /// </summary>
    /// <value>Name of the contact. If name and firstname and lastname are provided then name is used.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Firstname
    /// </summary>
    [DataMember(Name="firstname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstname")]
    public string Firstname { get; set; }

    /// <summary>
    /// Gets or Sets Lastname
    /// </summary>
    [DataMember(Name="lastname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastname")]
    public string Lastname { get; set; }

    /// <summary>
    /// Job title for the contact.
    /// </summary>
    /// <value>Job title for the contact.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets WorkPhone
    /// </summary>
    [DataMember(Name="work_phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "work_phone")]
    public string WorkPhone { get; set; }

    /// <summary>
    /// Gets or Sets MobilePhone
    /// </summary>
    [DataMember(Name="mobile_phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobile_phone")]
    public string MobilePhone { get; set; }

    /// <summary>
    /// Gets or Sets HomePhone
    /// </summary>
    [DataMember(Name="home_phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "home_phone")]
    public string HomePhone { get; set; }

    /// <summary>
    /// Gets or Sets VoipPhone
    /// </summary>
    [DataMember(Name="voip_phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "voip_phone")]
    public string VoipPhone { get; set; }

    /// <summary>
    /// Gets or Sets FaxPhone
    /// </summary>
    [DataMember(Name="fax_phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fax_phone")]
    public string FaxPhone { get; set; }

    /// <summary>
    /// Gets or Sets OtherPhone
    /// </summary>
    [DataMember(Name="other_phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "other_phone")]
    public string OtherPhone { get; set; }

    /// <summary>
    /// Gets or Sets AddressStreet
    /// </summary>
    [DataMember(Name="address_street", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_street")]
    public string AddressStreet { get; set; }

    /// <summary>
    /// Gets or Sets AddressCity
    /// </summary>
    [DataMember(Name="address_city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_city")]
    public string AddressCity { get; set; }

    /// <summary>
    /// Gets or Sets AddressState
    /// </summary>
    [DataMember(Name="address_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_state")]
    public string AddressState { get; set; }

    /// <summary>
    /// Gets or Sets AddressPostalcode
    /// </summary>
    [DataMember(Name="address_postalcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_postalcode")]
    public string AddressPostalcode { get; set; }

    /// <summary>
    /// Gets or Sets AddressCountry
    /// </summary>
    [DataMember(Name="address_country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_country")]
    public string AddressCountry { get; set; }

    /// <summary>
    /// A website for the contact.
    /// </summary>
    /// <value>A website for the contact.</value>
    [DataMember(Name="website", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "website")]
    public string Website { get; set; }

    /// <summary>
    /// Gets or Sets Linkedinurl
    /// </summary>
    [DataMember(Name="linkedinurl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedinurl")]
    public string Linkedinurl { get; set; }

    /// <summary>
    /// Gets or Sets Linkedinid
    /// </summary>
    [DataMember(Name="linkedinid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedinid")]
    public string Linkedinid { get; set; }

    /// <summary>
    /// Gets or Sets Twitterurl
    /// </summary>
    [DataMember(Name="twitterurl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twitterurl")]
    public string Twitterurl { get; set; }

    /// <summary>
    /// Gets or Sets Twitterhandle
    /// </summary>
    [DataMember(Name="twitterhandle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twitterhandle")]
    public string Twitterhandle { get; set; }

    /// <summary>
    /// Gets or Sets Emailbouncedate
    /// </summary>
    [DataMember(Name="emailbouncedate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailbouncedate")]
    public DateTime? Emailbouncedate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IPaasAPIControllersContactsControllerContactUpsertModel {\n");
      sb.Append("  Emailaddress: ").Append(Emailaddress).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Firstname: ").Append(Firstname).Append("\n");
      sb.Append("  Lastname: ").Append(Lastname).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
      sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
      sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
      sb.Append("  VoipPhone: ").Append(VoipPhone).Append("\n");
      sb.Append("  FaxPhone: ").Append(FaxPhone).Append("\n");
      sb.Append("  OtherPhone: ").Append(OtherPhone).Append("\n");
      sb.Append("  AddressStreet: ").Append(AddressStreet).Append("\n");
      sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
      sb.Append("  AddressState: ").Append(AddressState).Append("\n");
      sb.Append("  AddressPostalcode: ").Append(AddressPostalcode).Append("\n");
      sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
      sb.Append("  Website: ").Append(Website).Append("\n");
      sb.Append("  Linkedinurl: ").Append(Linkedinurl).Append("\n");
      sb.Append("  Linkedinid: ").Append(Linkedinid).Append("\n");
      sb.Append("  Twitterurl: ").Append(Twitterurl).Append("\n");
      sb.Append("  Twitterhandle: ").Append(Twitterhandle).Append("\n");
      sb.Append("  Emailbouncedate: ").Append(Emailbouncedate).Append("\n");
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
