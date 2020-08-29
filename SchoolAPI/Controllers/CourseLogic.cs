using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Controllers
{
    public class CourseLogic : ILogic<Course>
    {
        private IRepo<Course> _repo;
        public CourseLogic(IRepo<Course> repo)
        {
            _repo = repo;
        }
        public void Create(Course item)
        {
            _repo.Create(item);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public Course Read(int id)
        {
            return _repo.Read(id);
        }

        public void Update(Course item)
        {
            _repo.Update(item);
        }
    }
}
