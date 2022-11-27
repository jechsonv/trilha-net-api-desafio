using tech_test_payment_api.Contexts;
using tech_test_payment_api.Models;
using tech_test_payment_api.Validations;
using tech_test_payment_api.Enums;

namespace tech_test_payment_api.Models
{
    public class OrderSale
    {
        public int Id { get; set; }
        public StatusTransitions Status { get; set; }
        public decimal Amount { get; set; }
        public DateTime CurrentDate { get; set; }
        public List<Product> Products { get; set; }

        public int SellerId { get; set; }
        public Seller Seller { get; set; }
    }
}