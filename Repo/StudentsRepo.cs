using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWebAPI.DTOs;
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

        public int AddNew(string name)
        {
            int id = _students.Max(s => s.Id) + 1;
            var student = new CStudent{Id=id, Name=name};
            _students.Add(student);
            return id;
        }

        public List<CStudent> GetAll()
        {
            return _students;
        }

        public CStudent? GetById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public bool Update([FromBody]CStudentUpdateDto data)
        {
            var student = _students.FirstOrDefault(s => s.Id == data.Id);
            if(student != null)
            {
                student.Name = data.Name;
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}