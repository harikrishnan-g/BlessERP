using System;
using System.Collections.Generic;

namespace BlessERP.API.Models
{
    public partial class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? AssignedTo { get; set; }
        public int? CreatedBy { get; set; }

        public virtual Employees EmployeeAssigned { get; set; }
        public virtual Employees EmployeeCreated { get; set; }
    }
}
