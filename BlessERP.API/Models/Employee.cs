using System;  
using System.Collections.Generic;  

namespace BlessERP.API.Models
{
   public partial class Employee  
    {  
        public int Id { get; set; }
        public string EmployeeCode { get; set; }  
        public string FirstName { get; set; }  
        public string LastName { get; set; }  
     
        public string Department { get; set; }  
    }  
}