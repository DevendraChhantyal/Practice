using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassworkApplication.Models;

namespace ClassworkApplication.Repository
{
    public interface ICourseRepository : IGenericRepository<Course>
    {

    }
    public class CourseRepository : ICourseRepository
    {
        public int Insert(Course e)
        {
            throw new NotImplementedException();
        }

        public int Update(Course e)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            throw new NotImplementedException();
        }

        public Course GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}