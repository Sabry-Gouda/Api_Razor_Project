using classes.shared;
using Microsoft.EntityFrameworkCore;

namespace ApiSolution.Models
{
    public class Data:DbContext
    {
        public Data()
        {

        }
        public Data(DbContextOptions option ):base(option)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
