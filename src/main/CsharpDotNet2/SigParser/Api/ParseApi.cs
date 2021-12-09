using System;
using System.Collections.Generic;
using RestSharp;
using SigParser.Client;
using SigParser.Model;

namespace SigParser.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IParseApi
    {
        /// <summary>
        /// Legacy email parsing API. Obselete. This API is no longer available for new users. If you are currently using this API we suggest you move to one of the other email parsing APIs next time you&#39;re making changes to your code. Those new APIs provide more fit for purpose results.
        /// </summary>
        /// <param name="body"></param>
        /// <returns>SigParserEmailParseResponse</returns>
        SigParserEmailParseResponse ApiEmailPost (IPaasAPIModelsParseEmailInputModel body);
        /// <summary>
        /// Legacy email parsing API for MIME. Obsolete. This is no longer available to new users. If you&#39;re an existing users you should migrate off of this and over to /api/Parse/Email/Message/MIME    Post the MIME encoded email text in the body to this API. If you have EML files then you need to post the contents of the EML file.
        /// </summary>
        /// <returns>IPaasAPIModelsParseCleanedBodyOutput</returns>
        IPaasAPIModelsParseCleanedBodyOutput ApiMimeParseStringPost ();
        /// <summary>
        /// Email signature parser JSON (stateless) Capture the email signature details for the sender of an email. This also will detect inline phone numbers such as \&quot;My phone number is 777-333-4444\&quot;.                Only use JSON as a last resort  - -- -- -- -- -- -- -  Use MIME or MSG endpoints if you have either of those formats available to you. MIME and MSG just require passing the contents. JSON requires mapping the fields properly and this is where most people have issues with the API.                Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don&#39;t store any of the data within the email. We store some statistics about the call but none of the email content will be store.     Mapping Tips  - -- -- -- -- -- -- -  If you don&#39;t have those as options then you can build the JSON structure representing your email and pass it.                You must set the **from_address** field for each email and it must match the signature of the email. We do a lot to try and avoid false matches and this can cause signature match rejections.                 Common Troubleshooting  - -- -- -- -- -- -- -- -- -- -- -- --  **Does the from_address match the signature?**                SigParser is very defensive when attempting to identify a signature to ensure quality data. If the email address in the from_address field doesn&#39;t match the email signature then the signature won&#39;t be identified.                **Does the from_name match the signature?**                While from_name isn&#39;t required it is required that when it is provided that it not be a different person on the email chain.     **Are you setting htmlbody and plainbody properly?**                Almost all email clients will provide you with both the HTML body and the plain text body. You need to use both. Some emails only have HTML, some have plain text and some have both. SigParser will choose which to use but you should be sure to pass both if available.    **Did you properly escape the JSON strings?**    A common issue is not escaping the JSON strings properly before sending the data to SigParser.
        /// </summary>
        /// <param name="body"></param>
        /// <returns>IPaasAPIModelsParseEmailSignatureV2Model</returns>
        IPaasAPIModelsParseEmailSignatureV2Model ApiParseEmailContactJSONPost (IPaasAPIModelsParseEmailInputModel body);
        /// <summary>
        /// Email signature parser MIME/EML (stateless) Capture the email signature details for the sender of an email. This also will detect inline phone numbers such as \&quot;My phone number is 777-333-4444\&quot;.    Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don&#39;t store any of the data within the email. We store some statistics about the call but none of the email content will be store.                 Message Body  - -- -- -- -- -- --  The message body should contain the MIME encoded contents only. Do not pass JSON.                *FYI: EML files are just MIME encoded files.*    A MIME email looks like this:                &#x60;&#x60;&#x60;  MIME-Version: 1.0  Date: Thu, 9 Sep 2021 15:21:50 -0700  Message-ID: &lt;CAL5Lp9VjUOJyab&#x3D;+3XQ0ymZMLHT4uC8KGRo1GDLrCQjh07oL6Q@mail.gmail.com&gt;  Subject: Test email  From: Paul Mendoza &lt;pmendoza@sigparser.com&gt;  To: Outlook Tester &lt;outlook.tester@salesforceemail.com&gt;  Content-Type: multipart/alternative; boundary&#x3D;\&quot;000000000000cd5df405cb976cd0\&quot;    - -000000000000cd5df405cb976cd0  Content-Type: text/plain; charset&#x3D;\&quot;UTF-8\&quot;    This is a test email.    Thanks  *Paul Mendoza*, Principal Software Engineer    - -000000000000cd5df405cb976cd0  Content-Type: text/html; charset&#x3D;\&quot;UTF-8\&quot;  Content-Transfer-Encoding: quoted-printable    &lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;This is a test email.&#x3D;C2&#x3D;A0&lt;div&gt;&lt;br&gt;&lt;/div&gt;&lt;div&gt;Thanks&lt;br c&#x3D;  lear&#x3D;3D\&quot;all\&quot;&gt;&lt;div&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot; class&#x3D;3D\&quot;gmail_signature\&quot; data-smartmail&#x3D;  &#x3D;3D\&quot;gmail_signature\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;di&#x3D;  v dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;font colo&#x3D;  r&#x3D;3D\&quot;#3d85c6\&quot; face&#x3D;3D\&quot;tahoma, sans-serif\&quot; style&#x3D;3D\&quot;font-size:12.8px\&quot;&gt;&lt;b&gt;Pau&#x3D;  l Mendoza&lt;/b&gt;&lt;/font&gt;&lt;font color&#x3D;3D\&quot;#3d85c6\&quot; face&#x3D;3D\&quot;tahoma, sans-serif\&quot; sty&#x3D;  le&#x3D;3D\&quot;font-size:12.8px;font-weight:bold\&quot;&gt;,&#x3D;C2&#x3D;A0&lt;/font&gt;&lt;font color&#x3D;3D\&quot;#3d85&#x3D;  c6\&quot; face&#x3D;3D\&quot;tahoma, sans-serif\&quot;&gt;&lt;span style&#x3D;3D\&quot;font-size:12.8px\&quot;&gt;Principal &#x3D;  Software Engineer&lt;/span&gt;&lt;/font&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/&#x3D;  div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;    - -000000000000cd5df405cb976cd0- -    &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="mimeFile"></param>
        /// <returns>IPaasAPIModelsParseEmailSignatureV2Model</returns>
        IPaasAPIModelsParseEmailSignatureV2Model ApiParseEmailContactMIMEPost (System.IO.Stream mimeFile);
        /// <summary>
        /// Email signature parser for MSG (stateless) Capture the email signature details for the sender of an email. This also will detect inline phone numbers such as \&quot;My phone number is 777-333-4444\&quot;.     MSG files are an export format from Microsoft Outlook and Exchange exports in some cases. They are binary so you can&#39;t look at the files but they should open in Outlook.                Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don&#39;t store any of the data within the email. We store some statistics about the call but none of the email content will be store.                 Message Body  - -- -- -- -- -- --  The message body should contain the MSG encoded contents only. Do not pass JSON.
        /// </summary>
        /// <param name="msgFile"></param>
        /// <returns>IPaasAPIModelsParseEmailSignatureV2Model</returns>
        IPaasAPIModelsParseEmailSignatureV2Model ApiParseEmailContactMSGPost (System.IO.Stream msgFile);
        /// <summary>
        /// Split email JSON (stateless) Parse the email into sections. Also useful if you need to get an email with the email signature stripped off.                 Only use JSON as a last resort  - -- -- -- -- -- -- -  Use MIME or MSG endpoints if you have either of those formats available to you. MIME and MSG just require passing the contents. JSON requires mapping the fields properly and this is where most people have issues with the API.                Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don&#39;t store any of the data within the email. We store some statistics about the call but none of the email content will be store.     Mapping Tips  - -- -- -- -- -- -- -  If you don&#39;t have those as options then you can build the JSON structure representing your email and pass it.                You must set the **from_address** field for each email and it must match the signature of the email. We do a lot to try and avoid false matches and this can cause signature match rejections.                 Common Troubleshooting  - -- -- -- -- -- -- -- -- -- -- -- --  **Does the from_address match the signature?**                SigParser is very defensive when attempting to identify a signature to ensure quality data. If the email address in the from_address field doesn&#39;t match the email signature then the signature won&#39;t be identified.                **Does the from_name match the signature?**                While from_name isn&#39;t required it is required that when it is provided that it not be a different person on the email chain.     **Are you setting htmlbody and plainbody properly?**                Almost all email clients will provide you with both the HTML body and the plain text body. You need to use both. Some emails only have HTML, some have plain text and some have both. SigParser will choose which to use but you should be sure to pass both if available.    **Did you properly escape the JSON strings?**    A common issue is not escaping the JSON strings properly before sending the data to SigParser.
        /// </summary>
        /// <param name="body"></param>
        /// <returns>IPaasAPIModelsParseCleanedBodyOutput</returns>
        IPaasAPIModelsParseCleanedBodyOutput ApiParseEmailMessageJSONPost (IPaasAPIModelsParseEmailInputModel body);
        /// <summary>
        /// Split email EML/MIME (stateless) Parse the email into sections. Useful if you need to get an email with the email signature stripped off.    Message Body  - -- -- -- -- -- --  The message body form field should contain the MIME encoded contents only. Do not pass JSON.                *FYI: EML files are just MIME encoded files.*    A MIME email looks like this:                &#x60;&#x60;&#x60;  MIME-Version: 1.0  Date: Thu, 9 Sep 2021 15:21:50 -0700  Message-ID: &lt;CAL5Lp9VjUOJyab&#x3D;+3XQ0ymZMLHT4uC8KGRo1GDLrCQjh07oL6Q@mail.gmail.com&gt;  Subject: Test email  From: Paul Mendoza &lt;pmendoza@sigparser.com&gt;  To: Outlook Tester &lt;outlook.tester@salesforceemail.com&gt;  Content-Type: multipart/alternative; boundary&#x3D;\&quot;000000000000cd5df405cb976cd0\&quot;    - -000000000000cd5df405cb976cd0  Content-Type: text/plain; charset&#x3D;\&quot;UTF-8\&quot;    This is a test email.    Thanks  *Paul Mendoza*, Principal Software Engineer    - -000000000000cd5df405cb976cd0  Content-Type: text/html; charset&#x3D;\&quot;UTF-8\&quot;  Content-Transfer-Encoding: quoted-printable    &lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;This is a test email.&#x3D;C2&#x3D;A0&lt;div&gt;&lt;br&gt;&lt;/div&gt;&lt;div&gt;Thanks&lt;br c&#x3D;  lear&#x3D;3D\&quot;all\&quot;&gt;&lt;div&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot; class&#x3D;3D\&quot;gmail_signature\&quot; data-smartmail&#x3D;  &#x3D;3D\&quot;gmail_signature\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;di&#x3D;  v dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;font colo&#x3D;  r&#x3D;3D\&quot;#3d85c6\&quot; face&#x3D;3D\&quot;tahoma, sans-serif\&quot; style&#x3D;3D\&quot;font-size:12.8px\&quot;&gt;&lt;b&gt;Pau&#x3D;  l Mendoza&lt;/b&gt;&lt;/font&gt;&lt;font color&#x3D;3D\&quot;#3d85c6\&quot; face&#x3D;3D\&quot;tahoma, sans-serif\&quot; sty&#x3D;  le&#x3D;3D\&quot;font-size:12.8px;font-weight:bold\&quot;&gt;,&#x3D;C2&#x3D;A0&lt;/font&gt;&lt;font color&#x3D;3D\&quot;#3d85&#x3D;  c6\&quot; face&#x3D;3D\&quot;tahoma, sans-serif\&quot;&gt;&lt;span style&#x3D;3D\&quot;font-size:12.8px\&quot;&gt;Principal &#x3D;  Software Engineer&lt;/span&gt;&lt;/font&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/&#x3D;  div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;    - -000000000000cd5df405cb976cd0- -  &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="mimeFile"></param>
        /// <returns>IPaasAPIModelsParseCleanedBodyOutput</returns>
        IPaasAPIModelsParseCleanedBodyOutput ApiParseEmailMessageMIMEPost (System.IO.Stream mimeFile);
        /// <summary>
        /// Split email MSG (stateless) Parse the email into sections. Useful if you need to get an email with the email signature stripped off.                MSG files are an export format from Microsoft Outlook and Exchange exports in some cases. They are binary so you can&#39;t look at the files but they should open in Outlook.                Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don&#39;t store any of the data within the email. We store some statistics about the call but none of the email content will be store.                 Message Body  - -- -- -- -- -- --  The message body should contain the MSG encoded contents only. Do not pass JSON.
        /// </summary>
        /// <param name="msgFile"></param>
        /// <returns>IPaasAPIModelsParseCleanedBodyOutput</returns>
        IPaasAPIModelsParseCleanedBodyOutput ApiParseEmailMessageMSGPost (System.IO.Stream msgFile);
        /// <summary>
        /// Report parsing feedback Submit feedback on a parsing issue to SigParser&#39;s algorithm development team. This will be added to our queue of emails to investigate.                The email will be stored by SigParser and the development/support teams will be able to see and investigate the issue. You can pass the SIGNATURE only as the emailcontents if you need to.                Parameters  - -- -- -- -- -- -- -- -- -- -  These parameters must all be supplied as FORM values.                - **emailcontents** - File upload of the the JSON, MIME or MSG version of the email. This should be what you submitted to one of the APIs.  - **filetype** - Either MSG, MIME, JSON or SIGNATURE. This should be the format of the file you&#39;re uploading.  - **command** - Either \&quot;Contact\&quot; for the signature parsing APIs or \&quot;Message\&quot; for the message splitting APIs.  - **description** - Details about the parsing error. For example, what was the bad value and what did the user expect?  - **feedback_email** - What email address should feedback about this parsing error be sent to?
        /// </summary>
        /// <param name="emailcontents">File contents for MSG or EML file.</param>
        /// <param name="filetype">Either MSG, MIME, JSON or SIGNATURE. This should be the format of the file you&#39;re uploading.</param>
        /// <param name="command">Either \&quot;Contact\&quot; for the signature parsing APIs or \&quot;Message\&quot; for the message splitting APIs.</param>
        /// <param name="description">Details about the parsing error. For example, what was the bad value and what did the user expect?</param>
        /// <param name="feedbackEmail">What email address should feedback about this parsing error be sent to?</param>
        /// <returns>IPaasAPIControllersParseControllerFeedbackResponseModel</returns>
        IPaasAPIControllersParseControllerFeedbackResponseModel ApiParseFeedbackPost (System.IO.Stream emailcontents, string filetype, string command, string description, string feedbackEmail);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ParseApi : IParseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ParseApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ParseApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Legacy email parsing API. Obselete. This API is no longer available for new users. If you are currently using this API we suggest you move to one of the other email parsing APIs next time you&#39;re making changes to your code. Those new APIs provide more fit for purpose results.
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>SigParserEmailParseResponse</returns>            
        public SigParserEmailParseResponse ApiEmailPost (IPaasAPIModelsParseEmailInputModel body)
        {
            
    
            var path = "/api/Email";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEmailPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEmailPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SigParserEmailParseResponse) ApiClient.Deserialize(response.Content, typeof(SigParserEmailParseResponse), response.Headers);
        }
    
        /// <summary>
        /// Legacy email parsing API for MIME. Obsolete. This is no longer available to new users. If you&#39;re an existing users you should migrate off of this and over to /api/Parse/Email/Message/MIME    Post the MIME encoded email text in the body to this API. If you have EML files then you need to post the contents of the EML file.
        /// </summary>
        /// <returns>IPaasAPIModelsParseCleanedBodyOutput</returns>            
        public IPaasAPIModelsParseCleanedBodyOutput ApiMimeParseStringPost ()
        {
            
    
            var path = "/api/Mime/ParseString";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiMimeParseStringPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiMimeParseStringPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIModelsParseCleanedBodyOutput) ApiClient.Deserialize(response.Content, typeof(IPaasAPIModelsParseCleanedBodyOutput), response.Headers);
        }
    
        /// <summary>
        /// Email signature parser JSON (stateless) Capture the email signature details for the sender of an email. This also will detect inline phone numbers such as \&quot;My phone number is 777-333-4444\&quot;.                Only use JSON as a last resort  - -- -- -- -- -- -- -  Use MIME or MSG endpoints if you have either of those formats available to you. MIME and MSG just require passing the contents. JSON requires mapping the fields properly and this is where most people have issues with the API.                Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don&#39;t store any of the data within the email. We store some statistics about the call but none of the email content will be store.     Mapping Tips  - -- -- -- -- -- -- -  If you don&#39;t have those as options then you can build the JSON structure representing your email and pass it.                You must set the **from_address** field for each email and it must match the signature of the email. We do a lot to try and avoid false matches and this can cause signature match rejections.                 Common Troubleshooting  - -- -- -- -- -- -- -- -- -- -- -- --  **Does the from_address match the signature?**                SigParser is very defensive when attempting to identify a signature to ensure quality data. If the email address in the from_address field doesn&#39;t match the email signature then the signature won&#39;t be identified.                **Does the from_name match the signature?**                While from_name isn&#39;t required it is required that when it is provided that it not be a different person on the email chain.     **Are you setting htmlbody and plainbody properly?**                Almost all email clients will provide you with both the HTML body and the plain text body. You need to use both. Some emails only have HTML, some have plain text and some have both. SigParser will choose which to use but you should be sure to pass both if available.    **Did you properly escape the JSON strings?**    A common issue is not escaping the JSON strings properly before sending the data to SigParser.
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>IPaasAPIModelsParseEmailSignatureV2Model</returns>            
        public IPaasAPIModelsParseEmailSignatureV2Model ApiParseEmailContactJSONPost (IPaasAPIModelsParseEmailInputModel body)
        {
            
    
            var path = "/api/Parse/Email/Contact/JSON";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseEmailContactJSONPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseEmailContactJSONPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIModelsParseEmailSignatureV2Model) ApiClient.Deserialize(response.Content, typeof(IPaasAPIModelsParseEmailSignatureV2Model), response.Headers);
        }
    
        /// <summary>
        /// Email signature parser MIME/EML (stateless) Capture the email signature details for the sender of an email. This also will detect inline phone numbers such as \&quot;My phone number is 777-333-4444\&quot;.    Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don&#39;t store any of the data within the email. We store some statistics about the call but none of the email content will be store.                 Message Body  - -- -- -- -- -- --  The message body should contain the MIME encoded contents only. Do not pass JSON.                *FYI: EML files are just MIME encoded files.*    A MIME email looks like this:                &#x60;&#x60;&#x60;  MIME-Version: 1.0  Date: Thu, 9 Sep 2021 15:21:50 -0700  Message-ID: &lt;CAL5Lp9VjUOJyab&#x3D;+3XQ0ymZMLHT4uC8KGRo1GDLrCQjh07oL6Q@mail.gmail.com&gt;  Subject: Test email  From: Paul Mendoza &lt;pmendoza@sigparser.com&gt;  To: Outlook Tester &lt;outlook.tester@salesforceemail.com&gt;  Content-Type: multipart/alternative; boundary&#x3D;\&quot;000000000000cd5df405cb976cd0\&quot;    - -000000000000cd5df405cb976cd0  Content-Type: text/plain; charset&#x3D;\&quot;UTF-8\&quot;    This is a test email.    Thanks  *Paul Mendoza*, Principal Software Engineer    - -000000000000cd5df405cb976cd0  Content-Type: text/html; charset&#x3D;\&quot;UTF-8\&quot;  Content-Transfer-Encoding: quoted-printable    &lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;This is a test email.&#x3D;C2&#x3D;A0&lt;div&gt;&lt;br&gt;&lt;/div&gt;&lt;div&gt;Thanks&lt;br c&#x3D;  lear&#x3D;3D\&quot;all\&quot;&gt;&lt;div&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot; class&#x3D;3D\&quot;gmail_signature\&quot; data-smartmail&#x3D;  &#x3D;3D\&quot;gmail_signature\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;di&#x3D;  v dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;font colo&#x3D;  r&#x3D;3D\&quot;#3d85c6\&quot; face&#x3D;3D\&quot;tahoma, sans-serif\&quot; style&#x3D;3D\&quot;font-size:12.8px\&quot;&gt;&lt;b&gt;Pau&#x3D;  l Mendoza&lt;/b&gt;&lt;/font&gt;&lt;font color&#x3D;3D\&quot;#3d85c6\&quot; face&#x3D;3D\&quot;tahoma, sans-serif\&quot; sty&#x3D;  le&#x3D;3D\&quot;font-size:12.8px;font-weight:bold\&quot;&gt;,&#x3D;C2&#x3D;A0&lt;/font&gt;&lt;font color&#x3D;3D\&quot;#3d85&#x3D;  c6\&quot; face&#x3D;3D\&quot;tahoma, sans-serif\&quot;&gt;&lt;span style&#x3D;3D\&quot;font-size:12.8px\&quot;&gt;Principal &#x3D;  Software Engineer&lt;/span&gt;&lt;/font&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/&#x3D;  div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;    - -000000000000cd5df405cb976cd0- -    &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="mimeFile"></param> 
        /// <returns>IPaasAPIModelsParseEmailSignatureV2Model</returns>            
        public IPaasAPIModelsParseEmailSignatureV2Model ApiParseEmailContactMIMEPost (System.IO.Stream mimeFile)
        {
            
    
            var path = "/api/Parse/Email/Contact/MIME";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (mimeFile != null) fileParams.Add("mimeFile", ApiClient.ParameterToFile("mimeFile", mimeFile));
                
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseEmailContactMIMEPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseEmailContactMIMEPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIModelsParseEmailSignatureV2Model) ApiClient.Deserialize(response.Content, typeof(IPaasAPIModelsParseEmailSignatureV2Model), response.Headers);
        }
    
        /// <summary>
        /// Email signature parser for MSG (stateless) Capture the email signature details for the sender of an email. This also will detect inline phone numbers such as \&quot;My phone number is 777-333-4444\&quot;.     MSG files are an export format from Microsoft Outlook and Exchange exports in some cases. They are binary so you can&#39;t look at the files but they should open in Outlook.                Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don&#39;t store any of the data within the email. We store some statistics about the call but none of the email content will be store.                 Message Body  - -- -- -- -- -- --  The message body should contain the MSG encoded contents only. Do not pass JSON.
        /// </summary>
        /// <param name="msgFile"></param> 
        /// <returns>IPaasAPIModelsParseEmailSignatureV2Model</returns>            
        public IPaasAPIModelsParseEmailSignatureV2Model ApiParseEmailContactMSGPost (System.IO.Stream msgFile)
        {
            
    
            var path = "/api/Parse/Email/Contact/MSG";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (msgFile != null) fileParams.Add("msgFile", ApiClient.ParameterToFile("msgFile", msgFile));
                
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseEmailContactMSGPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseEmailContactMSGPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIModelsParseEmailSignatureV2Model) ApiClient.Deserialize(response.Content, typeof(IPaasAPIModelsParseEmailSignatureV2Model), response.Headers);
        }
    
        /// <summary>
        /// Split email JSON (stateless) Parse the email into sections. Also useful if you need to get an email with the email signature stripped off.                 Only use JSON as a last resort  - -- -- -- -- -- -- -  Use MIME or MSG endpoints if you have either of those formats available to you. MIME and MSG just require passing the contents. JSON requires mapping the fields properly and this is where most people have issues with the API.                Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don&#39;t store any of the data within the email. We store some statistics about the call but none of the email content will be store.     Mapping Tips  - -- -- -- -- -- -- -  If you don&#39;t have those as options then you can build the JSON structure representing your email and pass it.                You must set the **from_address** field for each email and it must match the signature of the email. We do a lot to try and avoid false matches and this can cause signature match rejections.                 Common Troubleshooting  - -- -- -- -- -- -- -- -- -- -- -- --  **Does the from_address match the signature?**                SigParser is very defensive when attempting to identify a signature to ensure quality data. If the email address in the from_address field doesn&#39;t match the email signature then the signature won&#39;t be identified.                **Does the from_name match the signature?**                While from_name isn&#39;t required it is required that when it is provided that it not be a different person on the email chain.     **Are you setting htmlbody and plainbody properly?**                Almost all email clients will provide you with both the HTML body and the plain text body. You need to use both. Some emails only have HTML, some have plain text and some have both. SigParser will choose which to use but you should be sure to pass both if available.    **Did you properly escape the JSON strings?**    A common issue is not escaping the JSON strings properly before sending the data to SigParser.
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>IPaasAPIModelsParseCleanedBodyOutput</returns>            
        public IPaasAPIModelsParseCleanedBodyOutput ApiParseEmailMessageJSONPost (IPaasAPIModelsParseEmailInputModel body)
        {
            
    
            var path = "/api/Parse/Email/Message/JSON";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseEmailMessageJSONPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseEmailMessageJSONPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIModelsParseCleanedBodyOutput) ApiClient.Deserialize(response.Content, typeof(IPaasAPIModelsParseCleanedBodyOutput), response.Headers);
        }
    
        /// <summary>
        /// Split email EML/MIME (stateless) Parse the email into sections. Useful if you need to get an email with the email signature stripped off.    Message Body  - -- -- -- -- -- --  The message body form field should contain the MIME encoded contents only. Do not pass JSON.                *FYI: EML files are just MIME encoded files.*    A MIME email looks like this:                &#x60;&#x60;&#x60;  MIME-Version: 1.0  Date: Thu, 9 Sep 2021 15:21:50 -0700  Message-ID: &lt;CAL5Lp9VjUOJyab&#x3D;+3XQ0ymZMLHT4uC8KGRo1GDLrCQjh07oL6Q@mail.gmail.com&gt;  Subject: Test email  From: Paul Mendoza &lt;pmendoza@sigparser.com&gt;  To: Outlook Tester &lt;outlook.tester@salesforceemail.com&gt;  Content-Type: multipart/alternative; boundary&#x3D;\&quot;000000000000cd5df405cb976cd0\&quot;    - -000000000000cd5df405cb976cd0  Content-Type: text/plain; charset&#x3D;\&quot;UTF-8\&quot;    This is a test email.    Thanks  *Paul Mendoza*, Principal Software Engineer    - -000000000000cd5df405cb976cd0  Content-Type: text/html; charset&#x3D;\&quot;UTF-8\&quot;  Content-Transfer-Encoding: quoted-printable    &lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;This is a test email.&#x3D;C2&#x3D;A0&lt;div&gt;&lt;br&gt;&lt;/div&gt;&lt;div&gt;Thanks&lt;br c&#x3D;  lear&#x3D;3D\&quot;all\&quot;&gt;&lt;div&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot; class&#x3D;3D\&quot;gmail_signature\&quot; data-smartmail&#x3D;  &#x3D;3D\&quot;gmail_signature\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;di&#x3D;  v dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;div dir&#x3D;3D\&quot;ltr\&quot;&gt;&lt;font colo&#x3D;  r&#x3D;3D\&quot;#3d85c6\&quot; face&#x3D;3D\&quot;tahoma, sans-serif\&quot; style&#x3D;3D\&quot;font-size:12.8px\&quot;&gt;&lt;b&gt;Pau&#x3D;  l Mendoza&lt;/b&gt;&lt;/font&gt;&lt;font color&#x3D;3D\&quot;#3d85c6\&quot; face&#x3D;3D\&quot;tahoma, sans-serif\&quot; sty&#x3D;  le&#x3D;3D\&quot;font-size:12.8px;font-weight:bold\&quot;&gt;,&#x3D;C2&#x3D;A0&lt;/font&gt;&lt;font color&#x3D;3D\&quot;#3d85&#x3D;  c6\&quot; face&#x3D;3D\&quot;tahoma, sans-serif\&quot;&gt;&lt;span style&#x3D;3D\&quot;font-size:12.8px\&quot;&gt;Principal &#x3D;  Software Engineer&lt;/span&gt;&lt;/font&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/&#x3D;  div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;    - -000000000000cd5df405cb976cd0- -  &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="mimeFile"></param> 
        /// <returns>IPaasAPIModelsParseCleanedBodyOutput</returns>            
        public IPaasAPIModelsParseCleanedBodyOutput ApiParseEmailMessageMIMEPost (System.IO.Stream mimeFile)
        {
            
    
            var path = "/api/Parse/Email/Message/MIME";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (mimeFile != null) fileParams.Add("mimeFile", ApiClient.ParameterToFile("mimeFile", mimeFile));
                
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseEmailMessageMIMEPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseEmailMessageMIMEPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIModelsParseCleanedBodyOutput) ApiClient.Deserialize(response.Content, typeof(IPaasAPIModelsParseCleanedBodyOutput), response.Headers);
        }
    
        /// <summary>
        /// Split email MSG (stateless) Parse the email into sections. Useful if you need to get an email with the email signature stripped off.                MSG files are an export format from Microsoft Outlook and Exchange exports in some cases. They are binary so you can&#39;t look at the files but they should open in Outlook.                Stateless  - -- -- -- -- -- -- --                This is a stateless API meaning we don&#39;t store any of the data within the email. We store some statistics about the call but none of the email content will be store.                 Message Body  - -- -- -- -- -- --  The message body should contain the MSG encoded contents only. Do not pass JSON.
        /// </summary>
        /// <param name="msgFile"></param> 
        /// <returns>IPaasAPIModelsParseCleanedBodyOutput</returns>            
        public IPaasAPIModelsParseCleanedBodyOutput ApiParseEmailMessageMSGPost (System.IO.Stream msgFile)
        {
            
    
            var path = "/api/Parse/Email/Message/MSG";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (msgFile != null) fileParams.Add("msgFile", ApiClient.ParameterToFile("msgFile", msgFile));
                
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseEmailMessageMSGPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseEmailMessageMSGPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIModelsParseCleanedBodyOutput) ApiClient.Deserialize(response.Content, typeof(IPaasAPIModelsParseCleanedBodyOutput), response.Headers);
        }
    
        /// <summary>
        /// Report parsing feedback Submit feedback on a parsing issue to SigParser&#39;s algorithm development team. This will be added to our queue of emails to investigate.                The email will be stored by SigParser and the development/support teams will be able to see and investigate the issue. You can pass the SIGNATURE only as the emailcontents if you need to.                Parameters  - -- -- -- -- -- -- -- -- -- -  These parameters must all be supplied as FORM values.                - **emailcontents** - File upload of the the JSON, MIME or MSG version of the email. This should be what you submitted to one of the APIs.  - **filetype** - Either MSG, MIME, JSON or SIGNATURE. This should be the format of the file you&#39;re uploading.  - **command** - Either \&quot;Contact\&quot; for the signature parsing APIs or \&quot;Message\&quot; for the message splitting APIs.  - **description** - Details about the parsing error. For example, what was the bad value and what did the user expect?  - **feedback_email** - What email address should feedback about this parsing error be sent to?
        /// </summary>
        /// <param name="emailcontents">File contents for MSG or EML file.</param> 
        /// <param name="filetype">Either MSG, MIME, JSON or SIGNATURE. This should be the format of the file you&#39;re uploading.</param> 
        /// <param name="command">Either \&quot;Contact\&quot; for the signature parsing APIs or \&quot;Message\&quot; for the message splitting APIs.</param> 
        /// <param name="description">Details about the parsing error. For example, what was the bad value and what did the user expect?</param> 
        /// <param name="feedbackEmail">What email address should feedback about this parsing error be sent to?</param> 
        /// <returns>IPaasAPIControllersParseControllerFeedbackResponseModel</returns>            
        public IPaasAPIControllersParseControllerFeedbackResponseModel ApiParseFeedbackPost (System.IO.Stream emailcontents, string filetype, string command, string description, string feedbackEmail)
        {
            
    
            var path = "/api/Parse/Feedback";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (emailcontents != null) fileParams.Add("emailcontents", ApiClient.ParameterToFile("emailcontents", emailcontents));
if (filetype != null) formParams.Add("filetype", ApiClient.ParameterToString(filetype)); // form parameter
if (command != null) formParams.Add("command", ApiClient.ParameterToString(command)); // form parameter
if (description != null) formParams.Add("description", ApiClient.ParameterToString(description)); // form parameter
if (feedbackEmail != null) formParams.Add("feedback_email", ApiClient.ParameterToString(feedbackEmail)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "x-api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseFeedbackPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiParseFeedbackPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IPaasAPIControllersParseControllerFeedbackResponseModel) ApiClient.Deserialize(response.Content, typeof(IPaasAPIControllersParseControllerFeedbackResponseModel), response.Headers);
        }
    
    }
}
