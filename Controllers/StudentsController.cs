using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DemoWebAPI.DTOs;
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
        
        [HttpGet("getById/{id}")]
        public ActionResult GetById(int id)
        {
            return Ok(_repo.GetById(id));
        }

        [HttpPost("new/{name}")]
        public ActionResult AddStudent(string name)
        {
            return Ok(_repo.AddNew(name));
        }

        [HttpPut("update")]
        public ActionResult Update([FromBody]CStudentUpdateDto data)
        {
            return Ok(_repo.Update(data));
        }
        
    }
}