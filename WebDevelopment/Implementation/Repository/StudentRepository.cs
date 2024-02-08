using WebDevelopment.Contract.Repository;
using WebDevelopment.Models.Context;
using WebDevelopment.Models.Entities;

namespace WebDevelopment.Implementation.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Student Add(Student student)
        {
            _dbContext.Students.Add(student);
            return student;
        }


        public void Delete(Student student)
        {
            _dbContext.Students.Remove(student);
        }

        public IList<Student> GetAll()
        {
            var list = _dbContext.Students.ToList();
            return list;
        }

        public Student GetById(int id)
        {
            var student = _dbContext.Students.SingleOrDefault(s => s.Id == id);
            return student;
        }
    }
}
