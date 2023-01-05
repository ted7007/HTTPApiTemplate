﻿using HTTPApiTemplate.Models;
using Microsoft.EntityFrameworkCore;
namespace HTTPApiTemplate.Repository;

public class ApplicationContext : DbContext
{
    public DbSet<Models.Product> Products { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}