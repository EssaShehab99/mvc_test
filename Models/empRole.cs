using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class EmpRole
    {
        public int ID { get; set; }
        public int EMPID { get; set; }
        public int ROLEID { get; set; }
        public Role ROLE { get; set; }
        public Employee EMPLOYEE { get; set; }

    }
}
