using ecom.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecom.Controllers
{
    public class AdminController : Controller
    {
        private MyContext _context;

        private IWebHostEnvironment _environment;

        public AdminController(MyContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
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
                ViewBag.name = row.admin_Name;
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
            return RedirectToAction("login");
        }
       
        public IActionResult Profile()
        {
            var adminID = HttpContext.Session.GetString("admin_session");
            var row= _context.tbl_admin.Where(a=>a.admin_Id== int.Parse(adminID)).ToList();
            return View(row);
        }
        [HttpPost]
        public IActionResult Profile(Admin admin)
        {
            _context.tbl_admin.Update(admin);
            _context.SaveChanges();
            return RedirectToAction("Profile");
        }
        [HttpPost]
        public IActionResult ChangeProfileImage(IFormFile admin_image, Admin admin)
        {
            string ImagePath = Path.Combine(_environment.WebRootPath,"admin_image", admin_image.FileName);
            FileStream fs=new FileStream(ImagePath, FileMode.Create);
            admin_image.CopyTo(fs);
            admin.admin_Image = admin_image.FileName;
			_context.tbl_admin.Update(admin);
			_context.SaveChanges();
			return RedirectToAction("Profile");

		}
        public IActionResult FetchCustomer()
        {
            var cust_detail = _context.tbl_customer.ToList();
            return View(cust_detail);
        }
        public IActionResult CustomerDetail( int id)
        {
            var Detail_Page = _context.tbl_customer.FirstOrDefault( a=> a.Customer_Id== id);
            return View( Detail_Page);
        }
        public IActionResult UpdateCustomer(int id) 
        {
            return View(_context.tbl_customer.Find(id));
        }
        
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer , IFormFile Customer_Image) 
        {
            var PATH = Path.Combine(_environment.WebRootPath, "Customer_Image", Customer_Image.FileName);
            FileStream fs= new FileStream(PATH, FileMode.Create);
            Customer_Image.CopyTo(fs);
            customer.Customer_Image=Customer_Image.FileName;
            _context.tbl_customer.Update(customer);
            _context.SaveChanges();
            return RedirectToAction("FetchCustomer");

        }
        public IActionResult DeleteConfirm(int id)
        {
			var Detail_Page = _context.tbl_customer.FirstOrDefault(a => a.Customer_Id == id);
			return View(Detail_Page);
		}
        public IActionResult DeleteCustomer(int id)
        {
            var customer_id = _context.tbl_customer.Find(id);
            _context.tbl_customer.Remove(customer_id);
            return RedirectToAction("FetchCustomer");
        }
	}
}
