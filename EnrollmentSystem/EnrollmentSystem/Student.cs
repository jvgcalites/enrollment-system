using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EnrollmentSystem
{
	public class Student
	{
		public int StudentId;
		public string FirstName;
		public string MiddleName;
		public string LastName;
		public string Program;
		public string Email;
		public string Password;
		public List<Course> CourseLoad;
		public List<Course> CoursePassed;


		public Student()
		{
			CourseLoad = new List<Course>();
			CoursePassed = new List<Course>();
		}

	}
}