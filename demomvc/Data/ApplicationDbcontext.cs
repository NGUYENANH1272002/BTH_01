using demomvc.Models;
using Microsoft.EntityFrameworkCore;

namespace demomvc.Data{
    public class ApplicationDbcontext : DbContext{
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> option) : base(option){}
        public DbSet<Person> Person {get; set;}     
    }
}