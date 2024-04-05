using DesignPatterns.FactoryMethodPattern.Implementation;

namespace DesignPatterns.FactoryMethodPattern.FactoryMethod;

/// <summary>
/// ConcreteFactory
/// </summary>
public class CodeDiscountFactory : DiscountFactory
{
    private readonly Guid _code;

    public CodeDiscountFactory(Guid code)
    {
        _code = code;
    }

    public override DiscountService CreateDiscountService()
    {
        return new CodeDiscountService(_code);
    }
}
