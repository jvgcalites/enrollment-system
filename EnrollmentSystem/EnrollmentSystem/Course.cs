using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EnrollmentSystem
{
	public class Course
	{
		public int CourseId { get; set; }
		public string CourseCode { get; set; }
		public string CourseTitle { get; set; }
		public int Unit { get; set; }
		public Section Section { get; set; }

		/// <summary>
		/// Returns All Information of the course
		/// </summary>
		/// <returns></returns>
		/// 

		public Course()
		{
			Section = new Section();
		}
		public Course GetCourseInfo()
		{
			throw new System.NotImplementedException();
		}
		/// <summary>
		/// Add new section to the course
		/// </summary>
		public void AddSection()
		{
			throw new System.NotImplementedException();
		}
		/// <summary>
		/// Remove current section of the course
		/// </summary>
		public void RemoveSection()
		{
			throw new System.NotImplementedException();
		}
		/// <summary>
		/// Update current section of the course
		/// </summary>
		public void UpdateSection()
		{

		}

		#region GetAllCourseOfStudent
		/// <summary>
		/// SELECT CourseId
		/// FROM StudentCourse
		/// WHERE StudentId matches
		/// Store all Course Id to a list
		/// </summary>
		/// <returns></returns>
		public static List<Course> GetAllCourseOfStudent()
		{
			List<Course> courseList = new List<Course>();
			string connectionString =
			ConfigurationManager.ConnectionStrings["EnrollmentDB"]?.ConnectionString;
			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand("spGetAllCourse", connection))
			{
				command.CommandType = CommandType.StoredProcedure;
				connection.Open();
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						Course c = new Course();
						//Get CourseId
						int CourseIdIndex = reader.GetOrdinal(nameof(Course.CourseId));
						c.CourseId = reader.GetInt32(CourseIdIndex);

						//Get CourseTitle
						int CourseNameIndex = reader.GetOrdinal(nameof(Course.CourseTitle));
						c.CourseTitle = reader.GetString(CourseNameIndex);

						//Get CourseCode
						int courseCodeIndex = reader.GetOrdinal(nameof(Course.CourseCode));
						c.CourseCode = reader.GetString(courseCodeIndex);

						//Get Units
						int unitIndex = reader.GetOrdinal(nameof(Course.Unit));
						c.Unit = reader.GetInt32(unitIndex);

						courseList.Add(c);
					}
				}
				return courseList;
			}
		}
		#endregion
	}
}