using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class MixedData
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int DepartmentID { get; set; }

       public int ShiftsID { get; set; }
        public int NumOfActions { get; set; }

        public Nullable<System.DateTime> StartWorkYear { get; set; }

        public string DepartmentName { get; set; }
        public string Manger { get; set; }

        public int EmployeeID { get; set; } 

        public System.DateTime Date { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

    }

}