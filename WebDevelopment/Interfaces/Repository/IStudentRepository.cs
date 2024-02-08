using WebDevelopment.Models.Entities;

namespace WebDevelopment.Contract.Repository
{
    public interface IStudentRepository
    {
        Student Add(Student student);
        Student GetById(int id);
        IList<Student> GetAll();
        void Delete(Student student);

    }
}
