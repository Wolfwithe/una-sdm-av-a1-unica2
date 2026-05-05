using ValeAtivos324123267.Models;
using Microsoft.EntityFrameworkCore;
namespace ValeAtivos324123267.Data
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) {}
       public DbSet<Equipamento> Equipamentos {get; set;}
       
    } 
}
