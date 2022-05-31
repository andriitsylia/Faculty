using Faculty.DAL.Entities;
using Faculty.DAL.EF;
using System;
//using FacultyContext = Faculty.DAL.EF.FacultyContext;

namespace Faculty.DAL.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private readonly FacultyContext _facultyContext;
        private FacultyRepository<Course> _courseRepository;
        private FacultyRepository<Group> _groupRepository;
        private FacultyRepository<Student> _studentRepository;

        public FacultyRepository<Course> CourseRepository
        {
            get
            {
                if (_courseRepository == null)
                {
                    _courseRepository = new FacultyRepository<Course>(_facultyContext);
                }
                return _courseRepository;
            }
        }

        public FacultyRepository<Group> GroupRepository
        {
            get
            {
                if (_groupRepository == null)
                {
                    _groupRepository = new FacultyRepository<Group>(_facultyContext);
                }
                return _groupRepository;
            }
        }

        public FacultyRepository<Student> StudentRepository
        {
            get
            {
                if (_studentRepository == null)
                {
                    _studentRepository = new FacultyRepository<Student>(_facultyContext);
                }
                return _studentRepository;
            }
        }

        public UnitOfWork(FacultyContext facultyContext)
        {
            _facultyContext = facultyContext;
        }

        public void Save()
        {
            _facultyContext.SaveChanges();
        }

        private bool disposed = false;

        protected void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _facultyContext.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
