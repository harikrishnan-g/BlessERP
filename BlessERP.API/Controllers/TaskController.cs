using System.Collections.Generic;
using BlessERP.API.Data;
using BlessERP.API.Dtos;
using BlessERP.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BlessERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _ITaskRepository;
        private readonly IConfiguration _config;
        public TaskController(ITaskRepository ITaskRepository, IConfiguration config)
        {
            _ITaskRepository = ITaskRepository;
            _config = config;
        }
        [HttpGet]
        public IEnumerable<TaskList> GetTasks()
        {
            return _ITaskRepository.GetAll();
        }
        [HttpPost("SaveTasks")]
        public void SaveTasks(Tasks tasks)
        {
            _ITaskRepository.SaveTasks(tasks);
        }
    }
}