

using System;
using Microsoft.EntityFrameworkCore;
using CdSite.Models;

namespace CdSite.Data{
    public class CdContext : DbContext { //Ärver av en klass som heter dbContext 
      // Konstruktor
        public CdContext(DbContextOptions<CdContext> options): base(options)
        {

        }

        // Knyter an till modeller
        public DbSet<Cd> Cd { get; set; }
        public DbSet<Lending> Lending {get; set;}
    }
}