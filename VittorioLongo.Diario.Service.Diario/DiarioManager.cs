namespace VittorioLongo.Diario.Service.Diario
{
    public class DiarioManager
    {
            private readonly IDiarioService _diarioService;

            public DiarioManager(IDiarioService diarioService)
            {
                _diarioService = diarioService;
            }

    }
}
