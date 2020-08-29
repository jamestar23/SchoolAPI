using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Controllers
{
    public interface IRepo<T>
    {
        void Create(T item);
        T Read(int id);
        void Update(T item);
        void Delete(int id);
    }
}
