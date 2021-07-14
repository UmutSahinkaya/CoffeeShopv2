using System;
using CoffeeShopv2.Abstract;
using CoffeeShopv2.Entities;
using MernisServiceReference;

namespace CoffeeShopv2.Adapters
{
    public class MernisServiceAdapter:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client= new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);

        }
    }
}
