﻿using CRUDapplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDapplication.Data
{
    public class ApplicationContext : DbContext

    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Emloyee>Employees { get; set; }
    }
}
