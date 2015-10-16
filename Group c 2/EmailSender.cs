using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicInterfaces;

namespace BusinessLogic
{
    public class EmailSender : IEmailSender
    {
        #region IEmailSender Members

        public bool SendEmail(DomainModels.EmailModel Model)
        {
            if (Model.ToEmailAddress == null)
                return false;
            if (Model.FromEmailAddress == null)
                return false;
            if (!Model.ToEmailAddress.Contains("@"))
                return false;
            if (!Model.FromEmailAddress.Contains("@"))
                return false;
            
            //Send email
            return true;
        }

        #endregion
    }
}
