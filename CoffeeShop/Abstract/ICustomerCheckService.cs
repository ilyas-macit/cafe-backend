using CoffeeShop.Entities;

namespace CoffeeShop.Abstract;

public interface ICustomerCheckService
{
    public bool CheckIfRealPerson(Customer customer);
}