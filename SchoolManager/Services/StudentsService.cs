using SchoolManager.Models;
using Microsoft.EntityFrameworkCore;

namespace SchoolManager.Services
{
    public class StudentsService
    {
        private readonly SchoolManagerContext _context;

        public StudentsService (SchoolManagerContext context)
        {
            _context = context;
        }

        public List<Student> FindAll()
        {
            return _context.Students.Include(p => p.Classroom).ToList();
        }
        public void Insert(Student obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
