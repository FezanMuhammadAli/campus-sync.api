using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusSync.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace CampusSync.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly CampusSyncDbContext dbContext;

        public AdminController(CampusSyncDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAdmins()
        {
            return Ok(dbContext.Admins);
        }
    }
}