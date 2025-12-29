namespace Bridge;

/// <summary>
/// Abstraction
/// </summary>
public abstract class Menu
{
    public readonly ICoupon _coupon;
    public abstract int CalculatePrice();

    public Menu(ICoupon coupon)
        => _coupon = coupon;
}

/// <summary>
/// Refined Abstraction
/// </summary>
public class VegetarianMenu : Menu
{
    private const int _basePrice = 10;

    public VegetarianMenu(ICoupon coupon)
        : base(coupon)
    { }

    public override int CalculatePrice()
        => _basePrice - _coupon.CouponValue;
}

/// <summary>
/// Refined Abstraction
/// </summary>
public class MeatBasedMenu : Menu
{
    private const int _basePrice = 15;

    public MeatBasedMenu(ICoupon coupon)
        : base(coupon)
    { }

    public override int CalculatePrice()
        => _basePrice - _coupon.CouponValue;
}

/// <summary>
/// Implementor
/// </summary>
public interface ICoupon
{
    int CouponValue { get; }
}

/// <summary>
/// Concrete Implementor
/// </summary>
public class NoCoupon : ICoupon
{
    public int CouponValue => 0;
}

/// <summary>
/// Concrete Implementor
/// </summary>
public class OneEuroCoupon : ICoupon
{
    public int CouponValue => 1;
}

/// <summary>
/// Concrete Implementor
/// </summary>
public class TwoEuroCoupon : ICoupon
{
    public int CouponValue => 2;
}