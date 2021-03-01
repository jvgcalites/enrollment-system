using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystem_DomainLayer
{
    class Student
    {
		public int StudentId { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Program { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public List<Course> CourseLoad { get; set; }
		public List<Course> CoursePassed { get; set; }
	}
}
