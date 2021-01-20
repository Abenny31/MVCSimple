using MVC3101.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC3101.DAL
{
    public class PopisDBContext : DbContext
    {
       
        public PopisDBContext()
            : base("baza") { }
        
        public DbSet<Osoba> _dbO { get; set; }




    
        


    }
}