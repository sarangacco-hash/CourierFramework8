using CourierService.Contracts;

namespace CourierService.Strategies
{
    public class PercentageDiscount5 : IDiscountStrategy
    {
        public string Code => "OFR003";

        public decimal CalculateDiscount(decimal price, decimal distance, decimal weight)
        {
            if (price == 0) return 0;

            if (distance >= 50 && distance <= 250 && weight >= 10 && weight <= 150)
            {
                return price * 0.05m;
            }
            return 0;
        }
    }
}
