using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int CityNo { get; set; }
        public int DeptNo { get; set; }
        public int HireDate { get; set; }
        public int JobId { get; set; }
        public int Salary { get; set; }
        public int IsActive { get; set; }

        public City City { get; set; }
        public Department Department { get; set; }
        public Job Job { get; set; }
        public List<EmpRole> EMPROLE { get; set; }

    }
}
