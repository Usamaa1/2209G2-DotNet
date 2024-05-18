using System.ComponentModel.DataAnnotations;

namespace productsTemplate.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
    }
}
