namespace VittorioLongo.Diario.Entity
{
    public class Diario
    {
        private string _objectID;
        private int _utenteID;
        private string _testo;
        private DateTime _dataTesto;

        public string GetObjectID()
        {
            return _objectID;
        }

        public void SetObjectID(string objectID)
        {
            _objectID = objectID;
        }

        public int GetUtenteID()
        {
            return _utenteID;
        }

        public void SetUtenteID(int utenteID)
        {
            _utenteID = utenteID;
        }

        public string GetTesto()
        {
            return _testo;
        }

        public void SetTesto(string testo)
        {
            _testo = testo;
        }

        public DateTime GetDataTesto()
        {
            return _dataTesto;
        }

        public void SetDataTesto(DateTime dataTesto)
        {
            _dataTesto = dataTesto;
        }
    }

}

