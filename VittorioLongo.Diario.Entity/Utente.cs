using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.ComponentModel.DataAnnotations.Schema;


namespace VittorioLongo.Diario.Entity
{
    public class Utente
    {
        [Column("ID")]
        public int ID { get; set; }
        public string NomeUtente { get; private set; }
        public string Password { get; private set; }
        public string Ruolo { get; set; }

        // COSTRUTTORE PRIVATO : Evita la possibilità creazioni dirette
        private Utente() { }

        // COSTRUTTORE PUBBLICO : Permette a Entity Framework di creare l'oggetto
        public Utente(string nomeUtente, string passwordHash, string ruolo)
        {
            NomeUtente = nomeUtente;
            Password = passwordHash;
            Ruolo = ruolo;
        }

        // UPDATE : Modifica password e user
        public void Update(string nuovoUser, string nuovaPassword)
        {
            NomeUtente = nuovoUser;
            Password = nuovaPassword;
        }
    }
}
