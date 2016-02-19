using ClassworkApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassworkApplication.Repository
{
    public interface IStudentRepository:IGenericRepository<Student>
    {

    }
    public class StudentRepository:IStudentRepository
    {
        public int Insert(Student e)
        {
            throw new NotImplementedException();
        }

        public int Update(Student e)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}