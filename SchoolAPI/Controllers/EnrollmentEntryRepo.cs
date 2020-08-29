using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Controllers
{
    public class EnrollmentEntryRepo : IRepo<EnrollmentEntry>
    {
        private SchoolContext _context;

        public EnrollmentEntryRepo()
        {
            _context = new SchoolContext();
        }

        public void Create(EnrollmentEntry item)
        {
            _context.EnrollmentEntries.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _context.EnrollmentEntries.Find(id);
            _context.Entry(item).State = EntityState.Deleted;
        }

        public EnrollmentEntry Read(int id)
        {
            return _context.EnrollmentEntries.Where(a => a.Id == id).FirstOrDefault();
        }

        public void Update(EnrollmentEntry item)
        {
            _context.EnrollmentEntries.Update(item);
            _context.SaveChanges();
        }
    }
}
