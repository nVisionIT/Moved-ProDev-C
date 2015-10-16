using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModels
{
    public class EmailModel
    {
        public String FromEmailAddress {get;set;}
        public String ToEmailAddress { get; set; }
        public String Subject { get; set; }
        public String Body { get; set; }
    }
}
