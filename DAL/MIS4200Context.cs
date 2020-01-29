using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ew774515_MIS4800.Models;

namespace ew774515_MIS4800.DAL
{
    public class MIS4200Context: DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<customer> Customers { get; set; }
        public DbSet<orders> Orders { get; set; }
    }
}