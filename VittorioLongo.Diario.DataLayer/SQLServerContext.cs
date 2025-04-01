using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VittorioLongo.Diario.Entity;

namespace VittorioLongo.Diario.DataLayer
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
        : base(options)
        {
        }

        public SQLServerContext() { }   

        public DbSet<Utente> Utenti {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               @"Server=VITTORIO\SQLEXPRESS; Database=DiarioDBSQLServer; Integrated Security=True; Connect Timeout=30; Encrypt=False;");
        }
    }
}
