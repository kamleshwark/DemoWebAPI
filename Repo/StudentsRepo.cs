using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebAPI.Repo
{
    public class CStudentsRepo : IStudentsRepo
    {
        List<CStudent> _students =
        [
            new() { Id = 1, Name = "Sayali" },
            new() { Id = 8, Name = "Vandana" },
            new() { Id = 12, Name = "Kamleshwar" }
        ];

        public List<CStudent> GetAll()
        {
            return _students;
        }
    }
}