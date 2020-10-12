using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace OptimizeDB1.Models
{  
   

    public class Emp
    {

       
        public int Id { get; set; }
        public int Salary { get; set; }
        public String Name { get; set; }
    }

    public class createEmp : Emp
    {
    }

    public class ReadEmp:Emp
    {
        public ReadEmp(DataRow row)
        {
            Id = Convert.ToInt32(row["Id"]);
            Salary = Convert.ToInt32(row["Salary"]);
            Name = row["Name"].ToString();
        }

        public int Id{ get; set; }
        public int Salary { get; set; }
        public String Name { get; set; }
    }
}