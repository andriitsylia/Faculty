using Faculty.DAL.Entities;
using System;
using AppContext = Faculty.DAL.EF.AppContext;

namespace Faculty.DAL.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private readonly AppContext _appContext;
        private FacultyRepository<Course> _courseRepository;
        private FacultyRepository<Group> _groupRepository;
        private FacultyRepository<Student> _studentRepository;

        public FacultyRepository<Course> CourseRepository
        {
            get
            {
                if (_courseRepository == null)
                {
                    _courseRepository = new FacultyRepository<Course>(_appContext);
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
                    _groupRepository = new FacultyRepository<Group>(_appContext);
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
                    _studentRepository = new FacultyRepository<Student>(_appContext);
                }
                return _studentRepository;
            }
        }

        public UnitOfWork(AppContext appContext)
        {
            _appContext = appContext;
        }

        public void Save()
        {
            _appContext.SaveChanges();
        }

        private bool disposed = false;

        protected void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _appContext.Dispose();
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
