using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GreendaleRegistrar.Models;

namespace GreendaleRegistrar.Data
{
  #nullable disable
  public class GreendaleRegistrarContext : DbContext
  {
    public GreendaleRegistrarContext(DbContextOptions<GreendaleRegistrarContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
  }
}
