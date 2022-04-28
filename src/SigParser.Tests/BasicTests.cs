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
        public static string ApiKey = Environment.GetEnvironmentVariable("SigParserPackageTestApiKey");

        [ClassInitialize]
        public static void TestClassInit(TestContext context)
        {
            SigParser.Client.Configuration.ApiKey.Add("x-api-key", ApiKey);
        }
        
        [TestMethod]
        public void Companies()
        {
            
            var companyApi = new CompaniesApi();
            var companies = companyApi.ApiCompaniesGet(lastmodifiedAfter: 0, take: 10, domain: null);
            Assert.AreNotEqual(0, companies.Count());
        }
        
        [TestMethod]
        public void Contacts()
        {
            
            var contactsApi = new ContactsApi();
            var contacts = contactsApi.ApiContactsListPost(new DragnetTechSharedIPAASModelsRequestContactParam()
            {
                Page = 1,
                Take = 25
            });
            
            Assert.AreNotEqual(0, contacts.Count());

        }
        
        [TestMethod]
        public void Emails()
        {
            
            var emailsApi = new EmailsApi();
            var emails = emailsApi.ApiEmailsDistinctGet(ingestedAfter: 0, take: null, page: null, emailaddress: null, id: null, domain: null);
            
            Assert.AreNotEqual(0, emails.Count());

        }
        
        [TestMethod]
        public void Meetings()
        {
            
            var api = new MeetingsApi();
            var results = api.ApiMeetingsDistinctGet(lastmodifiedAfter: 0, take: null, page: null, emailaddress: null, domain: null, icaluid: null, dateMax: null, dateMin: null);
            
            Assert.AreNotEqual(0, results.Count());
        }

        [TestMethod]
        public void Parse_EML()
        {
           
            var api = new ParseApi();
            using var stream = System.IO.File.Open("example.eml", FileMode.Open);
            var results = api.ApiParseEmailContactMIMEPost(stream);
            
            Assert.IsNotNull(results.Signature);
        }
        
        [TestMethod]
        public void Parse_JSON()
        {
            
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