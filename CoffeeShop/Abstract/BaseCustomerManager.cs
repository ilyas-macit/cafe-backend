using CoffeeShop.Entities;

namespace CoffeeShop.Abstract;

public abstract class BaseCustomerManager : ICustomerService
{
    public virtual void Save(Customer customer)
    {
        Console.WriteLine("Saved to db " + customer.FirstName);
        
    }
}