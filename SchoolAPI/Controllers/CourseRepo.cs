using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Controllers
{
    public class CourseRepo : IRepo<Course>
    {
        private SchoolContext _context;

        public CourseRepo()
        {
            _context = new SchoolContext();
        }
        public void Create(Course item)
        {
            _context.Courses.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _context.Courses.Find(id);
            _context.Entry(item).State = EntityState.Deleted;
        }

        public Course Read(int id)
        {
            return _context.Courses.Where(a => a.Id == id).FirstOrDefault();
        }

        public void Update(Course item)
        {
            _context.Courses.Update(item);
            _context.SaveChanges();
        }
    }
}
