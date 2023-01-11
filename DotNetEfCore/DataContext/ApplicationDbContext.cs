using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Policy;

namespace DotnetEfCore.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        // injection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<TokoKomputerEntity> TokoKomputerEntities => Set<TokoKomputerEntity>();
        public DbSet<TokoGameEntity> TokoGameEntities => Set<TokoGameEntity>();
        public DbSet<DataTamuEntity> DataTamuEntities => Set<DataTamuEntity>();
        public DbSet<SendEmailEntity> SendEmailEntities => Set<SendEmailEntity>();
        public DbSet<DataPerusahaanEntity> DataPerusahaanEntities => Set<DataPerusahaanEntity>();
        public DbSet<CategoryEntity> CategoryEntities => Set<CategoryEntity>();
        

    }
}