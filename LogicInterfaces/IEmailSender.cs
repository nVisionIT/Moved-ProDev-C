using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModels;

namespace LogicInterfaces
{
    public interface IEmailSender 
    {
        bool SendEmail(EmailModel Model);
    }
}
