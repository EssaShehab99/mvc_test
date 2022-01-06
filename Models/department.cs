using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int CityNo { get; set; }
        public List<Employee> employees { get; set; }
    }
}
