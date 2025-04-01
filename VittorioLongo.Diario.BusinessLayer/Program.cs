using System;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Graph;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using VittorioLongo.Diario.CRUDService;
using VittorioLongo.Diario.DataLayer;
using VittorioLongo.Diario.Service.Utente;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VittorioLongo.Diario.BusinessLayer
{

    class Program
    {
        static void Main(string[] args)
        {
            // Crea il contesto manualmente
            var options = new DbContextOptionsBuilder<SQLServerContext>()
                .UseSqlServer(@"Server=VITTORIO\SQLEXPRESS; Database=DiarioDBSQLServer; Integrated Security=True; Connect Timeout=30; Encrypt=False;")
                .Options;

            var context = new SQLServerContext(options);
            var utenteManager = new UtenteManager(context);

            string connectionString = "mongodb://localhost:27017/";
            string databaseName = "DiarioDBForDotNet";
            MongoDBContext context2 = new MongoDBContext(connectionString, databaseName);
            DiarioService diarioService = new DiarioService(context2);

            // Creazione di un nuovo diario
            Entity.Diario nuovoDiario = new Entity.Diario
            {
                UserID = 4, // Sostituiscilo con un valore reale
                Testo = "Questo è un test per MongoDB.",
                DataTesto = DateTime.Now
            };

            // Inserisci il diario nel database
            diarioService.Create(nuovoDiario);
            Console.WriteLine("Diario creato con successo!");

        }
    }
}
   