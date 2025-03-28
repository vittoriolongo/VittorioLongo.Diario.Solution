using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VittorioLongo.Diario.Entity;

namespace VittorioLongo.Diario.Service.Amministratore
{
    public interface IAmministratoreService
    {
        IEnumerable<Utente> DammiListaUtentiAdmin();

        Utente DammiUtentePerUsernameAdmin(string username);

        List<Entity.Diario> DammiListaTestiAdminPerUtente(int userId);

        IEnumerable<Entity.Diario> DammiTuttiTestiAdmin();

        Entity.Diario CreaTestoAdmin(Entity.Diario diario, int userId);

        Entity.Diario ModificaTestoAdminPerId(Entity.Diario diario, string id);

        Utente ModificaPasswordUtenteAdmin(Utente utente, int userId);

        void EliminaUtenteAdminPerId(int id);

        void EliminaTestoAdminPerId(string id);
    }
}
