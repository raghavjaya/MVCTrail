using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCTrail.Models
{
    [Table("tbl_Department")]
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public List<Employee> EMployeesList;
    }
}