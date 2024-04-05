using DesignPatterns.FactoryMethodPattern.Constants;
using DesignPatterns.FactoryMethodPattern.Enums;
using DesignPatterns.FactoryMethodPattern.FactoryMethod;

namespace DesignPatterns.Tests;

public class CreationalPatternTest
{
    [Fact]
    public void Signleton_Should_Return_Sam_Instance_when_Created()
    {
        var firstInstance = SingletonPattern.Singleton.Create();
        var secondInstance = SingletonPattern.Singleton.Create();

        Assert.Same(firstInstance, secondInstance);
    }

    [Theory]
    [InlineData(CountryIdentifier.NG, Discount.NG_DISCOUNT)]
    [InlineData(CountryIdentifier.US, Discount.US_DISCOUNT)]
    [InlineData(CountryIdentifier.SA, Discount.SA_DISCOUNT)]
    [InlineData(CountryIdentifier.CA, Discount.CA_DISCOUNT)]
    [InlineData(CountryIdentifier.KY, Discount.KY_DISCOUNT)]
    public void Factory_Method_Should_Return_Correct_Country_Discount(
        CountryIdentifier countryIdentifier, 
        int expectedDiscount)
    {
        var countryFactory = new CountryDiscountFactory(countryIdentifier);

        var discountService = countryFactory.CreateDiscountService();

        var discount = discountService.DiscountPercentage;

        Assert.Equal(expectedDiscount, discount);
    }

    [Fact]
    public void Factory_Method_Should_Return_Correct_Code_Discount()
    {
        var countryFactory = new CodeDiscountFactory(Guid.NewGuid());

        var discountService = countryFactory.CreateDiscountService();

        var discount = discountService.DiscountPercentage;

        Assert.Equal(Discount.DEFAULT_CODE_DISCOUNT, discount);
    }
}