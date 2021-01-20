using MVC3101.Models;
using System.Data.Entity;

namespace MVC3101.DAL
{
    public class PopisDBContext : DbContext
    {
       
        public PopisDBContext()
            : base("baza") { }
        
        public DbSet<Osoba> _dbO { get; set; }




    
        


    }
}