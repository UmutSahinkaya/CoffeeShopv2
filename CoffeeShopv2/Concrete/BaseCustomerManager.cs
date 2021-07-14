using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopv2.Abstract;
using CoffeeShopv2.Entities;

namespace CoffeeShopv2.Concrete
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved To Db : "+customer.FirstName);
        }
    }
}
