using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusSync.API.Models
{
    public class Admin
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
    }
}