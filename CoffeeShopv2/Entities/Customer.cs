using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopv2.Abstract;

namespace CoffeeShopv2.Entities
{
    public class Customer:IEntitiy
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
