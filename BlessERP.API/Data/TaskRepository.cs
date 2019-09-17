using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlessERP.API.Dtos;
using BlessERP.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BlessERP.API.Data
{
    public class TaskRepository : ITaskRepository
    {
        private readonly BlessERPContext _context;
        public TaskRepository(BlessERPContext context)
        {
            _context = context;

        }
        public IEnumerable<TaskList> GetAll()
        {
            //return _context.Tasks.ToList();
            var data = (from e in _context.Tasks
                        join d in _context.Employees on e.AssignedTo equals d.Id
                        join f in _context.Employees on e.CreatedBy equals f.Id
                        select new TaskList
                        {
                            Title = e.Title,
                            Description = e.Description,
                            AssignedTo = d.FirstName + " " + d.LastName + " (" + d.EmployeeCode + ")",
                            CreatedBy = f.FirstName + " " + f.LastName + " (" + f.EmployeeCode + ")",
                        }).
                        ToList();
            return data;
        }
        public void SaveTasks(Tasks tasks)
        {
            _context.Tasks.Add(tasks);
            _context.SaveChanges();
        }

    }
}