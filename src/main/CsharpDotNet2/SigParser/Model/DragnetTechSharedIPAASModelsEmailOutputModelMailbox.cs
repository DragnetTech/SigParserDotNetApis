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
  public class DragnetTechSharedIPAASModelsEmailOutputModelMailbox {
    /// <summary>
    /// Google, Office365, IMAP, Exchange, PST
    /// </summary>
    /// <value>Google, Office365, IMAP, Exchange, PST</value>
    [DataMember(Name="mailboxtype", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mailboxtype")]
    public string Mailboxtype { get; set; }

    /// <summary>
    /// Gets or Sets Mailboxid
    /// </summary>
    [DataMember(Name="mailboxid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mailboxid")]
    public string Mailboxid { get; set; }

    /// <summary>
    /// Name of the emailbox where the email came from. This is almost always the email address.
    /// </summary>
    /// <value>Name of the emailbox where the email came from. This is almost always the email address.</value>
    [DataMember(Name="mailbox_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mailbox_name")]
    public string MailboxName { get; set; }

    /// <summary>
    /// ID for the message in the email account. This ID could be used to query the message from the Gmail API or from the Office 365 Graph API.   If this is an IMAP account it will be a UID number.
    /// </summary>
    /// <value>ID for the message in the email account. This ID could be used to query the message from the Gmail API or from the Office 365 Graph API.   If this is an IMAP account it will be a UID number.</value>
    [DataMember(Name="messageid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "messageid")]
    public string Messageid { get; set; }

    /// <summary>
    /// The mailbox specific conversation ID for this instance of the message.
    /// </summary>
    /// <value>The mailbox specific conversation ID for this instance of the message.</value>
    [DataMember(Name="conversationid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conversationid")]
    public string Conversationid { get; set; }

    /// <summary>
    /// SigParser internal ID for the email. Use this when fetching a particular email.
    /// </summary>
    /// <value>SigParser internal ID for the email. Use this when fetching a particular email.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DragnetTechSharedIPAASModelsEmailOutputModelMailbox {\n");
      sb.Append("  Mailboxtype: ").Append(Mailboxtype).Append("\n");
      sb.Append("  Mailboxid: ").Append(Mailboxid).Append("\n");
      sb.Append("  MailboxName: ").Append(MailboxName).Append("\n");
      sb.Append("  Messageid: ").Append(Messageid).Append("\n");
      sb.Append("  Conversationid: ").Append(Conversationid).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
