using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Models
{
    public class tblEmployee
    {
        public int c_empid {get;set;}

        public string c_empname {get;set;}

        public string c_empgender{get;set;}
        public DateTime c_empdob {get;set;}
        public string c_empshift {get;set;}

        public string c_empimg {get;set;}

        public string c_empdepartment{get;set;}

    }
}