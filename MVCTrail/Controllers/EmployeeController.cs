using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTrail.Models;

namespace MVCTrail.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int DepartmentId)
        {
            EmployeeContext objCOntext = new EmployeeContext();
            List<Employee> lstEmp = objCOntext.Employees.Where(emp=>emp.Department== DepartmentId).ToList<Employee>();
            return View(lstEmp);
        }

        public ActionResult Details(int Id)
        {
            EmployeeContext objEmpContext = new EmployeeContext();
            Employee objEmp = objEmpContext.Employees.Single(emp => emp.EmployeeId == Id);
            return View(objEmp);
        }
        
        public ActionResult Create()
        {            
            return View();
        }
    }
}