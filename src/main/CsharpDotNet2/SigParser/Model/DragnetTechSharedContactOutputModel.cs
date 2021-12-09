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
  public class DragnetTechSharedContactOutputModel {
    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Email address for the contact. All email addresses are stored lowercased. This is the primary key for a contact. This will always be lowercase. Be sure to store it in your system as lowercase to match against SigParser.
    /// </summary>
    /// <value>Email address for the contact. All email addresses are stored lowercased. This is the primary key for a contact. This will always be lowercase. Be sure to store it in your system as lowercase to match against SigParser.</value>
    [DataMember(Name="emailaddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailaddress")]
    public string Emailaddress { get; set; }

    /// <summary>
    /// Status for the contact. Valid (default), Other, Private, Ignore, Coworker.
    /// </summary>
    /// <value>Status for the contact. Valid (default), Other, Private, Ignore, Coworker.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Full name for the contact.
    /// </summary>
    /// <value>Full name for the contact.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// First name for the contact.
    /// </summary>
    /// <value>First name for the contact.</value>
    [DataMember(Name="firstname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstname")]
    public string Firstname { get; set; }

    /// <summary>
    /// Last name for the contact.
    /// </summary>
    /// <value>Last name for the contact.</value>
    [DataMember(Name="lastname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastname")]
    public string Lastname { get; set; }

    /// <summary>
    /// Last time anything on the contact was modified.
    /// </summary>
    /// <value>Last time anything on the contact was modified.</value>
    [DataMember(Name="lastmodified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastmodified")]
    public DateTime? Lastmodified { get; set; }

    /// <summary>
    /// Job title for contact.
    /// </summary>
    /// <value>Job title for contact.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Phone number SigParser thinks is the best work phone number for the contact.
    /// </summary>
    /// <value>Phone number SigParser thinks is the best work phone number for the contact.</value>
    [DataMember(Name="work_phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "work_phone")]
    public string WorkPhone { get; set; }

    /// <summary>
    /// Phone number SigParser thinks is the best mobile phone number for the contact.
    /// </summary>
    /// <value>Phone number SigParser thinks is the best mobile phone number for the contact.</value>
    [DataMember(Name="mobile_phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobile_phone")]
    public string MobilePhone { get; set; }

    /// <summary>
    /// Phone number SigParser thinks is the best home phone number for the contact. This is rarely set.
    /// </summary>
    /// <value>Phone number SigParser thinks is the best home phone number for the contact. This is rarely set.</value>
    [DataMember(Name="home_phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "home_phone")]
    public string HomePhone { get; set; }

    /// <summary>
    /// Phone number SigParser thinks is the best voip phone number for the contact. This is rarely set.
    /// </summary>
    /// <value>Phone number SigParser thinks is the best voip phone number for the contact. This is rarely set.</value>
    [DataMember(Name="voip_phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "voip_phone")]
    public string VoipPhone { get; set; }

    /// <summary>
    /// Fax number
    /// </summary>
    /// <value>Fax number</value>
    [DataMember(Name="fax_phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fax_phone")]
    public string FaxPhone { get; set; }

    /// <summary>
    /// Any other phone number SigParser may have detected but couldn't categorize.
    /// </summary>
    /// <value>Any other phone number SigParser may have detected but couldn't categorize.</value>
    [DataMember(Name="other_phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "other_phone")]
    public string OtherPhone { get; set; }

    /// <summary>
    /// Emails the contact was on that were inbound to the oranization. Includes emails not sent by the contact. See direct_inbound_emails field for direct emails sent by this contact.
    /// </summary>
    /// <value>Emails the contact was on that were inbound to the oranization. Includes emails not sent by the contact. See direct_inbound_emails field for direct emails sent by this contact.</value>
    [DataMember(Name="stat_inboundemails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stat_inboundemails")]
    public int? StatInboundemails { get; set; }

    /// <summary>
    /// Emails where the contact was on an email going out of the organization. The contact could have been in the CC'd field. Use the direct_outbound_emails field if you only want emails where the contact was in the To field.
    /// </summary>
    /// <value>Emails where the contact was on an email going out of the organization. The contact could have been in the CC'd field. Use the direct_outbound_emails field if you only want emails where the contact was in the To field.</value>
    [DataMember(Name="stat_outboundemails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stat_outboundemails")]
    public int? StatOutboundemails { get; set; }

    /// <summary>
    /// Meetings the contact was on for all time.
    /// </summary>
    /// <value>Meetings the contact was on for all time.</value>
    [DataMember(Name="stat_externalmeetings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stat_externalmeetings")]
    public int? StatExternalmeetings { get; set; }

    /// <summary>
    /// Last time SigParser saw an email or meeting with this contact on it. If there is a future meeting then this date can be in the future.
    /// </summary>
    /// <value>Last time SigParser saw an email or meeting with this contact on it. If there is a future meeting then this date can be in the future.</value>
    [DataMember(Name="lastinteraction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastinteraction")]
    public DateTime? Lastinteraction { get; set; }

    /// <summary>
    /// Emails sent by this contact to your organization.
    /// </summary>
    /// <value>Emails sent by this contact to your organization.</value>
    [DataMember(Name="direct_inbound_emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direct_inbound_emails")]
    public int? DirectInboundEmails { get; set; }

    /// <summary>
    /// Emails to this contact from your organization.
    /// </summary>
    /// <value>Emails to this contact from your organization.</value>
    [DataMember(Name="direct_outbound_emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direct_outbound_emails")]
    public int? DirectOutboundEmails { get; set; }

    /// <summary>
    /// Emails the contact was CC'd on.
    /// </summary>
    /// <value>Emails the contact was CC'd on.</value>
    [DataMember(Name="cc_emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cc_emails")]
    public int? CcEmails { get; set; }

    /// <summary>
    /// Address captured from an email signature.
    /// </summary>
    /// <value>Address captured from an email signature.</value>
    [DataMember(Name="address_street", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_street")]
    public string AddressStreet { get; set; }

    /// <summary>
    /// Address captured from an email signature.
    /// </summary>
    /// <value>Address captured from an email signature.</value>
    [DataMember(Name="address_city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_city")]
    public string AddressCity { get; set; }

    /// <summary>
    /// Address captured from an email signature.
    /// </summary>
    /// <value>Address captured from an email signature.</value>
    [DataMember(Name="address_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_state")]
    public string AddressState { get; set; }

    /// <summary>
    /// Address captured from an email signature.
    /// </summary>
    /// <value>Address captured from an email signature.</value>
    [DataMember(Name="address_postalcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_postalcode")]
    public string AddressPostalcode { get; set; }

    /// <summary>
    /// Address captured from an email signature.
    /// </summary>
    /// <value>Address captured from an email signature.</value>
    [DataMember(Name="address_country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_country")]
    public string AddressCountry { get; set; }

    /// <summary>
    /// Location captured from one of the following sources in this order: Email signature, phone number, website domain. Other sources may be added later if available.
    /// </summary>
    /// <value>Location captured from one of the following sources in this order: Email signature, phone number, website domain. Other sources may be added later if available.</value>
    [DataMember(Name="location_city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_city")]
    public string LocationCity { get; set; }

    /// <summary>
    /// Location captured from one of the following sources in this order: Email signature, phone number, website domain. Other sources may be added later if available.
    /// </summary>
    /// <value>Location captured from one of the following sources in this order: Email signature, phone number, website domain. Other sources may be added later if available.</value>
    [DataMember(Name="location_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_state")]
    public string LocationState { get; set; }

    /// <summary>
    /// Location captured from one of the following sources in this order: Email signature, phone number, website domain. Other sources may be added later if available.
    /// </summary>
    /// <value>Location captured from one of the following sources in this order: Email signature, phone number, website domain. Other sources may be added later if available.</value>
    [DataMember(Name="location_zipcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_zipcode")]
    public string LocationZipcode { get; set; }

    /// <summary>
    /// Location captured from one of the following sources in this order: Email signature, phone number, website domain. Other sources may be added later if available.
    /// </summary>
    /// <value>Location captured from one of the following sources in this order: Email signature, phone number, website domain. Other sources may be added later if available.</value>
    [DataMember(Name="location_country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_country")]
    public string LocationCountry { get; set; }

    /// <summary>
    /// Geocode from the location.
    /// </summary>
    /// <value>Geocode from the location.</value>
    [DataMember(Name="location_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_latitude")]
    public double? LocationLatitude { get; set; }

    /// <summary>
    /// Geocode from the location.
    /// </summary>
    /// <value>Geocode from the location.</value>
    [DataMember(Name="location_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_longitude")]
    public double? LocationLongitude { get; set; }

    /// <summary>
    /// The company name as it was parsed from the email signature. WARNING: This isn't always the same as the account name in SigParser.
    /// </summary>
    /// <value>The company name as it was parsed from the email signature. WARNING: This isn't always the same as the account name in SigParser.</value>
    [DataMember(Name="organizationname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organizationname")]
    public string Organizationname { get; set; }

    /// <summary>
    /// Website URL parsed from the email signature.
    /// </summary>
    /// <value>Website URL parsed from the email signature.</value>
    [DataMember(Name="website", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "website")]
    public string Website { get; set; }

    /// <summary>
    /// Gets or Sets Linkedinurl
    /// </summary>
    [DataMember(Name="linkedinurl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedinurl")]
    public string Linkedinurl { get; set; }

    /// <summary>
    /// Gets or Sets Linkedinid
    /// </summary>
    [DataMember(Name="linkedinid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedinid")]
    public string Linkedinid { get; set; }

    /// <summary>
    /// Gets or Sets Twitterurl
    /// </summary>
    [DataMember(Name="twitterurl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twitterurl")]
    public string Twitterurl { get; set; }

    /// <summary>
    /// Gets or Sets Twitterhandle
    /// </summary>
    [DataMember(Name="twitterhandle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twitterhandle")]
    public string Twitterhandle { get; set; }

    /// <summary>
    /// Date when an email bounce was detected for the contact. Good to filter these out so they don't go to marketing systems.
    /// </summary>
    /// <value>Date when an email bounce was detected for the contact. Good to filter these out so they don't go to marketing systems.</value>
    [DataMember(Name="emailbouncedate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailbouncedate")]
    public DateTime? Emailbouncedate { get; set; }

    /// <summary>
    /// Number of email bounces ever recorded for this contact.
    /// </summary>
    /// <value>Number of email bounces ever recorded for this contact.</value>
    [DataMember(Name="emailbounces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailbounces")]
    public int? Emailbounces { get; set; }

    /// <summary>
    /// Tracks when a webhook was posted. This field is no longer valid.
    /// </summary>
    /// <value>Tracks when a webhook was posted. This field is no longer valid.</value>
    [DataMember(Name="webhookpostedat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webhookpostedat")]
    public DateTime? Webhookpostedat { get; set; }

    /// <summary>
    /// Names of the mailboxes or other sources the contact was found in.
    /// </summary>
    /// <value>Names of the mailboxes or other sources the contact was found in.</value>
    [DataMember(Name="sources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sources")]
    public List<string> Sources { get; set; }

    /// <summary>
    /// The status of the email verification for this email address. Valid values are: \"Valid\", \"Invalid\", \"Unknown\", \"Catch All\".    Contacts will have null if they haven't been checked yet.   Not all plans include this feature so you'll need to check if your plan has this.
    /// </summary>
    /// <value>The status of the email verification for this email address. Valid values are: \"Valid\", \"Invalid\", \"Unknown\", \"Catch All\".    Contacts will have null if they haven't been checked yet.   Not all plans include this feature so you'll need to check if your plan has this.</value>
    [DataMember(Name="emailstatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailstatus")]
    public string Emailstatus { get; set; }

    /// <summary>
    /// Last time the email status changed.
    /// </summary>
    /// <value>Last time the email status changed.</value>
    [DataMember(Name="emailstatusmodified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailstatusmodified")]
    public DateTime? Emailstatusmodified { get; set; }

    /// <summary>
    /// Last time the email verification status (emailstatus) was checked.
    /// </summary>
    /// <value>Last time the email verification status (emailstatus) was checked.</value>
    [DataMember(Name="emailstatuslastchecked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailstatuslastchecked")]
    public DateTime? Emailstatuslastchecked { get; set; }

    /// <summary>
    /// Raw status from the email validation provider.
    /// </summary>
    /// <value>Raw status from the email validation provider.</value>
    [DataMember(Name="emailvalidation_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailvalidation_status")]
    public string EmailvalidationStatus { get; set; }

    /// <summary>
    /// The raw sub status for the email validation from the provider.
    /// </summary>
    /// <value>The raw sub status for the email validation from the provider.</value>
    [DataMember(Name="emailvalidation_sub_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailvalidation_sub_status")]
    public string EmailvalidationSubStatus { get; set; }

    /// <summary>
    /// The score from the email validation provider.
    /// </summary>
    /// <value>The score from the email validation provider.</value>
    [DataMember(Name="emailvalidation_score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailvalidation_score")]
    public double? EmailvalidationScore { get; set; }

    /// <summary>
    /// The email validation vendor name. For example, Clearout.
    /// </summary>
    /// <value>The email validation vendor name. For example, Clearout.</value>
    [DataMember(Name="emailvalidation_provider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailvalidation_provider")]
    public string EmailvalidationProvider { get; set; }

    /// <summary>
    /// Is the email provider like Gmail or Yahoo or AOL?
    /// </summary>
    /// <value>Is the email provider like Gmail or Yahoo or AOL?</value>
    [DataMember(Name="freeemailprovider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "freeemailprovider")]
    public bool? Freeemailprovider { get; set; }

    /// <summary>
    /// Is this a fake email account like mailinator.
    /// </summary>
    /// <value>Is this a fake email account like mailinator.</value>
    [DataMember(Name="fakeemailaddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fakeemailaddress")]
    public bool? Fakeemailaddress { get; set; }

    /// <summary>
    /// The last email this contact sent into the company.
    /// </summary>
    /// <value>The last email this contact sent into the company.</value>
    [DataMember(Name="lastinboundemail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastinboundemail")]
    public DateTime? Lastinboundemail { get; set; }

    /// <summary>
    /// The last time someone at the company sent an email to this person.
    /// </summary>
    /// <value>The last time someone at the company sent an email to this person.</value>
    [DataMember(Name="lastoutboundemail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastoutboundemail")]
    public DateTime? Lastoutboundemail { get; set; }

    /// <summary>
    /// Is this contact likely not a real human. This is detected using SigParser's pattern matching.   You should also check the emailstatus column if your subscription plan supports that feature.
    /// </summary>
    /// <value>Is this contact likely not a real human. This is detected using SigParser's pattern matching.   You should also check the emailstatus column if your subscription plan supports that feature.</value>
    [DataMember(Name="isspam", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isspam")]
    public bool? Isspam { get; set; }

    /// <summary>
    /// All of the tags and buckets.
    /// </summary>
    /// <value>All of the tags and buckets.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<DragnetTechSharedIPAASModelsTag> Tags { get; set; }

    /// <summary>
    /// A distinct list of email folder names this contact has been found in.
    /// </summary>
    /// <value>A distinct list of email folder names this contact has been found in.</value>
    [DataMember(Name="email_folder_names", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email_folder_names")]
    public List<string> EmailFolderNames { get; set; }

    /// <summary>
    /// A pipe separated list of tags applied to the contact.   Example: Tag - Prospects|Role - Owners|Role - Assistants|Email Folder - 2020 Clients|Email Folder - 2019 Clients
    /// </summary>
    /// <value>A pipe separated list of tags applied to the contact.   Example: Tag - Prospects|Role - Owners|Role - Assistants|Email Folder - 2020 Clients|Email Folder - 2019 Clients</value>
    [DataMember(Name="tags_psv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags_psv")]
    public string TagsPsv { get; set; }

    /// <summary>
    /// Email address of the internal contact with the best relationship with this person. The algorithm used to determine this takes   into account the recent vs old communication patterns.
    /// </summary>
    /// <value>Email address of the internal contact with the best relationship with this person. The algorithm used to determine this takes   into account the recent vs old communication patterns.</value>
    [DataMember(Name="closest_internal_contact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closest_internal_contact")]
    public string ClosestInternalContact { get; set; }

    /// <summary>
    /// The mailbox with the most activity. This is generally an email address but doesn't have to be.
    /// </summary>
    /// <value>The mailbox with the most activity. This is generally an email address but doesn't have to be.</value>
    [DataMember(Name="most_active_mailbox", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "most_active_mailbox")]
    public string MostActiveMailbox { get; set; }

    /// <summary>
    /// Relationship metrics for all contacts who appeared on an interaction in relation to this contact.  This will return the 25 strongest relationships.     By default this isn't returned. To get this returned in the result set you must set expand_relationship_metrics = true.
    /// </summary>
    /// <value>Relationship metrics for all contacts who appeared on an interaction in relation to this contact.  This will return the 25 strongest relationships.     By default this isn't returned. To get this returned in the result set you must set expand_relationship_metrics = true.</value>
    [DataMember(Name="relationship_metrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relationship_metrics")]
    public List<DragnetTechSharedRelationshipMetric> RelationshipMetrics { get; set; }

    /// <summary>
    /// CSV list of the mailboxes this contact appeared in. Useful for mapping into a field in the CRM or destination system.
    /// </summary>
    /// <value>CSV list of the mailboxes this contact appeared in. Useful for mapping into a field in the CRM or destination system.</value>
    [DataMember(Name="mailboxes_csv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mailboxes_csv")]
    public string MailboxesCsv { get; set; }

    /// <summary>
    /// SigParser may incorrectly associate contact data from an internal contact to an external contact or  there may be some issues with the quality of the contact parse. This field indicates if SigParser thinks  there may be an issue with the quality of the data. We suggest not pushing this data to the CRM in these cases  or at least the contact data like phone numbers, titles and addresses. The statistics should still be accurate.
    /// </summary>
    /// <value>SigParser may incorrectly associate contact data from an internal contact to an external contact or  there may be some issues with the quality of the contact parse. This field indicates if SigParser thinks  there may be an issue with the quality of the data. We suggest not pushing this data to the CRM in these cases  or at least the contact data like phone numbers, titles and addresses. The statistics should still be accurate.</value>
    [DataMember(Name="potential_parsing_error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "potential_parsing_error")]
    public bool? PotentialParsingError { get; set; }

    /// <summary>
    /// Internal ID for the contact in SigParser.
    /// </summary>
    /// <value>Internal ID for the contact in SigParser.</value>
    [DataMember(Name="internal_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internal_id")]
    public Guid? InternalId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DragnetTechSharedContactOutputModel {\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  Emailaddress: ").Append(Emailaddress).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Firstname: ").Append(Firstname).Append("\n");
      sb.Append("  Lastname: ").Append(Lastname).Append("\n");
      sb.Append("  Lastmodified: ").Append(Lastmodified).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
      sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
      sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
      sb.Append("  VoipPhone: ").Append(VoipPhone).Append("\n");
      sb.Append("  FaxPhone: ").Append(FaxPhone).Append("\n");
      sb.Append("  OtherPhone: ").Append(OtherPhone).Append("\n");
      sb.Append("  StatInboundemails: ").Append(StatInboundemails).Append("\n");
      sb.Append("  StatOutboundemails: ").Append(StatOutboundemails).Append("\n");
      sb.Append("  StatExternalmeetings: ").Append(StatExternalmeetings).Append("\n");
      sb.Append("  Lastinteraction: ").Append(Lastinteraction).Append("\n");
      sb.Append("  DirectInboundEmails: ").Append(DirectInboundEmails).Append("\n");
      sb.Append("  DirectOutboundEmails: ").Append(DirectOutboundEmails).Append("\n");
      sb.Append("  CcEmails: ").Append(CcEmails).Append("\n");
      sb.Append("  AddressStreet: ").Append(AddressStreet).Append("\n");
      sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
      sb.Append("  AddressState: ").Append(AddressState).Append("\n");
      sb.Append("  AddressPostalcode: ").Append(AddressPostalcode).Append("\n");
      sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
      sb.Append("  LocationCity: ").Append(LocationCity).Append("\n");
      sb.Append("  LocationState: ").Append(LocationState).Append("\n");
      sb.Append("  LocationZipcode: ").Append(LocationZipcode).Append("\n");
      sb.Append("  LocationCountry: ").Append(LocationCountry).Append("\n");
      sb.Append("  LocationLatitude: ").Append(LocationLatitude).Append("\n");
      sb.Append("  LocationLongitude: ").Append(LocationLongitude).Append("\n");
      sb.Append("  Organizationname: ").Append(Organizationname).Append("\n");
      sb.Append("  Website: ").Append(Website).Append("\n");
      sb.Append("  Linkedinurl: ").Append(Linkedinurl).Append("\n");
      sb.Append("  Linkedinid: ").Append(Linkedinid).Append("\n");
      sb.Append("  Twitterurl: ").Append(Twitterurl).Append("\n");
      sb.Append("  Twitterhandle: ").Append(Twitterhandle).Append("\n");
      sb.Append("  Emailbouncedate: ").Append(Emailbouncedate).Append("\n");
      sb.Append("  Emailbounces: ").Append(Emailbounces).Append("\n");
      sb.Append("  Webhookpostedat: ").Append(Webhookpostedat).Append("\n");
      sb.Append("  Sources: ").Append(Sources).Append("\n");
      sb.Append("  Emailstatus: ").Append(Emailstatus).Append("\n");
      sb.Append("  Emailstatusmodified: ").Append(Emailstatusmodified).Append("\n");
      sb.Append("  Emailstatuslastchecked: ").Append(Emailstatuslastchecked).Append("\n");
      sb.Append("  EmailvalidationStatus: ").Append(EmailvalidationStatus).Append("\n");
      sb.Append("  EmailvalidationSubStatus: ").Append(EmailvalidationSubStatus).Append("\n");
      sb.Append("  EmailvalidationScore: ").Append(EmailvalidationScore).Append("\n");
      sb.Append("  EmailvalidationProvider: ").Append(EmailvalidationProvider).Append("\n");
      sb.Append("  Freeemailprovider: ").Append(Freeemailprovider).Append("\n");
      sb.Append("  Fakeemailaddress: ").Append(Fakeemailaddress).Append("\n");
      sb.Append("  Lastinboundemail: ").Append(Lastinboundemail).Append("\n");
      sb.Append("  Lastoutboundemail: ").Append(Lastoutboundemail).Append("\n");
      sb.Append("  Isspam: ").Append(Isspam).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  EmailFolderNames: ").Append(EmailFolderNames).Append("\n");
      sb.Append("  TagsPsv: ").Append(TagsPsv).Append("\n");
      sb.Append("  ClosestInternalContact: ").Append(ClosestInternalContact).Append("\n");
      sb.Append("  MostActiveMailbox: ").Append(MostActiveMailbox).Append("\n");
      sb.Append("  RelationshipMetrics: ").Append(RelationshipMetrics).Append("\n");
      sb.Append("  MailboxesCsv: ").Append(MailboxesCsv).Append("\n");
      sb.Append("  PotentialParsingError: ").Append(PotentialParsingError).Append("\n");
      sb.Append("  InternalId: ").Append(InternalId).Append("\n");
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
