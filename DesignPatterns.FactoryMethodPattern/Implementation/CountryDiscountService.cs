using DesignPatterns.FactoryMethodPattern.Constants;
using DesignPatterns.FactoryMethodPattern.Enums;

namespace DesignPatterns.FactoryMethodPattern.Implementation;

/// <summary>
/// ConcreteProduct
/// </summary>
public class CountryDiscountService : DiscountService
{
    private readonly CountryIdentifier _countryIdentifier;

    public CountryDiscountService(CountryIdentifier countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }

    public override int DiscountPercentage
    {
        get
        {
            switch (_countryIdentifier)
            {
                case CountryIdentifier.NG:
                    return Discount.NG_DISCOUNT;
                case CountryIdentifier.US:
                    return Discount.US_DISCOUNT;
                case CountryIdentifier.SA:
                    return Discount.SA_DISCOUNT;
                case CountryIdentifier.GH:
                    return Discount.GH_DISCOUNT;
                case CountryIdentifier.KY:
                    return Discount.KY_DISCOUNT;
                case CountryIdentifier.CA:
                    return Discount.CA_DISCOUNT;
                default:
                    return 0;
            }
        }
    }
}
