using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace productsTemplate.Models
{
    public class ProductsTable
    {
        [Key]
        public int id { get; set; }
        public string prodName { get; set; }
        public double prodPrice { get; set; }
        public string prodDesc { get; set; }
        public string prodImage { get; set; }
        [NotMapped]
        public IFormFile imageFile { get; set; }

    }
}
