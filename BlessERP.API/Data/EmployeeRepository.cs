using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlessERP.API.Dtos;
using BlessERP.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BlessERP.API.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
         private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;

        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
        // public async Task<Employee> SaveEmployee(Employee employee)
        // {
            
        //     await _context.Employees.AddAsync(employee);
        //     await _context.SaveChangesAsync();

        //     return employee;
        // }
      public  void SaveEmployee(Employee employee)
        {
            
             _context.Employees.Add(employee);
             _context.SaveChanges();

           
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

    }
}