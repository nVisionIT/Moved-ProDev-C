using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicInterfaces;

namespace Mock
{
    public class MockBusinessLogicFactory
    {
        /// <summary>
        /// Get a concrete instance of a business logic class based on its interface.
        /// </summary>
        public static Object CreateDataAccessObject<T>(T BusinessLogicInterface)
        {
            if (typeof(T) == typeof(IEmailSender))
                return new MockLogic.EmailSender();

            throw new Exception("Invalid Interface");
        }
    }
}
