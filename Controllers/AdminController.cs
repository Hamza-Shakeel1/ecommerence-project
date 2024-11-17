using ecom.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecom.Controllers
{
    public class AdminController : Controller
    {
        private MyContext _context;

        public AdminController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            string admin_session = HttpContext.Session.GetString("admin_session");
            if (admin_session!=null)
            {
                return View();
            }
            else {
                return RedirectToAction("login");
            }
            
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string adminEmail, string adminPassword)
        {
            var row = _context.tbl_admin.FirstOrDefault(x=>x.admin_Email== adminEmail);
            if (row != null && row.admin_Password==adminPassword) 
            {
                HttpContext.Session.SetString("admin_session", row.admin_Id.ToString());
                return RedirectToAction("Index");
                
            }
            else
            {
                ViewBag.message = "incorrect name and password";
                return View();
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("admin_session");
            return View();
        }
    }
}
