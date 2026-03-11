using CourierService.Contracts;

namespace CourierService.Strategies
{
    public class PercentageDiscount10 : IDiscountStrategy
    {
        public string Code => "OFR001";

        public decimal CalculateDiscount(decimal price, decimal distance, decimal weight)
        {
            if(price == 0) return 0;

            if(distance > 0 && distance < 200 && weight>=70 && weight <= 200)
            {
                return price * 0.1m;
            }
            return 0;
        }
    }
}
