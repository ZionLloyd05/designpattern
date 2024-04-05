namespace DesignPatterns.FactoryMethodPattern;

/// <summary>
/// Product
/// We can use an interface for this
/// </summary>
public abstract class DiscountService
{
    public abstract int DiscountPercentage { get; }
    public override string ToString() => GetType().Name;
}