using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VittorioLongo.Diario.Entity;

namespace VittorioLongo.Diario.CRUDService
{
    public class AmministatoreManager
    {
        private readonly ICRUDService<Amministratore,int> _amministratoreService;

        public AmministatoreManager(ICRUDService<Amministratore, int> amministatoreService)
        {
            _amministratoreService = amministatoreService;
        }
    }
}
