using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Controllers
{
    public interface ILogic<T>
    {
        void Create(T item);
        T Read(int id);
        void Update(T item);
        void Delete(int id);
    }
}
