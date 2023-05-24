// See https://aka.ms/new-console-template for more information
using CoffeeShop.Abstract;
using CoffeeShop.Adapters;
using CoffeeShop.Concrete;
using CoffeeShop.Entities;

internal class Program
{
    public static void Main(string[] args)
    {
        BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
        customerManager.Save(new Customer()
        {
            DateOfBirth = new DateTime(2001,12,29),
            FirstName = "İlyas",
            LastName = "Macit",
            NationalityId = 12345678900
        });
    }
}

