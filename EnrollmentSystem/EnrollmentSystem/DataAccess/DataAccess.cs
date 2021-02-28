using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystem
{
    class DataAccess
    {
		public static List<Section> GetAllSection(string courseCode)
		{
			List<Section> sectionList = new List<Section>();
			string connectionString =
			ConfigurationManager.ConnectionStrings["EnrollmentDB"]?.ConnectionString;
			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand("spGetSectionUsingCourseCode", connection))
			{
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("CourseCode", SqlDbType.VarChar, 50).Value = courseCode;
				connection.Open();
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						Section s = new Section();

						//Get SectionId
						int sectionIdIndex = reader.GetOrdinal(nameof(s.SectionId));
						s.SectionId = reader.GetInt32(sectionIdIndex);

						//Get SectionName
						int sectionNameIndex = reader.GetOrdinal(nameof(s.SectionName));
						s.SectionName = reader.GetString(sectionNameIndex);

						//Get Time
						int timeIndex = reader.GetOrdinal(nameof(s.Time));
						if (!reader.IsDBNull(timeIndex))
						{
							s.Time = reader.GetString(timeIndex);
						}

						//Get Date
						int dayIndex = reader.GetOrdinal(nameof(s.Day));
						if (!reader.IsDBNull(dayIndex))
						{
							s.Day = reader.GetString(dayIndex);
						}

						//Get Capacity
						int capacityIndex = reader.GetOrdinal(nameof(s.Capacity));
						if (!reader.IsDBNull(capacityIndex))
						{
							s.Capacity = reader.GetInt32(capacityIndex);
						}

						//Get AvailableSlot
						int availableSlotIndex = reader.GetOrdinal(nameof(s.AvailableSlot));
						if (!reader.IsDBNull(availableSlotIndex))
						{
							s.AvailableSlot = reader.GetInt32(availableSlotIndex);
						}
						sectionList.Add(s);
					}
				}
			}
			return sectionList;
		}

		public static Course GetCourseInfo(int courseId)
		{
			Course c = new Course();
			string connectionString =
			ConfigurationManager.ConnectionStrings["EnrollmentDB"]?.ConnectionString;
			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand("spGetCourseInfo", connection))
			{
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("CourseId", SqlDbType.Int).Value = courseId;
				connection.Open();
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
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
					}
				}
				return c;
			}
		}

		public static List<Course> GetAllCourseWithNoPreReq()
		{
			List<Course> courseList = new List<Course>();
			string connectionString =
			ConfigurationManager.ConnectionStrings["EnrollmentDB"]?.ConnectionString;
			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand("spGetAllCourseWithNoPreReq", connection))
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

	}
}
