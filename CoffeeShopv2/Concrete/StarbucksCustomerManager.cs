using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopv2.Abstract;
using CoffeeShopv2.Entities;

namespace CoffeeShopv2.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson((customer)) == true)
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

    }
}
