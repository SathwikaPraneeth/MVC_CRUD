using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.Models;
using MVC_CRUD.Models;

namespace MVC_CRUD.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Display1()
        {
            Product product = new Product()
            {
                Pcode = 1,
                Name = "Mobile",
                Quantity_stock = 100,
                Details = "Smartphone",
                Price = 9999

            };
            ViewBag.Product = product;
            return View();
        }
        public IActionResult Display2()
        {
            List<Product> products = new List<Product>()
    {
        new Product() {Pcode=1, Name="Iqoo",Quantity_stock=99,Details="Smartphone",Price=9999 },
        new Product() {Pcode=1, Name="Vivo",Quantity_stock=99,Details="Smartphone",Price=10000 },
        new Product() {Pcode=1, Name="Mi",Quantity_stock=99,Details="Smartphone",Price=6666 },
        new Product() {Pcode=1, Name="Apple",Quantity_stock=99,Details="Smartphone",Price=99999},
        new Product() {Pcode=1, Name="Samsung",Quantity_stock=99,Details="Smartphone",Price=119999}

    };
            ViewBag.Products = products;
            return View();
        }
        public IActionResult Display3()
        {
            Product product = new Product()
            {
                Pcode = 1,
                Name = "Mobile",
                Quantity_stock = 100,
                Details = "Smartphone",
                Price = 9999

            };
            return View(product);
        }
        public IActionResult Display4()
        {
            List<Product> product = new List<Product>()
    {
        new Product() {Pcode=1, Name="Iqoo",Quantity_stock=99,Details="Smartphone",Price=9999 },
        new Product() {Pcode=1, Name="Vivo",Quantity_stock=99,Details="Smartphone",Price=10000 },
        new Product() {Pcode=1, Name="Mi",Quantity_stock=99,Details="Smartphone",Price=6666 },
        new Product() {Pcode=1, Name="Apple",Quantity_stock=99,Details="Smartphone",Price=99999},
        new Product() {Pcode=1, Name="Samsung",Quantity_stock=99,Details="Smartphone",Price=119999},

    };
            return View(product);
        }

    }
}
