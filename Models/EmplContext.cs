using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace WebApplication2.Models
{
    public class EmplContext : DbContext
    {
        public EmplContext(DbContextOptions <EmplContext> options) : base(options) { }

       public DbSet<Empl> Empls { get; set;}
    }
}
