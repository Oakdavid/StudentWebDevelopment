﻿using WebDevelopment.Dtos;
using WebDevelopment.Models.Entities;

namespace WebDevelopment.Contract.Service
{
    public interface ICourseService
    {
        CourseDto Add(CreateCourseRequestModel course);
        CourseDto GetById(int id);
        IList<CourseDto> GetAll();
        IList<CourseDto> GetAllCourses();
        void Delete(int id);
    }
}
