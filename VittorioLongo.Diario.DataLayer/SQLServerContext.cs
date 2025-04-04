using Microsoft.EntityFrameworkCore;
using VittorioLongo.Diario.Entity;

namespace VittorioLongo.Diario.DataLayer
{
    // CLASSE CONTESTO: Classe per gestire il contesto di connessione al database SQL Server
    public class SQLServerContext : DbContext
    {
        // COSTRUTTORE: Inizializza il contesto con le opzioni specificate
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options)
        {
        }

        // COSTRUTTORE VUOTO: Necessario per alcune operazioni di Entity Framework
        public SQLServerContext() { }

        // PROPRIETÀ: Rappresenta la tabella Utenti nel database
        public DbSet<Utente> Utenti { get; set; }

        // CONFIGURAZIONE: Imposta la stringa di connessione al database SQL Server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Inserire stringa connessione SQLSERVER");
        }
    }
}
