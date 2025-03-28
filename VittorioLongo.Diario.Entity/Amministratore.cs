using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VittorioLongo.Diario.Entity
{
    public class Amministratore
    {
        private string _nomeAmministratore;
        private string _password;
        private string _ruolo;

        // Metodo getter per NomeAmministratore
        public string GetNomeAmministratore()
        {
            return _nomeAmministratore;
        }

        // Metodo setter per NomeAmministratore
        public void SetNomeAmministratore(string nomeAmministratore)
        {
            _nomeAmministratore = nomeAmministratore;
        }

        // Metodo getter per Password
        public string GetPassword()
        {
            return _password;
        }

        // Metodo setter per Password
        public void SetPassword(string password)
        {
            _password = password;
        }

        // Metodo getter per Ruolo
        public string GetRuolo()
        {
            return _ruolo;
        }

        // Metodo setter per Ruolo
        public void SetRuolo(string ruolo)
        {
            _ruolo = ruolo;
        }

        // Costruttore opzionale
        public Amministratore(string nomeAmministratore, string password, string ruolo)
        {
            _nomeAmministratore = nomeAmministratore;
            _password = password;
            _ruolo = ruolo;
        }
    }
}
