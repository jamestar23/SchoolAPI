using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Controllers
{
    public class StudentRepo : IRepo<Student>
    {
        private SchoolContext _context;

        public StudentRepo()
        {
            _context = new SchoolContext();
        }
        public void Create(Student item)
        {
            _context.Students.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _context.Students.Find(id);
            _context.Entry(item).State = EntityState.Deleted;
        }

        public Student Read(int id)
        {
            return _context.Students.Where(a => a.Id == id).FirstOrDefault();
        }

        public void Update(Student item)
        {
            _context.Students.Update(item);
            _context.SaveChanges();
        }
    }
}
