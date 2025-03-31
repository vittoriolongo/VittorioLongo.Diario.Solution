using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VittorioLongo.Diario.CRUDService
{
    public class DiarioManager
    {
        private readonly ICRUDService<Entity.Diario, string> _diarioService;

        public DiarioManager(ICRUDService<Entity.Diario, string> diarioService)
        {
            _diarioService = diarioService;

        }
    }
}
