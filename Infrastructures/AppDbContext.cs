﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet <Fruit> Fruits { get; set; }
    public DbSet <Category> Categories { get; set; }
    public DbSet<User> Users { get; set; }
}
