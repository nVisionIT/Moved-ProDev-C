using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicInterfaces;
using BusinessLogic;

namespace BusinessLogicFactory
{
    public class BusinessLogicFactory
    {
        /// <summary>
        /// Get a concrete instance of a business logic class based on its interface.
        /// </summary>
        public static Object CreateBusinessObject<T>() 
        {
            if (typeof(T) == typeof(IEmailSender)) return new EmailSender();

            throw new Exception("Invalid Interface");
        }
    }
}
