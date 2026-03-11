using CourierService.Contracts;
using CourierService.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Services
{
    public class BasePriceCalculationService
    {        

        public BasePriceCalculationService()
        {            
        }

        public decimal Calculate(decimal baseDeliveryCost, decimal distance, decimal weight)
        {
            if (baseDeliveryCost <= 0)
                return 0;

            if (distance > 0 && weight > 0)
                return baseDeliveryCost + (distance * PriceConstants.FixedCostPerKilometer) + (weight * PriceConstants.FixedCostPerKilogram);
            else if (distance > 0 && weight <=0)
                return baseDeliveryCost + (distance * PriceConstants.FixedCostPerKilometer);
            else if (distance <= 0 && weight > 0)
                return baseDeliveryCost + (weight * PriceConstants.FixedCostPerKilogram);
            else
                return 0;
        }
    }
}
