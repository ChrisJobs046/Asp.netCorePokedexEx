using System;
using System.Collections.Generic;
using System.Text;
using AspNetCoreExp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreExp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pokemon> Pokemones { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
    }
}
