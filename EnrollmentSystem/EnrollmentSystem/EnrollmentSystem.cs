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

		public void RefreshPage()
		{
			FillCourseListView();
			FillStudentLoadListView();
		}

		public void FillCourseListView()
		{
			lv_course.Items.Clear();
			foreach (Course c in Course.GetAllCourseWithNoPreReq())
			{
				//we don't know if the course is passed or not
				bool pass = false;
				foreach(Course cpass in loggedInAcct.GetAllCoursePassed())
				{
					//see if course is already passed
					if(c.CourseId == cpass.CourseId)
					{
						pass = true;
					}
				}
				if (!pass) //if the course is not yet passed, then show it on the available list of course
				{
					string[] courseInfo = new string[] { c.CourseCode, c.CourseTitle, Convert.ToString(c.Unit), Convert.ToString(c.CourseId) };
					ListViewItem course = new ListViewItem(courseInfo);
					lv_course.Items.Add(course);
				}
			}
		}

		public void FillStudentLoadListView()
		{
			lv_load.Items.Clear();
			foreach (Course c in loggedInAcct.StudAcct.CourseLoad)
			{
				string[] courseInfo = new string[] { c.CourseCode, c.CourseTitle, Convert.ToString(c.Unit), c.Section.SectionName };
				ListViewItem course = new ListViewItem(courseInfo);
				lv_load.Items.Add(course);
			}
		}

		private void btn_addCourse_Click(object sender, EventArgs e)
		{
			if (lv_course.SelectedItems.Count != 1)
			{
				MessageBox.Show("Select Course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//Get CourseId from the lv_course
			ListViewItem item = lv_course.SelectedItems[0];
			int courseId = Convert.ToInt32(item.SubItems[3].Text);
			loggedInAcct.AddCourseLoad(courseId);
			RefreshPage();
			
		}
	}
}
