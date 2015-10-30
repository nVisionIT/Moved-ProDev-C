using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainModels;
using LogicInterfaces;


namespace Unit_Test_Project
{    
    [TestClass]
    public class Email
    {

        IEmailSender sender = (IEmailSender)BusinessLogicFactory.BusinessLogicFactory.CreateBusinessObject<IEmailSender>();

        [TestMethod]
        public void SendEmail_Positive()
        {
            Assert.IsTrue(sender.SendEmail(new EmailModel { FromEmailAddress = "test@test.com", ToEmailAddress = "test@test.com", Body = "Body", Subject = "Subject" }));
        }

        [TestMethod]
        public void SendEmail_FailOnEmptyEmailTo()
        {
            Assert.IsFalse(sender.SendEmail(new EmailModel { FromEmailAddress = "test@test.com", ToEmailAddress = null, Body = "Body", Subject = "Subject" }));
        }

        [TestMethod]
        public void SendEmail_FailOnInvalidEmailTo()
        {
            Assert.IsFalse(sender.SendEmail(new EmailModel { FromEmailAddress = "test@test.com", ToEmailAddress = "InvalidEmailAddress", Body = "Body", Subject = "Subject" }));
        }

        [TestMethod]
        public void SendEmail_FailOnEmptyEmailFrom()
        {
            Assert.IsFalse(sender.SendEmail(new EmailModel { FromEmailAddress = null, ToEmailAddress = "test@test.com", Body = "Body", Subject = "Subject" }));
        }

        [TestMethod]
        public void SendEmail_FailOnInvalidEmailFrom()
        {
            Assert.IsFalse(sender.SendEmail(new EmailModel { FromEmailAddress = "InvalidemailFrom", ToEmailAddress = "test@test.com", Body = "Body", Subject = "Subject" }));
        }
    }
}
