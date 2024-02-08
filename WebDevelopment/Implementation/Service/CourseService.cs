using WebDevelopment.Contract.Repository;
using WebDevelopment.Contract.Service;
using WebDevelopment.Dtos;
using WebDevelopment.Models.Entities;

namespace WebDevelopment.Implementation.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CourseService(ICourseRepository courseRepository, IUnitOfWork unitOfWork)
        {
            _courseRepository = courseRepository;
            _unitOfWork = unitOfWork;
        }

        public CourseDto Add(CreateCourseRequestModel course)
        {
            var courseObject = new Course
            {
                Code = course.Code,
                Name = course.Name,
                Unit = course.Unit,
                Description = course.Description
            };
            var createdCourse = _courseRepository.Add(courseObject);
            _unitOfWork.Save();
            return new CourseDto
            {
                Name = createdCourse.Name,
                Code = createdCourse.Code,
                Unit = createdCourse.Unit,
                Description = createdCourse.Description,
                Id = createdCourse.Id
            };
                
        }

        public void Delete(int id)
        {
            var course = _courseRepository.GetById(id);
            _courseRepository.Delete(course);
            _unitOfWork.Save();
        }

        public IList<CourseDto> GetAll()
        {
            var courses = _courseRepository.GetAll();
            return courses.Select(a =>  new CourseDto
            {
                Name =a.Name,
                Code = a.Code,  
                Unit = a.Unit,
                Description = a.Description,
                Id = a.Id
            }).ToList();
        }

        public IList<CourseDto> GetAllCourses()
        {
            var courses = _courseRepository.GetAllCourses();
            return courses.Select(a => new CourseDto
            {
                Name = a.Name,
                Code = a.Code,
                Unit = a.Unit

            }).ToList();
        }

        public CourseDto GetById(int id)
        {
            var course = _courseRepository.GetById(id);
            if (course == null)
            {
                return default;
            }
            return new CourseDto
            {
                Name=course.Name,
                Code = course.Code,
                Unit = course.Unit,
                Description = course.Description,
            };
        }
    }
}
