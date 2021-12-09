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
  public class DragnetTechSharedIPAASModelsEmailOutputModel {
    /// <summary>
    /// This should be used to fetch emails with the /api/Emails/Distinct API  When using ingested_after parameter you should save the max ingestion_key value in the response and make the next request with that value in the ingested_after field.
    /// </summary>
    /// <value>This should be used to fetch emails with the /api/Emails/Distinct API  When using ingested_after parameter you should save the max ingestion_key value in the response and make the next request with that value in the ingested_after field.</value>
    [DataMember(Name="ingestion_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ingestion_key")]
    public long? IngestionKey { get; set; }

    /// <summary>
    /// Gets or Sets Mailboxinstance
    /// </summary>
    [DataMember(Name="mailboxinstance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mailboxinstance")]
    public DragnetTechSharedIPAASModelsEmailOutputModelMailbox Mailboxinstance { get; set; }

    /// <summary>
    /// Date and time for the email.
    /// </summary>
    /// <value>Date and time for the email.</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Gets or Sets From
    /// </summary>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public DragnetTechSharedIPAASModelsEmailOutputModelPerson From { get; set; }

    /// <summary>
    /// People in the \"To\" field
    /// </summary>
    /// <value>People in the \"To\" field</value>
    [DataMember(Name="to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to")]
    public List<DragnetTechSharedIPAASModelsEmailOutputModelPerson> To { get; set; }

    /// <summary>
    /// People in the \"CC\" field.
    /// </summary>
    /// <value>People in the \"CC\" field.</value>
    [DataMember(Name="cc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cc")]
    public List<DragnetTechSharedIPAASModelsEmailOutputModelPerson> Cc { get; set; }

    /// <summary>
    /// All of the attachements on this email. Does not include embedded attachments.
    /// </summary>
    /// <value>All of the attachements on this email. Does not include embedded attachments.</value>
    [DataMember(Name="attachments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attachments")]
    public List<DragnetTechSharedIPAASModelsEmailOutputModelAttachment> Attachments { get; set; }

    /// <summary>
    /// Subject line for the email.
    /// </summary>
    /// <value>Subject line for the email.</value>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subject")]
    public string Subject { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DragnetTechSharedIPAASModelsEmailOutputModel {\n");
      sb.Append("  IngestionKey: ").Append(IngestionKey).Append("\n");
      sb.Append("  Mailboxinstance: ").Append(Mailboxinstance).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  From: ").Append(From).Append("\n");
      sb.Append("  To: ").Append(To).Append("\n");
      sb.Append("  Cc: ").Append(Cc).Append("\n");
      sb.Append("  Attachments: ").Append(Attachments).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
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
