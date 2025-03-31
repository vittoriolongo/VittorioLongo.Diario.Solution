using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VittorioLongo.Diario.Entity
{
    public class Amministratore
    {
        private int _idAmministratore;
        private string _nomeAmministratore;
        private string _password;
        private string _ruolo;

        public int GetIdAmministratore()
        {
            return _idAmministratore;
        }

        public void SetIdAmministratore(int idAmministratore)
        {
            _idAmministratore = idAmministratore;
        }

        public string GetNomeAmministratore()
        {
            return _nomeAmministratore;
        }

        public void SetNomeAmministratore(string nomeAmministratore)
        {
            _nomeAmministratore = nomeAmministratore;
        }

        public string GetPassword()
        {
            return _password;
        }

        public void SetPassword(string password)
        {
            _password = password;
        }

        public string GetRuolo()
        {
            return _ruolo;
        }

        public void SetRuolo(string ruolo)
        {
            _ruolo = ruolo;
        }
    }

}
