namespace VittorioLongo.Diario.Service.Utente
{
    public class UtenteManager
    {
        private readonly IUtenteService _utenteService;

        public UtenteManager(IUtenteService utenteService) {
            _utenteService = utenteService;
        }
    }
}
