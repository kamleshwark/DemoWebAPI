using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebAPI.Repo
{
    public interface IStudentsRepo
    {
        public List<CStudent> GetAll();
    }
}