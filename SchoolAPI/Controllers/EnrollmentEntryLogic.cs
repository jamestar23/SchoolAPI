using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Controllers
{
    public class EnrollmentEntryLogic : ILogic<EnrollmentEntry>
    {
        private IRepo<EnrollmentEntry> _repo;
        public EnrollmentEntryLogic(IRepo<EnrollmentEntry> repo)
        {
            _repo = repo;
        }
        public void Create(EnrollmentEntry item)
        {
            _repo.Create(item);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public EnrollmentEntry Read(int id)
        {
            return _repo.Read(id);
        }

        public void Update(EnrollmentEntry item)
        {
            _repo.Update(item);
        }
    }
}
