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
  public class IPaasAPIControllersContactsControllerCustomTagList {
    /// <summary>
    /// The full name of the tag. It will be of the form \"Tag - Prospects\" or \"Location - Asia Pacific\" or \"Folder - Inbox\"
    /// </summary>
    /// <value>The full name of the tag. It will be of the form \"Tag - Prospects\" or \"Location - Asia Pacific\" or \"Folder - Inbox\"</value>
    [DataMember(Name="fullName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullName")]
    public string FullName { get; set; }

    /// <summary>
    /// The type of tag.
    /// </summary>
    /// <value>The type of tag.</value>
    [DataMember(Name="bucketType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bucketType")]
    public string BucketType { get; set; }

    /// <summary>
    /// Only the name of the tag.
    /// </summary>
    /// <value>Only the name of the tag.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// ID of the tag.
    /// </summary>
    /// <value>ID of the tag.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IPaasAPIControllersContactsControllerCustomTagList {\n");
      sb.Append("  FullName: ").Append(FullName).Append("\n");
      sb.Append("  BucketType: ").Append(BucketType).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
