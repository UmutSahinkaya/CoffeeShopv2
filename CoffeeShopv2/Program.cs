using System;
using CoffeeShopv2.Adapters;
using CoffeeShopv2.Concrete;
using CoffeeShopv2.Entities;

namespace CoffeeShopv2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer{DateOfBirth = new DateTime(1994,4,20),FirstName = "UMUT",LastName = "ŞAHİNKAYA",NationalityId = "28294579422"});
            Console.ReadLine();
        }
    }
}
