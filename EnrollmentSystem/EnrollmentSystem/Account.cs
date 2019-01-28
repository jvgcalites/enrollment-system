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
	class Account
	{
		public Student StudAcct { get; set; }

		public Account()
		{
			StudAcct = new Student();
		}

		public bool VerifyAccount(string email, string password)
		{
			bool isVerified = false;
			StudAcct.Email = email;
			StudAcct = GetStudentInfo(); //return stud
			if (StudAcct.Email == email) //check if email is valid
			{
				if (StudAcct.Password == password)
				{
					isVerified = true;
				}
				else
				{
					isVerified = false;
				}
			}
			return isVerified;
		}


		public Student GetStudentInfo()
		{
			string connectionString =
			ConfigurationManager.ConnectionStrings["EnrollmentDB"]?.ConnectionString;
			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand("Student_GetAll", connection))
			{
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("Email", SqlDbType.VarChar, 256).Value = StudAcct.Email;
				connection.Open();
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						//Get StudentId
						int idIndex = reader.GetOrdinal(nameof(Student.StudentId));
						StudAcct.StudentId = reader.GetInt32(idIndex);

						//Get FirstName
						int firstNameIndex = reader.GetOrdinal(nameof(Student.FirstName));
						StudAcct.FirstName = reader.GetString(firstNameIndex);

						//Get MiddleName
						int middleNameIndex = reader.GetOrdinal(nameof(Student.MiddleName));
						if (!reader.IsDBNull(middleNameIndex))
						{
							StudAcct.MiddleName = reader.GetString(middleNameIndex);
						}

						//Get LastName
						int lastNameIndex = reader.GetOrdinal(nameof(Student.LastName));
						StudAcct.LastName = reader.GetString(lastNameIndex);

						//Get Program
						int programIndex = reader.GetOrdinal(nameof(Student.Program));
						StudAcct.Program = reader.GetString(programIndex);

						//Get Email
						int emailIndex = reader.GetOrdinal(nameof(Student.Email));
						StudAcct.Email = reader.GetString(emailIndex);

						//Get Password
						int passwordIndex = reader.GetOrdinal(nameof(Student.Password));
						StudAcct.Password = reader.GetString(passwordIndex);

					}
				}
			}
			return StudAcct;
		}

		public List<Course> GetStudentLoad()
		{
			string connectionString =
			ConfigurationManager.ConnectionStrings["EnrollmentDB"]?.ConnectionString;
			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand("spGetStudentCourseAndSection", connection))
			{
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("StudentId", SqlDbType.Int).Value = StudAcct.StudentId;
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
						int CourseTitleIndex = reader.GetOrdinal(nameof(Course.CourseTitle));
						c.CourseTitle = reader.GetString(CourseTitleIndex);

						//Get CourseCode
						int courseCodeIndex = reader.GetOrdinal(nameof(Course.CourseCode));
						c.CourseCode = reader.GetString(courseCodeIndex);

						//Get Unit
						int unitIndex = reader.GetOrdinal(nameof(Course.Unit));
						c.Unit = reader.GetInt32(unitIndex);

						//Get SectionId
						int sectionIdIndex = reader.GetOrdinal(nameof(Section.SectionId));
						if (!reader.IsDBNull(sectionIdIndex))
						{
							c.Section.SectionId = reader.GetInt32(sectionIdIndex);
						}

						//Get SectionName
						int sectionNameIndex = reader.GetOrdinal(nameof(Section.SectionName));
						if (!reader.IsDBNull(sectionNameIndex))
						{
							c.Section.SectionName = reader.GetString(sectionNameIndex);
						}

						//Get Time
						int timeIndex = reader.GetOrdinal(nameof(Section.Time));
						if (!reader.IsDBNull(timeIndex))
						{
							c.Section.Time = reader.GetString(timeIndex);
						}

						//Get Day
						int dayIndex = reader.GetOrdinal(nameof(Section.Day));
						if (!reader.IsDBNull(dayIndex))
						{
							c.Section.Day = reader.GetString(dayIndex);
						}

						//Get Capacity
						int capacityIndex = reader.GetOrdinal(nameof(Section.Capacity));
						if (!reader.IsDBNull(capacityIndex))
						{
							c.Section.Capacity = reader.GetInt32(capacityIndex);
						}

						//Get AvailableSlot
						int availableSlotIndex = reader.GetOrdinal(nameof(Section.AvailableSlot));
						if (!reader.IsDBNull(availableSlotIndex))
						{
							c.Section.Capacity = reader.GetInt32(availableSlotIndex);
						}

						StudAcct.CourseLoad.Add(c);
					}
				}
				return StudAcct.CourseLoad;
			}
		}

		public List<Course> GetAllCoursePassed()
		{
			List<Course> courseList = new List<Course>();
			string connectionString =
			ConfigurationManager.ConnectionStrings["EnrollmentDB"]?.ConnectionString;
			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand("spGetAllCoursePassed", connection))
			{
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("StudentId", SqlDbType.Int).Value = StudAcct.StudentId;
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

		public int AddCourseLoad(int courseId)
		{
			string connectionString =
			ConfigurationManager.ConnectionStrings["EnrollmentDB"]?.ConnectionString;
			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand("spInsertCourse", connection))
			{
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("StudentId", SqlDbType.Int).Value = StudAcct.StudentId;
				command.Parameters.Add("CourseId", SqlDbType.Int).Value = courseId;
				connection.Open();
				return command.ExecuteNonQuery();
			}
		}
	}
}
