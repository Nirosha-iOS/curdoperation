﻿using CURDOperation.Model;
using Microsoft.EntityFrameworkCore;

namespace CURDOperation.Db
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }    
    }
}
