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

        public int GetAccount(Student student)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EnrollmentDB"]?.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("GetData", connection))
            {

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("Email", SqlDbType.VarChar, 50).Value = student.Email;
                command.Parameters.Add("Password", SqlDbType.VarChar, 50).Value = student.Password;
               

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var stud = new Student();

                        object fnameByemail = reader[nameof(Student.FirstName)];
                        student.FirstName = Convert.ToString(fnameByemail);

                        object mnameByemail = reader[nameof(Student.MiddleName)];
                        student.MiddleName = Convert.ToString(mnameByemail);

                        object lnameByemail = reader[nameof(Student.LastName)];
                        student.LastName = Convert.ToString(lnameByemail);

                        object programByemail = reader[nameof(Student.Program)];
                        student.Program = Convert.ToString(fnameByemail);

                    }
                }

                    return command.ExecuteNonQuery();
                
            }
        }


	}
}