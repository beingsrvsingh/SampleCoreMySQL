using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleCoreMySQL.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleCoreMySQL
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            CoreDbContext coreDbContext = new CoreDbContext();
            List<Persons> person = coreDbContext.Persons.ToList();
            return View();
        }
    }
}
