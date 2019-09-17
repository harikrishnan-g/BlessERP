using System;
using System.Collections.Generic;

namespace BlessERP.API.Models
{
    public partial class Employees
    {
        public Employees()
        {
            TasksAssignedToNavigation = new HashSet<Tasks>();
            TasksCreatedByNavigation = new HashSet<Tasks>();
        }

        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public virtual ICollection<Tasks> TasksAssignedToNavigation { get; set; }
        public virtual ICollection<Tasks> TasksCreatedByNavigation { get; set; }
    }
}
