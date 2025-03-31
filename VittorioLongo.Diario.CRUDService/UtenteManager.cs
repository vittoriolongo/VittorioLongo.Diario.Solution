using VittorioLongo.Diario.CRUDService;

namespace VittorioLongo.Diario.Service.Utente
{
    public class UtenteManager
    {
        private readonly ICRUDService<Entity.Utente, int> _utenteService;

        public UtenteManager(ICRUDService<Entity.Utente, int> utenteService)
        {
            _utenteService = utenteService;
        }
    }

}
