using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ew774515_MIS4800.Models
{
    public class vets
    {
        public int vetsID { get; set; }
        public string vetsLastName { get; set; }
        public string vetsFirstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public DateTime vetSince { get; set; }

        public string fullName
        {
            get { return vetsLastName + ", " + vetsFirstName; }

        }
    }
}