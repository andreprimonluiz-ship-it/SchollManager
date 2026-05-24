using SchoolManager.Models;

namespace SchoolManager.Services
{
    public class ClassroomService
    {
        private readonly SchoolManagerContext _context;

        public ClassroomService(SchoolManagerContext context)
        {
            _context = context;
        }

        public List<Classroom> FindAll()
        {
           return _context.Classrooms.OrderBy(x => x.Name).ToList();
        }
    }
}
