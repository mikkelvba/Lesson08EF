using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson08EF.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Customer()
        {

        }

        //constructor
        public Customer(String firstname, String lastname, String address, String city, String zip, String phone, String email)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Address = address;
            this.City = city;
            this.Zip = zip;
            this.Phone = phone;
            this.Email = email;
        }
    }
}