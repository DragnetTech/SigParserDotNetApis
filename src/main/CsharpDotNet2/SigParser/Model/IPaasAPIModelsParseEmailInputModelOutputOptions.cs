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
  public class IPaasAPIModelsParseEmailInputModelOutputOptions {
    /// <summary>
    /// Performance setting (default 1): Control to what depth the fields cleanedemailbody, emails.cleanedBodyHTML are generated with HTML.                Generating these fields can be expensive so this is meant to help improve performance for some customers that don't need these fields.                0 would mean no HTML output. 1 would mean only the root email gets a cleaned version. 2 means the root email and the next previous email in the chain.                The plain text versions will still be set.                If you don't ever need the data in these fields then set to 0 to get a slightly faster average response.
    /// </summary>
    /// <value>Performance setting (default 1): Control to what depth the fields cleanedemailbody, emails.cleanedBodyHTML are generated with HTML.                Generating these fields can be expensive so this is meant to help improve performance for some customers that don't need these fields.                0 would mean no HTML output. 1 would mean only the root email gets a cleaned version. 2 means the root email and the next previous email in the chain.                The plain text versions will still be set.                If you don't ever need the data in these fields then set to 0 to get a slightly faster average response.</value>
    [DataMember(Name="OutputCleanedEmailHtmlDepth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OutputCleanedEmailHtmlDepth")]
    public int? OutputCleanedEmailHtmlDepth { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IPaasAPIModelsParseEmailInputModelOutputOptions {\n");
      sb.Append("  OutputCleanedEmailHtmlDepth: ").Append(OutputCleanedEmailHtmlDepth).Append("\n");
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
