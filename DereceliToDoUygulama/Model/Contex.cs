using Microsoft.EntityFrameworkCore;
namespace DereceliToDoUygulama.Model
{
    public class Contex:DbContext
    {
        public Contex(DbContextOptions<Contex> options):base(options)
        {
            
        }
        public DbSet<ToDoModel> ToDoList { get; set; }
    }
}
