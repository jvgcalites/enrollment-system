using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnrollmentSystem
{
	public class Student
	{
		private int StudentId;
		private string FirstName;
		private string MiddleName;
		private string LastName;
		private string Program;
		private string Email;
		private string Password;
		private List<Course> CourseLoad;

		/// <summary>
		/// Returns All Information Student have
		/// </summary>
		/// <returns></returns>
		public Student GetStudentInfo()
		{
			throw new System.NotImplementedException();
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
		public List<Course> GetCourseLoad()
		{
			throw new System.NotImplementedException();
		}
	}
}