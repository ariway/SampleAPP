using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiAPP.Data.Interface
{
    public interface ICrud<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task GetById(int id);

        Task Insert(T obj);
        Task Update(int id, T obj);
        Task Delete(int id);

    }
}
