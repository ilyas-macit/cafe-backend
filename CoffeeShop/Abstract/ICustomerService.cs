using CoffeeShop.Entities;

namespace CoffeeShop.Abstract;

public interface ICustomerService
{
    public void Save(Customer customer);
}