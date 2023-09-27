using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingCart3.Models;

namespace ShoppingCart3.Data
{
    public class ShoppingCart3Context : IdentityDbContext
    {
        public ShoppingCart3Context (DbContextOptions<ShoppingCart3Context> options)
            : base(options)
        {
        }

        public DbSet<ShoppingCart3.Models.User> User { get; set; } = default!;
    }
}
