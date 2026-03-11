using CourierService.Contracts;

namespace CourierService.Services
{
    public class DiscountService
    {
        private readonly IEnumerable<IDiscountStrategy> _discounts;

        public DiscountService(IEnumerable<IDiscountStrategy> discounts)
        {
            _discounts = discounts;
        }

        public decimal ApplyDiscount(string code, decimal price,decimal distance, decimal weight)
        {
            var discount = _discounts.FirstOrDefault(d => d.Code == code);

            if (discount == null)
                return 0;

            return discount.CalculateDiscount(price,distance,weight);
        }
    }
}
