using System;
using System.Security.Cryptography.X509Certificates;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class BlogDbContext : DbContext
{
  public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
  {
    
  }

  public DbSet<Blog> Blogs { get; set; }
}
