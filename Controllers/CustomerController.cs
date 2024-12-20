using ecom.Models;
using Microsoft.AspNetCore.Mvc;

namespace ecom.Controllers
{
    public class CustomerController : Controller
    {
        private MyContext _myContext;

        public CustomerController(MyContext myContext)
        {
            _myContext = myContext;
        }

        public IActionResult Index()
        {
            List<Category> categories = _myContext.tbl_categories.ToList();
            ViewData["category"]= categories;
            return View();
        }
    }
}
