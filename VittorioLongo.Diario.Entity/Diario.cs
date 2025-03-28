namespace VittorioLongo.Diario.Entity
{
    public class Diario
    {
        private string _objectId;  // Variabile privata per ObjectId
        private int _idUtente;
        private string _testo;
        private DateTime _dataTesto;

        // Metodo getter per ObjectId
        public string GetObjectId()
        {
            return _objectId;
        }

        // Metodo setter per ObjectId
        public void SetObjectId(string objectId)
        {
            _objectId = objectId;
        }

        // Metodo getter per IdUtente
        public int GetIdUtente()
        {
            return _idUtente;
        }

        // Metodo setter per IdUtente
        public void SetIdUtente(int idUtente)
        {
            _idUtente = idUtente;
        }

        // Metodo getter per Testo
        public string GetTesto()
        {
            return _testo;
        }

        // Metodo setter per Testo
        public void SetTesto(string testo)
        {
            _testo = testo;
        }

        // Metodo getter per DataTesto
        public DateTime GetDataTesto()
        {
            return _dataTesto;
        }

        // Metodo setter per DataTesto
        public void SetDataTesto(DateTime dataTesto)
        {
            _dataTesto = dataTesto;
        }

        // Costruttore opzionale
        /*public Diario(string objectId, int idUtente, string testo, DateTime dataTesto)
        {
            _objectId = objectId;
            _idUtente = idUtente;
            _testo = testo;
            _dataTesto = dataTesto;
        }*/
    }
}

