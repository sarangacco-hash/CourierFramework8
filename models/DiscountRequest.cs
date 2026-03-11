using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Models
{
    public class DiscountRequest
    {
        public decimal Price { get; set; }
        public string Code { get; set; }
    }
}
