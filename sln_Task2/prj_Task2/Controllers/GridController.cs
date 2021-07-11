using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prj_Task2.Models;

namespace prj_Task2.Controllers
{
    public class GridController : Controller
    {
        // GET: Grid
        public ActionResult Grid()
        {
            
            return View();
        }
        [HttpGet]
        public ActionResult GridData()
        {
            var gridData1 = new Employee() { FullName = "Kevin Diaz", EmployeeID = "172588059-3", SIN = 135711458, PhoneNumber = 2222591008, City = "Mississauga", Salary = Convert.ToDecimal("1233.90221"), Country = "Canada" };
            var gridData2 = new Employee() { FullName = "Rai Diaz", EmployeeID = "172577889-3", SIN = 135711458, PhoneNumber = 2222595007, City = "Quito", Salary = Convert.ToDecimal("1559.9011"), Country = "Ecuador" };
            var gridData3 = new Employee() { FullName = "Rodrigo Chan", EmployeeID = "178948059-3", SIN = 135711458, PhoneNumber = 2222587225, City = "Mississauga", Salary = Convert.ToDecimal("14563.905221"), Country = "Canada" };
            var gridData4 = new Employee() { FullName = "Rai Diaz", EmployeeID = "125897789-3", SIN = 135711458, PhoneNumber = 2222587449, City = "Bogota", Salary = Convert.ToDecimal("159.9011"), Country = "Colombia" };
            return Json(new List<Employee>() { gridData1, gridData2, gridData3, gridData4 }, JsonRequestBehavior.AllowGet);
        }
    }
}
