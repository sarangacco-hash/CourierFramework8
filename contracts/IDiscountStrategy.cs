namespace CourierService.Contracts
{
    public interface IDiscountStrategy
    {
        string Code { get; }
        decimal CalculateDiscount(decimal price, decimal distance, decimal weight);
    }
}
