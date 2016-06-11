using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//we need to use the entity frame.
//if you get errors compiling your program, make sure that
//you have run "Install-Package EntityFramework" in the packet manager console.
using System.Data.Entity;
//we need our models here
using Lesson08EF.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Lesson08EF.DAL
{
    public class CustomerContext : DbContext
    {
        //The "PetHotelContext" is a connection string used for the database
        public CustomerContext() : base("CustomerContext")
        {
        }
        
        //This says we want to have a dataset of Custormers (will be a column)
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //This is insert so that our table names will be called
            //Pet and Customer instead of Pets and Customers
            //it's a matter of what you prefer as a developer.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}