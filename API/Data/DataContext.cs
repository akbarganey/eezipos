using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
        public DbSet<CSDSupplier> CSDSuppliers { get; set; }
        public DbSet<StockItem> StockItems { get; set; }
    }
}