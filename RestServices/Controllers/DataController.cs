using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModels;
using LogicInterfaces;

namespace RestServices.Controllers
{
    public class DataController : Controller
    {
        [HttpGet]
        public void SendEmail(EmailModel Model){
            ((IEmailSender)BusinessLogicFactory.BusinessLogicFactory.CreateBusinessObject<IEmailSender>()).SendEmail(Model);
        }

        [HttpGet]
        public  ActionResult TestServiceUp()
        {

            EmailModel model = new EmailModel { FromEmailAddress = "test@test.com", ToEmailAddress = "test@test.com", Body = "Body", Subject = "Subject" };

            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}
