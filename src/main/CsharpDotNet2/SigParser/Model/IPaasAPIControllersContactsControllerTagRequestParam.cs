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
  public class IPaasAPIControllersContactsControllerTagRequestParam {
    /// <summary>
    /// The ID of the tag. You can get this by either calling the Tag/List method OR in the SigParser app by opening a tag details page and getting it from the URL.
    /// </summary>
    /// <value>The ID of the tag. You can get this by either calling the Tag/List method OR in the SigParser app by opening a tag details page and getting it from the URL.</value>
    [DataMember(Name="tagId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagId")]
    public Guid? TagId { get; set; }

    /// <summary>
    /// A list of email addresses to either Tag or Untag. We suggest only sending 250 or so email addresses at a time. It is safe to call this repeatedly on a contact as it won't duplicate tags.
    /// </summary>
    /// <value>A list of email addresses to either Tag or Untag. We suggest only sending 250 or so email addresses at a time. It is safe to call this repeatedly on a contact as it won't duplicate tags.</value>
    [DataMember(Name="emailaddresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailaddresses")]
    public List<string> Emailaddresses { get; set; }

    /// <summary>
    /// Either the word \"Tag\" or \"Untag\"
    /// </summary>
    /// <value>Either the word \"Tag\" or \"Untag\"</value>
    [DataMember(Name="operation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operation")]
    public string Operation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IPaasAPIControllersContactsControllerTagRequestParam {\n");
      sb.Append("  TagId: ").Append(TagId).Append("\n");
      sb.Append("  Emailaddresses: ").Append(Emailaddresses).Append("\n");
      sb.Append("  Operation: ").Append(Operation).Append("\n");
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
