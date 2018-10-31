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
        [Route("employees/skills/{skill}/{capability:range(1-5)}")]
        // GET: Employees
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        public ActionResult BySkill(string skill, int capability)
        {
            return Content(skill + " : " + capability);
        }
    }
}