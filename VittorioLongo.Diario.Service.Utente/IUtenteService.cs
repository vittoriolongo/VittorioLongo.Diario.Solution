using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VittorioLongo.Diario.Entity;

namespace VittorioLongo.Diario.Service.Utente
{
    public interface IUtenteService
    { 
        List<Entity.Diario> DammiListaTestiPerUtente();

        // Restituisce null se non trova il diario
        Entity.Diario? DammiTestoPerId(string id);

        // Restituisce null se non trova il diario da modificare
        Entity.Diario? ModificaTestoPerId(Entity.Diario diario, string id);

        void EliminaTestoPerId(string id);

        Entity.Diario RegistraUtente(Entity.Utente utente);
    }
}
