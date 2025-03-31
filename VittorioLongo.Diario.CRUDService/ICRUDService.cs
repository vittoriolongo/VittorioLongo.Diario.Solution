using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VittorioLongo.Diario.CRUDService
{
    public interface ICRUDService<T, TKey>
    {
        T GetById(TKey id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllByUserID(TKey id);
        void Create(T entity);  
        void Update(T entity);  
        void Delete(TKey id);   
    }
}

