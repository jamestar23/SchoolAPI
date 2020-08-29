using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Controllers
{
    public class StudentLogic : ILogic<Student>
    {
        private IRepo<Student> _repo;
        public StudentLogic(IRepo<Student> repo)
        {
            _repo = repo;
        }
        public void Create(Student item)
        {
            _repo.Create(item);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public Student Read(int id)
        {
            return _repo.Read(id);
        }

        public void Update(Student item)
        {
            _repo.Update(item);
        }
    }
}
