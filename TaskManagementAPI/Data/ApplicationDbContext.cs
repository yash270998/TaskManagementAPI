using System;
using Microsoft.EntityFrameworkCore;
using TMS_API.Models;

namespace TMS_API.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Task> Tasks { get; set; }

    public DbSet<Subtask> Subtasks { get; set; }
  }
}
