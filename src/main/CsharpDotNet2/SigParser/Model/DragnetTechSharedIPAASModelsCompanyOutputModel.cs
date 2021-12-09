using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SigParser.Model {

  /// <summary>
  /// Details about a company based on the domain name.  You should only map this to your CRM if your CRM only has one Account/Organization record per company.
  /// </summary>
  [DataContract]
  public class DragnetTechSharedIPAASModelsCompanyOutputModel {
    /// <summary>
    /// Valid, Other, Coworker, Private, Ignore.    Other possible values may be added later.
    /// </summary>
    /// <value>Valid, Other, Coworker, Private, Ignore.    Other possible values may be added later.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The best name SigParser has found or that has been set by a user.
    /// </summary>
    /// <value>The best name SigParser has found or that has been set by a user.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Numeric value representing when this record was last modified.   This has precision down to the millisecond so you shouldn't convert it to a date with less precision.
    /// </summary>
    /// <value>Numeric value representing when this record was last modified.   This has precision down to the millisecond so you shouldn't convert it to a date with less precision.</value>
    [DataMember(Name="lastmodified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastmodified")]
    public long? Lastmodified { get; set; }

    /// <summary>
    /// Number of Valid or Other contacts on this account. Coworker, Private and Ignore contacts are ignored when counting.
    /// </summary>
    /// <value>Number of Valid or Other contacts on this account. Coworker, Private and Ignore contacts are ignored when counting.</value>
    [DataMember(Name="contacts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contacts")]
    public int? Contacts { get; set; }

    /// <summary>
    /// Total emails from people at this company to your company.
    /// </summary>
    /// <value>Total emails from people at this company to your company.</value>
    [DataMember(Name="inbound_emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inbound_emails")]
    public int? InboundEmails { get; set; }

    /// <summary>
    /// Total emails from your company to this company.
    /// </summary>
    /// <value>Total emails from your company to this company.</value>
    [DataMember(Name="outbound_emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "outbound_emails")]
    public int? OutboundEmails { get; set; }

    /// <summary>
    /// Meetings with this company's employees.
    /// </summary>
    /// <value>Meetings with this company's employees.</value>
    [DataMember(Name="meetings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "meetings")]
    public int? Meetings { get; set; }

    /// <summary>
    /// Last time there was an email or a meeting with this company.
    /// </summary>
    /// <value>Last time there was an email or a meeting with this company.</value>
    [DataMember(Name="last_interaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_interaction")]
    public DateTime? LastInteraction { get; set; }

    /// <summary>
    /// The email domain name for this company.   This is a primary key for the table so if the company has multiple domain names then there will be a Company record for each domain.
    /// </summary>
    /// <value>The email domain name for this company.   This is a primary key for the table so if the company has multiple domain names then there will be a Company record for each domain.</value>
    [DataMember(Name="domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "domain")]
    public string Domain { get; set; }

    /// <summary>
    /// Email address of someone in your company with the best relationsip with this account.
    /// </summary>
    /// <value>Email address of someone in your company with the best relationsip with this account.</value>
    [DataMember(Name="closest_internal_contact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closest_internal_contact")]
    public string ClosestInternalContact { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<DragnetTechSharedIPAASModelsTag> Tags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DragnetTechSharedIPAASModelsCompanyOutputModel {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Lastmodified: ").Append(Lastmodified).Append("\n");
      sb.Append("  Contacts: ").Append(Contacts).Append("\n");
      sb.Append("  InboundEmails: ").Append(InboundEmails).Append("\n");
      sb.Append("  OutboundEmails: ").Append(OutboundEmails).Append("\n");
      sb.Append("  Meetings: ").Append(Meetings).Append("\n");
      sb.Append("  LastInteraction: ").Append(LastInteraction).Append("\n");
      sb.Append("  Domain: ").Append(Domain).Append("\n");
      sb.Append("  ClosestInternalContact: ").Append(ClosestInternalContact).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
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
