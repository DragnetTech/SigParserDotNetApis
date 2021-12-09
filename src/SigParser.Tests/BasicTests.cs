using System;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SigParser.Api;
using SigParser.Model;

namespace SigParser.Tests
{
    [TestClass]
    public class BasicTests
    {
        public string ApiKey = Environment.GetEnvironmentVariable("SigParserPackageTestApiKey");
        
        
        
        [TestMethod]
        public void Companies()
        {
            SigParser.Client.Configuration.ApiKey.Add("x-api-key", ApiKey);
            var companyApi = new CompaniesApi();
            var companies = companyApi.ApiCompaniesGet(lastmodifiedAfter: 0, take: 10, domain: null);
            Assert.AreNotEqual(0, companies.Count());
        }
        
        [TestMethod]
        public void Contacts()
        {
            SigParser.Client.Configuration.ApiKey.Add("x-api-key", ApiKey);
            var contactsApi = new ContactsApi();
            var contacts = contactsApi.ApiContactsListPost(new DragnetTechSharedIPAASModelsRequestContactParam()
            {

            });
            
            Assert.AreNotEqual(0, contacts.Count());

        }
        
        [TestMethod]
        public void Emails()
        {
            SigParser.Client.Configuration.ApiKey.Add("x-api-key", ApiKey);
            var emailsApi = new EmailsApi();
            var emails = emailsApi.ApiEmailsDistinctGet(ingestedAfter: 0);
            
            Assert.AreNotEqual(0, emails.Count());

        }
        
        [TestMethod]
        public void Meetings()
        {
            SigParser.Client.Configuration.ApiKey.Add("x-api-key", ApiKey);
            var api = new MeetingsApi();
            var results = api.ApiMeetingsDistinctGet(lastmodifiedAfter: 0);
            
            Assert.AreNotEqual(0, results.Count());
        }

        [TestMethod]
        public void Parse_EML()
        {
            SigParser.Client.Configuration.ApiKey.Add("x-api-key", ApiKey);
            var api = new ParseApi();
            using var stream = System.IO.File.Open("example.eml", FileMode.Open);
            var results = api.ApiParseEmailContactMIMEPost(stream);
            
            Assert.IsNotNull(results.Signature);
        }
        
        [TestMethod]
        public void Parse_JSON()
        {
            SigParser.Client.Configuration.ApiKey.Add("x-api-key", ApiKey);
            var api = new ParseApi();
            
            var results = api.ApiParseEmailContactJSONPost(new IPaasAPIModelsParseEmailInputModel()
            {
                FromName = "John Smith",
                FromAddress = "john.smith@example.com",
                Plainbody = @"
Thanks for meeting the other day.

Thank you,
John Smith
VP of Operations
888-444-5534
San Diego, CA
"
            });
            
            Assert.IsNotNull(results.Signature);
        }
        
    }
}