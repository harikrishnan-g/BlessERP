using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Net;  
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using BlessERP.API.Data;
using BlessERP.API.Dtos;
using BlessERP.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlessERP.API.Controllers
{  
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    { 
        private readonly IEmployeeRepository _repo;
        private readonly IConfiguration _config;
        public EmployeeController(IEmployeeRepository repo, IConfiguration config)
        {
            _config = config;
            _repo = repo;

        }
        [HttpGet]
        public IEnumerable<Employee> GetEmployees()  
        {  
            return _repo.GetAll();
        }  
       
        // [AllowAnonymous]
        // [HttpGet("{id}")]
        // public  async Task<IActionResult> GetEmployeeById(int id)  
        // {  
            
        //     var employee = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
        //     return Ok(employee);

        //         // var entity = _context.Employees.FirstOrDefault(e => e.EmployeeCode == id);  
        //         // if (entity == null)  
        //         // {  
        //         //     //return BadRequest("Employee not found");
        //         //     return Request.CreateResponse(HttpStatusCode.NotFound, "Employee with id=" + id.ToString() + " not found");  
        //         // }  
        //         // else  
        //         // {  
                    
        //         //      return Request.CreateResponse(HttpStatusCode.OK,entity);  
        //         // }  
              
        // }  

        [HttpPost("SaveEmployee")]
        // public async Task<IActionResult> SaveEmployee(Employee employee)
        // {  
        //     var createdUser = await _repo.SaveEmployee(employee);
        //     return StatusCode(201);
        // }  
     public void SaveEmployee(Employee employee)
        {  
             _repo.SaveEmployee(employee);
            // return StatusCode(201);
        }  

        // public HttpResponseMessage Delete(int id)  
        // {  
        //     using (EmployeeEntities db = new EmployeeEntities())  
        //     {  
        //         var entity = db.Employees.FirstOrDefault(e => e.Employee_Id == id);  
        //         if (entity == null)  
        //         {  
        //             return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with id=" + id.ToString() + "not found to delete");  
        //         }  
        //         else  
        //         {  
        //             db.Employees.Remove(entity);  
        //             db.SaveChanges();  
        //             return Request.CreateResponse(HttpStatusCode.OK);  
        //         }  
        //     }  
        // }  
        // public HttpResponseMessage Put(int id, [FromBody]Employee employee)  
        // {  
        //     using (EmployeeEntities db = new EmployeeEntities())  
        //     {  
        //         try  
        //         {  
        //             var entity = db.Employees.FirstOrDefault(e => e.Employee_Id == id);  
        //             if (entity == null)  
        //             {  
        //                 return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with id=" + id.ToString() + "not found to update");  
        //             }  
        //             else  
        //             {  
        //                 entity.First_Name = employee.First_Name;  
        //                 entity.Last_Name = employee.Last_Name;  
        //                 entity.Salary = employee.Salary;  
        //                 entity.Joing_Date = employee.Joing_Date;  
        //                 entity.Department = employee.Department;  
        //                 db.SaveChanges();  
        //                 return Request.CreateResponse(HttpStatusCode.OK, entity);  
        //             }  
        //         }  
        //         catch (Exception ex)  
        //         {  
        //             return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);  
        //         }  
        //     }  
        // }  
    }  
}  