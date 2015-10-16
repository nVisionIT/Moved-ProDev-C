using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicInterfaces;

namespace MockLogic
{
    public class EmailSender : IEmailSender
    {
        #region IEmailSender Members

        public bool SendEmail(DomainModels.EmailModel Model)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
