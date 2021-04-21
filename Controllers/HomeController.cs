using HustlerNation.DBContext;
using HustlerNation.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HustlerNation.Controllers
{


   

    public class HomeController : Controller { 

 private readonly ApplicationDBContext _context;
    private readonly IWebHostEnvironment _webHostEnvironment;
    //private readonly string today = DateTime.Now.ToString("dd/MM/yyyy");
    //private static TimeZoneInfo E_Africa_standard_time = TimeZoneInfo.FindSystemTimeZoneById("E. Africa Standard Time");
    //private static DateTime today1 = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, E_Africa_standard_time);

    public HomeController(ApplicationDBContext context, IWebHostEnvironment webHostEnvironment)
    {
        _context = context;
        _webHostEnvironment = webHostEnvironment;
    }


        public IActionResult Index()
        {
            ViewBag.list_of_s = _context.Student_Reg.ToList();
            return View();
        } 
        
        
        public IActionResult delete(int id)
        {
            var itemToRemove = _context.Student_Reg.SingleOrDefault(x => x.Id == id); //returns a single item.

            if (itemToRemove != null)
            {
                _context.Student_Reg.Remove(itemToRemove);
                _context.SaveChanges();
            }
            TempData["response"] = " Deleted successfully";

            return Redirect("~/home/index");

        }
        public IActionResult submit( string f_name,string s_name,int age)
        {
            Students x = new Students
            {
                F_name = f_name,
                S_name = s_name,
                Age = age
            };
            _context.Student_Reg.Add(x);
            
            _context.SaveChanges();



            //_____________________________________________________________________________________________________________________________
            TempData["response"] =f_name+"  "+ s_name+ " inserted successfully";



            return Redirect("~/home/index");

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
