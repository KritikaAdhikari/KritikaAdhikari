using Microsoft.EntityFrameworkCore;

namespace BudgetWise.Models
{
    public class BudgetWiseDbContext : DbContext
    {
        public required DbSet<Cost> Costs { get; set; }
        public BudgetWiseDbContext(DbContextOptions<BudgetWiseDbContext> options) 
          :base(options) 
        { 
        }    
    }
}
