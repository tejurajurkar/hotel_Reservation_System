using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Collections;

namespace WebApplication2.Models
{
    public class ProjectContext : DbContext

    {





        public ProjectContext() : base("UserEntities5") { }



        // public DbSet<Login> Login { get; set; }

            



        public DbSet<Register> Registrations { get; set; }

        public DbSet<admin> Admin { get; set; }

        public DbSet<Booking> bookings { get; set; }



        public DbSet<Room> Rooms { get; set; }



        // public System.Data.Entity.DbSet<hotelreser.Models.Login> Logins { get; set; }

    }

}
