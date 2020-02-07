using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ew774515_MIS4800.Models
{
    public class pets
    {
        public int petsID { get; set; }

        public string petsLastName { get; set; }
        public string petsFirstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public string petsType { get; set; }

        public string petsAge { get; set; }

        public DateTime patientSince { get; set; }

        public string fullName
        {
            get { return petsLastName + ", " + petsFirstName; }

        }
    }
}