namespace DesignPatterns.FactoryMethodPattern.FactoryMethod;

/// <summary>
/// Creator
/// </summary>
public abstract class DiscountFactory
{
    public abstract DiscountService CreateDiscountService();
}
