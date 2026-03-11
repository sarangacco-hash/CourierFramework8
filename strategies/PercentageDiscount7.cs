using CourierService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Strategies
{
    public class PercentageDiscount7 : IDiscountStrategy
    {
        public string Code => "OFR002";

        public decimal CalculateDiscount(decimal price, decimal distance, decimal weight)
        {
            if (price == 0) return 0;

            if (distance >= 50 && distance <= 150 && weight >= 100 && weight <= 250)
            {
                return price * 0.07m;
            }
            return 0;
        }
    }
}
