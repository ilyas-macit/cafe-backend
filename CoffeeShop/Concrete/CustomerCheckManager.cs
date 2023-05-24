using CoffeeShop.Abstract;
using CoffeeShop.Entities;
using CoffeeShop.KPSPublic;

namespace CoffeeShop.Concrete;

public class CustomerCheckManager : ICustomerCheckService
{
    public bool CheckIfRealPerson(Customer customer)
    {
        
        return true;
    }
}