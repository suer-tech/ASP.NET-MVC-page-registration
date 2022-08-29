using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class RegistrationDataContext : DbContext
    {

        public RegistrationDataContext(DbContextOptions<RegistrationDataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; } 
    }

}
