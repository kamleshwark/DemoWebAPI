using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DemoWebAPI.DTOs;
using DemoWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebAPI.Repo
{
    public interface IStudentsRepo
    {
        public List<CStudent> GetAll();
        public CStudent? GetById(int id);
        public int AddNew(string name);
        public bool Update(CStudentUpdateDto data);
    }
}