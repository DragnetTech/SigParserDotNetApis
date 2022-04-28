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
  public class DragnetTechSharedIPAASModelsRequestContactParam {
    /// <summary>
    /// Which contacts should be in the \"relationship_metrics\" field.    INTERNAL = Only contacts internal to your organization (ie. your coworkers).   EXTERNAL = Only contacts outside of your organization.  ALL = Both INTERNAL and EXTERNAL contacts.
    /// </summary>
    /// <value>Which contacts should be in the \"relationship_metrics\" field.    INTERNAL = Only contacts internal to your organization (ie. your coworkers).   EXTERNAL = Only contacts outside of your organization.  ALL = Both INTERNAL and EXTERNAL contacts.</value>
    [DataMember(Name="expand_relationship_metrics_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expand_relationship_metrics_type")]
    public string ExpandRelationshipMetricsType { get; set; }

    /// <summary>
    /// Should SigParser return contacts it thinks might have email parsing errors. For example, bad phone numbers. Default \"false\"
    /// </summary>
    /// <value>Should SigParser return contacts it thinks might have email parsing errors. For example, bad phone numbers. Default \"false\"</value>
    [DataMember(Name="include_incorrectly_parsed_contacts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "include_incorrectly_parsed_contacts")]
    public bool? IncludeIncorrectlyParsedContacts { get; set; }

    /// <summary>
    /// Order by options:                - lastmodified - Date the contact was last modified (great for fetching a delta of contact changes).  - created - Date the contact was created in SigParser.  - interactions - Total number of emails + meetings the contact has appeared on.    Defaults to lastmodified
    /// </summary>
    /// <value>Order by options:                - lastmodified - Date the contact was last modified (great for fetching a delta of contact changes).  - created - Date the contact was created in SigParser.  - interactions - Total number of emails + meetings the contact has appeared on.    Defaults to lastmodified</value>
    [DataMember(Name="orderby", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderby")]
    public string Orderby { get; set; }

    /// <summary>
    /// Determines the direction of the sort.
    /// </summary>
    /// <value>Determines the direction of the sort.</value>
    [DataMember(Name="orderbyasc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderbyasc")]
    public bool? Orderbyasc { get; set; }

    /// <summary>
    /// Page 1 is the first page of results.
    /// </summary>
    /// <value>Page 1 is the first page of results.</value>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public int? Page { get; set; }

    /// <summary>
    /// How many records per page. If using \"lastmodified_after\" then this is always at least 25. Max 200. If expand_relationship_metrics is
    /// </summary>
    /// <value>How many records per page. If using \"lastmodified_after\" then this is always at least 25. Max 200. If expand_relationship_metrics is</value>
    [DataMember(Name="take", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "take")]
    public int? Take { get; set; }

    /// <summary>
    /// This is the ID of the tag. A tag can have types. This isn't the name of the tag. It will look like a uuid/Guid
    /// </summary>
    /// <value>This is the ID of the tag. A tag can have types. This isn't the name of the tag. It will look like a uuid/Guid</value>
    [DataMember(Name="tagid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagid")]
    public Guid? Tagid { get; set; }

    /// <summary>
    /// Find a single contact record by email address. Matches exactly.   We store all email addresses as lowercase so we'll convert this to lowercase if it uppercase.
    /// </summary>
    /// <value>Find a single contact record by email address. Matches exactly.   We store all email addresses as lowercase so we'll convert this to lowercase if it uppercase.</value>
    [DataMember(Name="emailaddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailaddress")]
    public string Emailaddress { get; set; }

    /// <summary>
    /// Only get contacts with a lastmodified date greater than or equal to this date. If \"take\" is less than 25 then 25 will be used as the \"take\".  This is a special attribute that allows you to get recently modified contacts. Just store the max value from the last request and use it with the next request.
    /// </summary>
    /// <value>Only get contacts with a lastmodified date greater than or equal to this date. If \"take\" is less than 25 then 25 will be used as the \"take\".  This is a special attribute that allows you to get recently modified contacts. Just store the max value from the last request and use it with the next request.</value>
    [DataMember(Name="lastmodified_after", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastmodified_after")]
    public DateTime? LastmodifiedAfter { get; set; }

    /// <summary>
    /// Include the relationship_metrics array on each contact in the response. Default = false.  This can add a lot of size to the response payload so  so it is suggest you not include it when you don't need it.
    /// </summary>
    /// <value>Include the relationship_metrics array on each contact in the response. Default = false.  This can add a lot of size to the response payload so  so it is suggest you not include it when you don't need it.</value>
    [DataMember(Name="expand_relationship_metrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expand_relationship_metrics")]
    public bool? ExpandRelationshipMetrics { get; set; }

    /// <summary>
    /// Expand the history within the relationship metrics. This may expand the response size of the request considerably.
    /// </summary>
    /// <value>Expand the history within the relationship metrics. This may expand the response size of the request considerably.</value>
    [DataMember(Name="expand_relationship_metrics_history", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expand_relationship_metrics_history")]
    public bool? ExpandRelationshipMetricsHistory { get; set; }

    /// <summary>
    /// Should SigParser return contacts it thinks are bots or not real relationship contacts. Default \"false\"
    /// </summary>
    /// <value>Should SigParser return contacts it thinks are bots or not real relationship contacts. Default \"false\"</value>
    [DataMember(Name="include_spam_contacts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "include_spam_contacts")]
    public bool? IncludeSpamContacts { get; set; }

    /// <summary>
    /// Fetch contacts by email domain. Won't return contacts in an email domain that is public like gmail.com or yahoo.com.  The @ symbol is optional.
    /// </summary>
    /// <value>Fetch contacts by email domain. Won't return contacts in an email domain that is public like gmail.com or yahoo.com.  The @ symbol is optional.</value>
    [DataMember(Name="domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "domain")]
    public string Domain { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DragnetTechSharedIPAASModelsRequestContactParam {\n");
      sb.Append("  ExpandRelationshipMetricsType: ").Append(ExpandRelationshipMetricsType).Append("\n");
      sb.Append("  IncludeIncorrectlyParsedContacts: ").Append(IncludeIncorrectlyParsedContacts).Append("\n");
      sb.Append("  Orderby: ").Append(Orderby).Append("\n");
      sb.Append("  Orderbyasc: ").Append(Orderbyasc).Append("\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
      sb.Append("  Take: ").Append(Take).Append("\n");
      sb.Append("  Tagid: ").Append(Tagid).Append("\n");
      sb.Append("  Emailaddress: ").Append(Emailaddress).Append("\n");
      sb.Append("  LastmodifiedAfter: ").Append(LastmodifiedAfter).Append("\n");
      sb.Append("  ExpandRelationshipMetrics: ").Append(ExpandRelationshipMetrics).Append("\n");
      sb.Append("  ExpandRelationshipMetricsHistory: ").Append(ExpandRelationshipMetricsHistory).Append("\n");
      sb.Append("  IncludeSpamContacts: ").Append(IncludeSpamContacts).Append("\n");
      sb.Append("  Domain: ").Append(Domain).Append("\n");
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
