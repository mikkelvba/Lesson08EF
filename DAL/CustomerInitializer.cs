using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lesson08EF.Models;
using System.Diagnostics;

namespace Lesson08EF.DAL
{
    public class CustomerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CustomerContext>
        //DropCreateDatabaseIfModelChanges<CustomerContext>
    //other options are
    //CreateDataBaseIfNotExists
    //DropCreateDataBaseIfModelChange
    {
        protected override void Seed(CustomerContext context)
        {
            List<Customer> customers = new List<Customer>();
            Customer c1 = new Customer("martin", "andersen", "Trepkasgade 33", "Viborg", "8800", "24905332", "mikkel@gmail.com");
            Customer c2 = new Customer("john", "nielsen", "hasngade 33", "Aars", "8932", "70121416", "hans@gmail.com");
            customers.Add(c1);
            customers.Add(c2);
            Debug.WriteLine("Seed metode kaldt ");
            //here we add all of our customers to the dataset in the context
            customers.ForEach(customer => context.Customers.Add(customer));
            //saving changes
            context.SaveChanges();

        }
    } //end of class
} // end ofnamespace