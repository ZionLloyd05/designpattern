using DesignPatterns.FactoryMethodPattern.Enums;
using DesignPatterns.FactoryMethodPattern.Implementation;

namespace DesignPatterns.FactoryMethodPattern.FactoryMethod;

public class CountryDiscountFactory : DiscountFactory
{
    private readonly CountryIdentifier _countryIdentifier;

    public CountryDiscountFactory(CountryIdentifier countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }

    public override DiscountService CreateDiscountService()
    {
        return new CountryDiscountService(_countryIdentifier);
    }
}
