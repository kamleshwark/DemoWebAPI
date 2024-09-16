using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DemoWebAPI.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoWebAPI.Controllers
{
    [Route("[controller]")]
    public class StudentsController(IStudentsRepo _repo) : Controller
    {
        [HttpGet("all")]
        public ActionResult GetAll()
        {
            return Ok(_repo.GetAll());
        }
        
    }
}