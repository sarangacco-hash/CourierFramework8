using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Contracts
{
    public interface IDiscountStrategy
    {
        string Code { get; }
        decimal CalculateDiscount(decimal price, decimal distance, decimal weight);
    }
}
