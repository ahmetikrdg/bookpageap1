using bookpage.webui.Data;
using bookpage.webui.Models;
using bookpage.webui.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace bookpage.webui.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int? id)
        {
            var products=ProductRepository.Products;
            if(id!=null)
            {
                products=products.Where(p=>p.CategoryId==id).ToList();
            }

           
            var productsViewModel = new ProductViewModel
            {
                Products = products
            };

            return View(productsViewModel);
        }

        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
            //id parametresini gönderdim ve viewüzerine bir pdourct nesnesi gönderiyor
        }

        public IActionResult Read(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }
    }
}