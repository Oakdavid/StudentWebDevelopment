using System.Collections.Generic;
using WebDevelopment.Dtos;
using WebDevelopment.Models.Entities;

namespace WebDevelopment.Contract.Repository
{
    public interface ICourseRepository
    {
        Course Add(Course course);
        Course GetById(int id);
        IList<Course> GetAll();
        void Delete(Course course);
        IList <GetAllCourses> GetAllCourses();
    }
    
}
