using Faculty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Repositories
{
    public class StudentsRepository
    {
        private readonly AppContext _appContext;

        public StudentsRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IQueryable<Student> GetStudents()
        {
            return _appContext.Students;
        }

        public IQueryable<Student> GetStudentsByGroupId(int groupId)
        {
            return _appContext.Students.Where(s => s.GroupId == groupId);
        }

        public Student GetStudentById(int studentId)
        {
            return _appContext.Students.Single(s => s.StudentId == studentId);
        }

        public int SaveStudent(Student student)
        {
            return 1;
        }

        public void DeleteStudent(Student student)
        {
            _appContext.Students.Remove(student);
            _appContext.SaveChanges();
        }
    }
}
