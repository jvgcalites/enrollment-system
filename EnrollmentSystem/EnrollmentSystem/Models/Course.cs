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

		public Course()
		{
			Section = new Section();
		}
	}
}