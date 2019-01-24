using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
	public partial class EnrollmentSystem : Form
	{
		Account loggedInAcct;

		public EnrollmentSystem(Student account)
		{
			InitializeComponent();

			loggedInAcct = new Account();

			//fill in all the information
			loggedInAcct.StudAcct = account;
			loggedInAcct.StudAcct.CourseLoad = loggedInAcct.GetStudentLoad(); //adds course load of the student

			//show it to tables
			FillCourseListView();
			FillStudentLoadListView();

			//Welcome message
			lbl_studName.Text = $"WELCOME {loggedInAcct.StudAcct.FirstName} {loggedInAcct.StudAcct.MiddleName} {loggedInAcct.StudAcct.LastName}";
		}

		public void FillCourseListView()
		{
			foreach (Course c in Course.GetAllCourseOfStudent())
			{
				string[] courseInfo = new string[] {c.CourseCode, c.CourseTitle, Convert.ToString(c.Unit), Convert.ToString(c.CourseId) };
				ListViewItem course= new ListViewItem(courseInfo);
				lv_course.Items.Add(course);
			}
		}

		public void FillStudentLoadListView()
		{
			foreach (Course c in loggedInAcct.StudAcct.CourseLoad)
			{
				string[] courseInfo = new string[] { c.CourseCode, c.CourseTitle, Convert.ToString(c.Unit), c.Section.SectionName };
				ListViewItem course = new ListViewItem(courseInfo);
				lv_load.Items.Add(course);
			}
		}
	}
}
