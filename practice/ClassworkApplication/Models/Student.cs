using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassworkApplication.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string AddedDate { get; set; }
        public string ModifiedDate { get; set; }
        public bool Status { get; set; }
        

    }
}