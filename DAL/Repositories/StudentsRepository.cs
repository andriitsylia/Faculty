using DAL.Entities;
using DAL.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
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

        public void SaveStudent(Student student)
        {
            _appContext.Entry(student).State = EntityState.Modified;
            _appContext.SaveChanges();
        }

        public void DeleteStudent(Student student)
        {
            _appContext.Students.Remove(student);
            _appContext.SaveChanges();
        }
    }
}
