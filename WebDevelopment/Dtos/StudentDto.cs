using WebDevelopment.Models.Entities;

namespace WebDevelopment.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string MatriculationNumber { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string Address { get; set; } = default!;
        public DateOnly DateOfBirth { get; set; }
        public ICollection<CourseDto> Courses { get; set; } = new HashSet<CourseDto>();



    }

    public class CreateStudentRequestModel
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string Address { get; set; } = default!;
        public DateOnly DateOfBirth { get; set; } = default!;
        public ICollection <int> CoursesId { get; set; } = new HashSet<int>();


    }
}
