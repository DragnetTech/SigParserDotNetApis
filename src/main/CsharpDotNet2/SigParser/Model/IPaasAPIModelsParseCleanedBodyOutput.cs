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
  public class IPaasAPIModelsParseCleanedBodyOutput {
    /// <summary>
    /// Gets or Sets Errors
    /// </summary>
    [DataMember(Name="Errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Errors")]
    public List<string> Errors { get; set; }

    /// <summary>
    /// The email with the signature and reply chains removed. If the email was originally HTML then this is the HTML converted to text.
    /// </summary>
    /// <value>The email with the signature and reply chains removed. If the email was originally HTML then this is the HTML converted to text.</value>
    [DataMember(Name="CleanedBodyPlain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CleanedBodyPlain")]
    public string CleanedBodyPlain { get; set; }

    /// <summary>
    /// The body of the email.
    /// </summary>
    /// <value>The body of the email.</value>
    [DataMember(Name="CleanedBodyHtml", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CleanedBodyHtml")]
    public string CleanedBodyHtml { get; set; }

    /// <summary>
    /// Is this email a spammy looking message or a non-human type sender. You likely don't want to use the CleeanedBody fields when rendering this message but you could if you wanted to.
    /// </summary>
    /// <value>Is this email a spammy looking message or a non-human type sender. You likely don't want to use the CleeanedBody fields when rendering this message but you could if you wanted to.</value>
    [DataMember(Name="IsSpammyLookingEmailMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSpammyLookingEmailMessage")]
    public bool? IsSpammyLookingEmailMessage { get; set; }

    /// <summary>
    /// Does the sender of this message look like they're a spammer.
    /// </summary>
    /// <value>Does the sender of this message look like they're a spammer.</value>
    [DataMember(Name="IsSpammyLookingSender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSpammyLookingSender")]
    public bool? IsSpammyLookingSender { get; set; }

    /// <summary>
    /// The known type of email that this is. Useful for determining how you want to display this in a user interface. Other types will be added over time.                - NormalEmail - A normal email from a human. Over time as we build handlers for new types of emails.  - MeetingNotification  - BouncedNotification  - ZenDeskSupportChain  - SecureMessage - Secure messages only include a link and some way to access the email. These are sensitive emails.
    /// </summary>
    /// <value>The known type of email that this is. Useful for determining how you want to display this in a user interface. Other types will be added over time.                - NormalEmail - A normal email from a human. Over time as we build handlers for new types of emails.  - MeetingNotification  - BouncedNotification  - ZenDeskSupportChain  - SecureMessage - Secure messages only include a link and some way to access the email. These are sensitive emails.</value>
    [DataMember(Name="EmailTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailTypes")]
    public List<string> EmailTypes { get; set; }

    /// <summary>
    /// Collection of all the emails extracted from the body. The first email is the most recent and the last one is the oldest. The parse quality drops off the deeper you go though since there is a bigger chance for corrupted headers.
    /// </summary>
    /// <value>Collection of all the emails extracted from the body. The first email is the most recent and the last one is the oldest. The parse quality drops off the deeper you go though since there is a bigger chance for corrupted headers.</value>
    [DataMember(Name="Emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Emails")]
    public List<IPaasAPIModelsParseEmail> Emails { get; set; }

    /// <summary>
    /// Subject of the email as it was passed into the function or extracted from the header of the email.
    /// </summary>
    /// <value>Subject of the email as it was passed into the function or extracted from the header of the email.</value>
    [DataMember(Name="Subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Subject")]
    public string Subject { get; set; }

    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="Date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Gets or Sets Headers
    /// </summary>
    [DataMember(Name="Headers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Headers")]
    public Dictionary<string, string> Headers { get; set; }

    /// <summary>
    /// Gets or Sets FullPlainTextBody
    /// </summary>
    [DataMember(Name="FullPlainTextBody", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FullPlainTextBody")]
    public string FullPlainTextBody { get; set; }

    /// <summary>
    /// Gets or Sets FullHtmlBody
    /// </summary>
    [DataMember(Name="FullHtmlBody", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FullHtmlBody")]
    public string FullHtmlBody { get; set; }

    /// <summary>
    /// Type of the .msg file.
    /// </summary>
    /// <value>Type of the .msg file.</value>
    [DataMember(Name="MsgType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MsgType")]
    public string MsgType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IPaasAPIModelsParseCleanedBodyOutput {\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      sb.Append("  CleanedBodyPlain: ").Append(CleanedBodyPlain).Append("\n");
      sb.Append("  CleanedBodyHtml: ").Append(CleanedBodyHtml).Append("\n");
      sb.Append("  IsSpammyLookingEmailMessage: ").Append(IsSpammyLookingEmailMessage).Append("\n");
      sb.Append("  IsSpammyLookingSender: ").Append(IsSpammyLookingSender).Append("\n");
      sb.Append("  EmailTypes: ").Append(EmailTypes).Append("\n");
      sb.Append("  Emails: ").Append(Emails).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Headers: ").Append(Headers).Append("\n");
      sb.Append("  FullPlainTextBody: ").Append(FullPlainTextBody).Append("\n");
      sb.Append("  FullHtmlBody: ").Append(FullHtmlBody).Append("\n");
      sb.Append("  MsgType: ").Append(MsgType).Append("\n");
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
