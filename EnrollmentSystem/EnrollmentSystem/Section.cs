using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EnrollmentSystem
{
	public class Section
	{
		public int SectionId { get; set; }
		public string SectionName { get; set; }
		public string Time { get; set; }
		public string Day { get; set; }
		public int Capacity { get; set; }
		public int AvailableSlot { get; set; }

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
	}
}