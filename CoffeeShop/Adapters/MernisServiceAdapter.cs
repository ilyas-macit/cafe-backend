using CoffeeShop.Abstract;
using CoffeeShop.Entities;
using CoffeeShop.KPSPublic;

namespace CoffeeShop.Adapters;

public class MernisServiceAdapter : ICustomerCheckService
{
    public bool CheckIfRealPerson(Customer customer)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        var result = client.TCKimlikNoDogrulaAsync(
            customer.NationalityId,
            customer.FirstName,
            customer.LastName,
            customer.DateOfBirth.Year
        );
        return result.Result.Body.TCKimlikNoDogrulaResult;
    }
}