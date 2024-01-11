using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Onlineshopping2024.Models;

namespace Onlineshopping2024.Data
{
    public class Onlineshopping2024Context : DbContext
    {
        public Onlineshopping2024Context (DbContextOptions<Onlineshopping2024Context> options)
            : base(options)
        {
        }

        public DbSet<Onlineshopping2024.Models.Category> Category { get; set; } = default!;
        public DbSet<Onlineshopping2024.Models.Product> Product { get; set; } = default!;
    }
}
