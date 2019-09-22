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
    public class NursingController : ControllerBase
    {
        private readonly INursingRepository _INursingRepository;
        private readonly IConfiguration _config;
        public NursingController(INursingRepository INursingRepository, IConfiguration config)
        {
            _INursingRepository = INursingRepository;
            _config = config;
        }
        [HttpGet]
        public IEnumerable<NurseHandoverBook> GetNursingHandoverBook()
        {
            return _INursingRepository.GetAll();
        }
        [HttpPost("SaveNursingHandoverBook")]
        public void SaveTasks(NurseHandoverBook objNursingHandoverBook)
        {
            _INursingRepository.SaveNurseHandOverBook(objNursingHandoverBook);
        }
    }
}