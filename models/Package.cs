namespace CourierService.Models
{
    public class Package
    {
        public string PackageId { get; set; }
        public decimal Weight { get; set; }
        public decimal Distance { get; set; }
        public string OfferCode { get; set; }
        public decimal FinalPrice { get; set; }
        public decimal DiscountAmount { get; set; }
    }
}
