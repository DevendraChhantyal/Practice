using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassworkApplication.Repository
{
    public interface IGenericRepository<E> where E:class
    {
        int Insert(E e);
        int Update(E e);
        int Delete(int id);
        List<E> GetAll();

         E GetById(int id);

    }
}
