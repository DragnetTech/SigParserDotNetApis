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
    /// The internal contact who has the most active relationship with this company.
    /// </summary>
    /// <value>The internal contact who has the most active relationship with this company.</value>
    [DataMember(Name="internal_contact_most_active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internal_contact_most_active")]
    public string InternalContactMostActive { get; set; }

    /// <summary>
    /// The internal contact who has most recently interacted with this company.
    /// </summary>
    /// <value>The internal contact who has most recently interacted with this company.</value>
    [DataMember(Name="internal_contact_latest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internal_contact_latest")]
    public string InternalContactLatest { get; set; }

    /// <summary>
    /// The date of the latest communication with this company.
    /// </summary>
    /// <value>The date of the latest communication with this company.</value>
    [DataMember(Name="internal_contact_latest_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internal_contact_latest_date")]
    public DateTime? InternalContactLatestDate { get; set; }

    /// <summary>
    /// The internal contact who first established communications with this company.
    /// </summary>
    /// <value>The internal contact who first established communications with this company.</value>
    [DataMember(Name="internal_contact_first", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internal_contact_first")]
    public string InternalContactFirst { get; set; }

    /// <summary>
    /// The date of first established communication with this company.
    /// </summary>
    /// <value>The date of first established communication with this company.</value>
    [DataMember(Name="internal_contact_first_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internal_contact_first_date")]
    public DateTime? InternalContactFirstDate { get; set; }

    /// <summary>
    /// The number of internal contacts who have an established relationship with a contact at this company.
    /// </summary>
    /// <value>The number of internal contacts who have an established relationship with a contact at this company.</value>
    [DataMember(Name="relationships_coworker", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relationships_coworker")]
    public int? RelationshipsCoworker { get; set; }

    /// <summary>
    /// A count of relationships with this company that are not internal contacts and not within the same company.
    /// </summary>
    /// <value>A count of relationships with this company that are not internal contacts and not within the same company.</value>
    [DataMember(Name="relationships_other", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relationships_other")]
    public int? RelationshipsOther { get; set; }

    /// <summary>
    /// Email addresses of the top 5 Coworkers (internal) to your company who know this contact the best based on interactions.
    /// </summary>
    /// <value>Email addresses of the top 5 Coworkers (internal) to your company who know this contact the best based on interactions.</value>
    [DataMember(Name="coworker_relationships_emailaddresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coworker_relationships_emailaddresses")]
    public List<string> CoworkerRelationshipsEmailaddresses { get; set; }

    /// <summary>
    /// Email addresses of the top 5 contacts who work at the same company who have been on emails and meetings.
    /// </summary>
    /// <value>Email addresses of the top 5 contacts who work at the same company who have been on emails and meetings.</value>
    [DataMember(Name="company_relationships_emailaddresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company_relationships_emailaddresses")]
    public List<string> CompanyRelationshipsEmailaddresses { get; set; }

    /// <summary>
    /// Email addresses of the top 5 people who have been on emails with this contact from other companies.
    /// </summary>
    /// <value>Email addresses of the top 5 people who have been on emails with this contact from other companies.</value>
    [DataMember(Name="other_relationships_emailaddresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "other_relationships_emailaddresses")]
    public List<string> OtherRelationshipsEmailaddresses { get; set; }

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
      sb.Append("  InternalContactMostActive: ").Append(InternalContactMostActive).Append("\n");
      sb.Append("  InternalContactLatest: ").Append(InternalContactLatest).Append("\n");
      sb.Append("  InternalContactLatestDate: ").Append(InternalContactLatestDate).Append("\n");
      sb.Append("  InternalContactFirst: ").Append(InternalContactFirst).Append("\n");
      sb.Append("  InternalContactFirstDate: ").Append(InternalContactFirstDate).Append("\n");
      sb.Append("  RelationshipsCoworker: ").Append(RelationshipsCoworker).Append("\n");
      sb.Append("  RelationshipsOther: ").Append(RelationshipsOther).Append("\n");
      sb.Append("  CoworkerRelationshipsEmailaddresses: ").Append(CoworkerRelationshipsEmailaddresses).Append("\n");
      sb.Append("  CompanyRelationshipsEmailaddresses: ").Append(CompanyRelationshipsEmailaddresses).Append("\n");
      sb.Append("  OtherRelationshipsEmailaddresses: ").Append(OtherRelationshipsEmailaddresses).Append("\n");
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
