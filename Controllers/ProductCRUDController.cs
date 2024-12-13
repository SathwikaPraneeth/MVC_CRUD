using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.Models;
using System.Reflection.Metadata;
namespace MVC_CRUD.Controllers
{
    public class ProductCRUDController : Controller
    {
        static List<Product> products = null;
        public ProductCRUDController()
        {
            if (products == null)
            {

                products = new List<Product>()
                {
                 new Product() {Pcode=1, Name="Iqoo",Quantity_stock=99,Details="Smartphone",Price=9999 },
                 new Product() {Pcode=2, Name="Vivo",Quantity_stock=99,Details="Smartphone",Price=10000 },
                 new Product() {Pcode=3, Name="Mi",Quantity_stock=99,Details="Smartphone",Price=6666 },
                 new Product() {Pcode=4, Name="Apple",Quantity_stock=99,Details="Smartphone",Price=99999},
                 new Product() {Pcode=5, Name="Samsung",Quantity_stock=99,Details="Smartphone",Price=119999}
                };
            }
        }
        public IActionResult Index()
        {
            return View(products.ToList());
        }

        public ActionResult Details(int id)
        {
            var product = products.Where(x => x.Pcode == id).FirstOrDefault();
            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            products.Add(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = products.Where(x => x.Pcode == id).FirstOrDefault();
            return View(product);
        }


        public IActionResult Edit(int id, Product pro)
        {
            var product = products.Where(x => x.Pcode ==pro.Pcode).FirstOrDefault();
            
            if (product.Pcode == id)
            {
                product.Name = pro.Name;
                product.Price = pro.Price;
                product.Details = pro.Details;
                product.Quantity_stock = pro.Quantity_stock;
            }
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            
            var product = products.Where(x => x.Pcode == id).FirstOrDefault();
            if(product!= null)
            {
            return View(product);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Deleted(int id)
        {
            var product = products.Where(x => x.Pcode == id).FirstOrDefault();
            if (product != null)
            {
                products.Remove(product);
            }
            return RedirectToAction("Index");
        }










    }
}
