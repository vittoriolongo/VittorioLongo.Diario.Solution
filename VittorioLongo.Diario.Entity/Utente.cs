using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace VittorioLongo.Diario.Entity
{
    public class Utente
    {
        private string _nomeUtente;
        private string _password;
        private string _ruolo;

        // Metodo getter per NomeUtente
        public string GetNomeUtente()
        {
            return _nomeUtente;
        }

        // Metodo setter per NomeUtente
        public void SetNomeUtente(string nomeUtente)
        {
            _nomeUtente = nomeUtente;
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
        /*public Utente(string nomeUtente, string password, string ruolo)
        {
            _nomeUtente = nomeUtente;
            _password = password;
            _ruolo = ruolo;
        }*/
    }
}

