using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopv2.Entities;

namespace CoffeeShopv2.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
