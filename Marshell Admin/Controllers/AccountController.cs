using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marshell_Admin.Models;

namespace Marshell_Admin.Controllers
{
    public class AccountController : Controller
    {  private readonly ApplicationDbContext _context; // Assuming ApplicationDbContext is your DB context

        // Injecting the DB context into the constructor
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
         
        // GET: Login Page
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Handle Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Authenticate user here
            if (username == "admin" && password == "password")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid credentials.";
                return View();
            }
        }

        #region Users
        // GET: Users
        public IActionResult Users()
        {
            return View();
        }

        // GET: Fetch users as JSON
        [HttpGet]
        public async Task<JsonResult> GetUsers()
        {
            List<Users> users = await _context.Users.Where(u => !u.IsDeleted).ToListAsync();

            return Json(new { data = users });
        }

        // POST: Add user
        [HttpPost]
        public async Task<JsonResult> AddUser(Users user)
        {
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        // POST: Update user
        [HttpPost]
        public async Task<JsonResult> UpdateUser(Users user)
        {
            try
            {
                var existingUser = await _context.Users.FindAsync(user.ID);
                if (existingUser == null)
                {
                    return Json(new { success = false, message = "User not found" });
                }

                existingUser.UNAME = user.UNAME;
                existingUser.SRNAME = user.SRNAME;
                existingUser.IDNUMBER = user.IDNUMBER;
                existingUser.MOBILE = user.MOBILE;
                existingUser.LOCATION = user.LOCATION;
                existingUser.ROLE = user.ROLE;
                existingUser.FIRED = user.FIRED;

                await _context.SaveChangesAsync();
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
        #endregion
    }
}
