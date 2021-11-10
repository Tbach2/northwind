using Microsoft.AspNetCore.Mvc;
using Northwind.Models; 
using System.Linq;

namespace Northwind.Controllers 
{
    
    public class ProductController : Controller
    {
            private NorthwindContext _northwindContext;
            public ProductController(NorthwindContext db) => _northwindContext = db;

            public IActionResult Category() => View(_northwindContext.Categories.OrderBy(c => c.CategoryName));

            public IActionResult Index(int id) => View(id);

            public IActionResult Discount() => View(_northwindContext.Discounts);
    }
    
}