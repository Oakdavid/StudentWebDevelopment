using System.Configuration;
using WebDevelopment.Models.Entities;

namespace WebDevelopment.Dtos
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string Code { get; set; } = default!;
        public int Unit { get; set; }
        //public ICollection<Lesson> Lessons { get; set; } = new HashSet<Lesson>();
        //public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
    }
    public class CreateCourseRequestModel
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string Code { get; set; } = default!;
        public int Unit { get; set; }
    }

    public class GetAllCourses
    {
        public string Name { get; set; } = default!;
        public string Code { get; set; } = default!;
        public int Unit { get; set; } = default!;
    }
   
}
