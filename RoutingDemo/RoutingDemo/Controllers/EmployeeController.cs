using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
         [Route("Emp/Index")]
        public ActionResult Index()
        {
            return Content("This is Index Action Method");
        }

        [Route("Emp/GetAll")]
        public ActionResult GetEmployees()
        {
            return Content("This is GetEmployees Action Method");
        }

        [Route("Emp/GetEmp/{id}")]
        public ActionResult GetEmpByCode(int id)
        {
            return Content($"This is Employee:{id}");
        }
    }
}