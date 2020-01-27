using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ew774515_MIS4800.Models
{
    public class customer
    {
        public int customerID { get; set; }

      //prop tab tab will get you this
        public string customerLastName { get; set; }
        public string customerFirstName { get; set; }
        public string email { get; set; }
        public string phone{ get; set; }

        public DateTime customerSince { get; set; }
    }
}