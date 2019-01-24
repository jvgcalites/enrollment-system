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


		public Student()
		{
			CourseLoad = new List<Course>();
		}


		/// <summary>
		/// Scans CourseLoad, if course exists, course is taken
		/// </summary>
		/// <returns></returns>
		public bool CourseTaken(Course course)
		{
			throw new System.NotImplementedException();
		}
		/// <summary>
		/// Add a course to CourseLoad
		/// </summary>
		/// <param name="course"></param>
		/// <returns></returns>
		public List<Course> AddCourseLoad(Course course)
		{
			throw new System.NotImplementedException();
		}
		/// <summary>
		/// Remove a course from CourseLoad
		/// </summary>
		/// <param name="course"></param>
		public List<Course> RemoveCourse(Course course)
		{
			throw new System.NotImplementedException();
		}
		/// <summary>
		/// Gets all Courses student currently have
		/// </summary>
		/// <returns></returns>
		//public List<Course> GetCourseLoad()
		//{
		//	throw new System.NotImplementedException();
		//}
	}
}