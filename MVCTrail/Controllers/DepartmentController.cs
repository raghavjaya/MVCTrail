using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTrail.Models;

namespace MVCTrail.Controllers
{
    public class DepartmentController : Controller
    {
        EmployeeContext objContext = new EmployeeContext();
        // GET: Department
        public ActionResult Index()
        {            
            List<Department> lstDept= objContext.Departments.ToList<Department>();
            return View(lstDept);
        }

    }
}