using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopv2.Abstract;
using CoffeeShopv2.Entities;

namespace CoffeeShopv2.Concrete
{
    public class CustomerCheckManager:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
