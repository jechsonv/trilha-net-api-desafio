using tech_test_payment_api.Contexts;
using tech_test_payment_api.Models;
using tech_test_payment_api.Validations;
using tech_test_payment_api.Enums;

namespace tech_test_payment_api.Models
{
    public class Seller
    {
         public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Telephone { get; set; }
    }
}