using WebDevelopment.Contract.Repository;
using WebDevelopment.Dtos;
using WebDevelopment.Models.Context;
using WebDevelopment.Models.Entities;

namespace WebDevelopment.Implementation.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CourseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Course Add(Course course)
        {
            _dbContext.Courses.Add(course);
            return course;
        }

        public void Delete(Course course)
        {
            _dbContext.Courses.Remove(course);
        }

        public IList<Course> GetAll()
        {
            return _dbContext.Courses.ToList();
        }

        

        public IList<GetAllCourses> GetAllCourses()  //  indexing of selecting what is needed
        {
            var list = _dbContext.Courses.Select(a => new GetAllCourses()
            {
                Name = a.Name,
                Code = a.Code,
                Unit = a.Unit

            }).ToList();
            return list;
        }

        public Course GetById(int id)
        {
            return _dbContext.Courses.FirstOrDefault(a => a.Id == id);
        }

    }
}
