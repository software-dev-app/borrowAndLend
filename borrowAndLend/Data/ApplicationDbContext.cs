﻿using borrowAndLend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace borrowAndLend.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options)
        {

        }
        public DbSet<Item> Items { get; set; }

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<ExpenseCategory>ExpenseCategories { get; set; }
    }
}
