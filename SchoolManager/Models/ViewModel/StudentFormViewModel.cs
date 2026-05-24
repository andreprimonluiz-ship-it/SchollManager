namespace SchoolManager.Models.ViewModel
{
    public class StudentFormViewModel
    {
        public Student Student { get; set; }
        public ICollection<Classroom> Classrooms { get; set; } = new List<Classroom>();
    }
}
