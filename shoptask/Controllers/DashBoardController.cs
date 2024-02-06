using Microsoft.AspNetCore.Mvc;
using shoptask.Models;
using System.Reflection.Metadata.Ecma335;

namespace shoptask.Controllers
{
    public class DashBoardController : Controller
    {
        private static List<Product> _products = new List<Product>();
        private static List<Blog> _blog = new List<Blog>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            int id;
            if (_products.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = _products.Max(x => x.Id) + 1;
            }
            product.Id = id;
            _products.Add(product);
            return RedirectToAction("Index");
        }
        public IActionResult ViewProduct()
        {

            return View(_products);

        }
        public IActionResult Delete(int id)
        {
            Product product = _products.FirstOrDefault(x => x.Id == id);

            _products.Remove(product);

            return RedirectToAction("ViewProduct");
        }
        public IActionResult Edite(int id)
        {
            Product product = _products.FirstOrDefault(x => x.Id == id);

            return View(product);
        }
        [HttpPost]
        public IActionResult Edite(Product product)
        {
            Product temp = _products.SingleOrDefault(c => c.Id == product.Id);
            temp.Name = product.Name;
            temp.Description = product.Description;
            temp.Price = product.Price;
            temp.EnableSize = product.EnableSize;
            temp.Quantity = product.Quantity;
            temp.company.Id = product.company.Id;

            return RedirectToAction("ViewProduct");
        }
        public IActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            int id = 0;
            if (_blog.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = _blog.Max(x => x.Id) + 1;
            }
            blog.Id = id;
            _blog.Add(blog);
            return RedirectToAction("Index");
        }
        public IActionResult ViewBlog()
        {
            return View(_blog);
        }
        public IActionResult DeleteBlog(int id)
        {
            Blog blog = _blog.FirstOrDefault(x => x.Id == id);
            _blog.Remove(blog);
            return RedirectToAction("ViewBlog");

        }
        public IActionResult EditBlog(int id)
        {
            Blog blog = _blog.FirstOrDefault(y => y.Id == id);

            return View(blog);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            Blog pl=_blog.SingleOrDefault(c=>c.Id == blog.Id);
            pl.Name = blog.Name;
            pl.Price = blog.Price;
            pl.Description= blog.Description;
            pl.Quantity = blog.Quantity;
            pl.type.Id=blog.type.Id;

            return RedirectToAction("ViewBlog");
        }


    }
}
