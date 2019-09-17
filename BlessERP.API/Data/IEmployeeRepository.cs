using System.Collections.Generic;
using System.Threading.Tasks;
using BlessERP.API.Dtos;
using BlessERP.API.Models;

namespace BlessERP.API.Data
{
    public interface IEmployeeRepository
    {
        // Task<Employee> SaveEmployee(Employee employee);
        IEnumerable<Employee> GetAll();
        void SaveEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
    }
}