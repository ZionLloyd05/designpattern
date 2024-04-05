using DesignPatterns.FactoryMethodPattern.Constants;

namespace DesignPatterns.FactoryMethodPattern.Implementation;

/// <summary>
/// ConcreteProduct
/// </summary>
public class CodeDiscountService : DiscountService
{
    private readonly Guid _code;

    public CodeDiscountService(Guid code)
    {
        _code = code;
    }

    public override int DiscountPercentage
    {
        // do some business logic
        // we're gonna be returning a static % for test purposes
        get => Discount.DEFAULT_CODE_DISCOUNT;
    }
}
