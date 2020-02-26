using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskWEB2.Models;

namespace TaskWEB2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Article> Articles {get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
