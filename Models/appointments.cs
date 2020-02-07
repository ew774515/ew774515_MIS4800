using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ew774515_MIS4800.Models
{
    public class appointments
    {
        public int appointmentsID { get; set; }
        public decimal appointmentsPrice { get; set; }
        public string appointmentsDescription { get; set; }



        // the next two properties link the appointments to pets
        public int petsID { get; set; }
        public virtual pets Pets { get; set; }

        // the next two properties link the appointments to vet
        public int vetsID { get; set; }

        public virtual vets Vets { get; set; }
    }
}