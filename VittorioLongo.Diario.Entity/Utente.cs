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
        private int _utenteID;
        private string _nomeUtente;
        private string _password;
        private string _ruolo;

        public int GetUtenteID()
        {
            return _utenteID;
        }

        public void SetUtenteID(int utenteID)
        {
            _utenteID = utenteID;
        }

        public string GetNomeUtente()
        {
            return _nomeUtente;
        }

        public void SetNomeUtente(string nomeUtente)
        {
            _nomeUtente = nomeUtente;
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

