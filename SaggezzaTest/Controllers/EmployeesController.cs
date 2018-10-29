using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaggezzaTest.Models;

namespace SaggezzaTest.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            var employee = new Employee() { Name = "RandomEmployee" };
            return View(employee);
        }
    }
}