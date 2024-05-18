using Microsoft.AspNetCore.Mvc;
using productsTemplate.DataContext;
using productsTemplate.Models;

namespace productsTemplate.Controllers
{
    public class ProductsController : Controller
    {

        private DatabaseContext con { get; set; }
        private string imagePath { get; set; }

        public ProductsController(DatabaseContext context, IWebHostEnvironment environment)
        {
            con = context;
           imagePath = Path.Combine(environment.WebRootPath, "images");

           // localhost:3433//productsTemplate/wwwroot/images/
           // localhost:3433//productsTemplate/wwwroot/images/dg.png
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProductsTable products)
        {

            var filename = products.imageFile.FileName;
            var fullImagePath = Path.Combine(imagePath, filename);

            using (var stream = new FileStream(fullImagePath,FileMode.Create))
            {
                products.imageFile.CopyTo(stream);
            }


            products.prodImage = filename;
            con.ProductsTable.Add(products);
            con.SaveChanges();
            return View();
        }



        public IActionResult Index()
        {
            ViewBag.products = con.ProductsTable.ToList();
            return View();
        }

    
        public IActionResult Update(int id)
        {
            ViewBag.product = con.ProductsTable.Find(id);
            return View();
        }
        [HttpPost]
        public IActionResult Update(ProductsTable product)
        {


    5

            var filename = product.imageFile.FileName;
            var fullImagePath = Path.Combine(imagePath, filename);

            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                product.imageFile.CopyTo(stream);
            }
            product.prodImage = filename;
            con.ProductsTable.Update(product);
            con.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var prod = con.ProductsTable.Find(id);
            con.ProductsTable.Remove(prod);
            con.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
