﻿using BulkyBookWeb1.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
