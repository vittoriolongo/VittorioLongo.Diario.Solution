namespace VittorioLongo.Diario.Service.Amministratore
{
    public class AmministratoreManager
    {

        private readonly IAmministratoreService _amministratoreService;

        public AmministratoreManager(IAmministratoreService amministratoreService)
        {
            _amministratoreService = amministratoreService;
        }

    }
}
