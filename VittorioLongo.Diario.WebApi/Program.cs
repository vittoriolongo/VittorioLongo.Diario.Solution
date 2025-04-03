using VittorioLongo.Diario.CRUDService;
using VittorioLongo.Diario.DataLayer;
using VittorioLongo.Diario.Service.Utente;

var builder = WebApplication.CreateBuilder(args);

// Configurazione la stringa di connessione MongoDB manualmente
var mongoConnectionString = "inserire stringa di conessione"; // Connessione al tuo MongoDB
var mongoDatabaseName = "inserire nome db"; // Nome del database

// Aggiunto il DbContext di MongoDB
builder.Services.AddSingleton<MongoDBContext>(sp => new MongoDBContext(mongoConnectionString, mongoDatabaseName));

// Aggiunto  DbContext SQL Server
builder.Services.AddDbContext<SQLServerContext>();

// Aggiunti i servizi con ciclo di vita Transient
builder.Services.AddTransient<UtenteManager>();  // Transient per UtenteManager
builder.Services.AddTransient<DiarioManager>();  // Transient per DiarioManager

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
