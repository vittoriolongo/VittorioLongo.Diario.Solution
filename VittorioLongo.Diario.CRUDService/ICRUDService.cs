namespace VittorioLongo.Diario.CRUDService
{
    // INTERFACCIA GENERICA: Definisce le operazioni CRUD per qualsiasi entità
    public interface ICRUDService<T, TKey> where T : class
    {
        void Create(T entity);               // Crea un nuovo elemento
        T GetById(TKey id);                  // Restituisce un elemento tramite ID
        IEnumerable<T> GetAll();             // Restituisce tutti gli elementi
        IEnumerable<T> GetAllByUserID(TKey id); // Restituisce tutti gli elementi di un utente specifico
        void Update(T entity);               // Aggiorna un elemento esistente
        void Delete(TKey id);                // Elimina un elemento tramite ID
    }
}