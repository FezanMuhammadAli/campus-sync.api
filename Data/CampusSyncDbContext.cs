using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusSync.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CampusSync.API.Data
{
    public class CampusSyncDbContext:DbContext
    {
        public CampusSyncDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {   
        }
        public DbSet<Admin> Admins { get; set; }
    }
}