using Microsoft.EntityFrameworkCore;
using GunsoftheoldWest.Ui.Mvc.Models;


namespace PeopleManager.Ui.Mvc.Core
{
    public class PeopleManagerDbContext : DbContext
    {
        public PeopleManagerDbContext(DbContextOptions<PeopleManagerDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People => Set<Person>();

        public void Seed()
        {
            People.AddRange(new List<Person>
            {
                new Person { FirstName = "John", LastName = "Doe", Email = "johndoe@example.com", Phone = "07872932424" },
                new Person { FirstName = "Jane", LastName = "Smith", Email = "jane@gmail.com", Phone="09230120913" },
            });

            SaveChanges();
        }
    }
}