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
			FillStudentLoadDataGrid();

			//Welcome message
			lbl_studName.Text = $"WELCOME {loggedInAcct.StudAcct.FirstName} {loggedInAcct.StudAcct.MiddleName} {loggedInAcct.StudAcct.LastName}";
		}

		public void FillCourseListView()
		{
			lv_course.Items.Clear();
			//get all possible course to take
			foreach (Course c in Course.GetAllCourseWithNoPreReq())
			{
				//we don't know if the course is passed or not
				bool pass = false;
				//get all course taken
				foreach (Course cpass in loggedInAcct.GetAllCoursePassed())
				{
					//see if possible course is already passed
					if(c.CourseId == cpass.CourseId)
					{
						pass = true;
					}
				}
				//get all course in student load
				foreach (Course cload in loggedInAcct.GetStudentLoad())
				{
					//see if possible course is already in student load
					if (c.CourseId == cload.CourseId)
					{
						pass = true;
					}
				}
				//if course is not taken and not in course load, view it on available courseload
				if (!pass)
				{
					string[] courseInfo = new string[] { c.CourseCode, c.CourseTitle, Convert.ToString(c.Unit), Convert.ToString(c.CourseId) };
					ListViewItem course = new ListViewItem(courseInfo);
					lv_course.Items.Add(course);
				}
			}
		}

		public void FillStudentLoadDataGrid() 
		{
			dgv_load.Rows.Clear();
			dgv_load.Refresh();
			foreach (Course c in loggedInAcct.GetStudentLoad())
			{
				string[] loadInfo = new string[] { c.CourseCode, c.CourseTitle, Convert.ToString(c.Unit), c.Section.SectionName};
				dgv_load.Rows.Add(loadInfo);
			}
		}

		public void FillSectionListView(string courseCode)
		{
			lv_section.Items.Clear();
			foreach(Section s in Section.GetAllSection(courseCode))
			{
				string[] sectionInfo = new string[] { s.SectionName, s.Day, s.Time, Convert.ToString(s.AvailableSlot), Convert.ToString(s.Capacity), Convert.ToString(s.SectionId) };
				ListViewItem section = new ListViewItem(sectionInfo);
				lv_section.Items.Add(section);
			}
		}

		//function : adds course to load 
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

			//refresh tables
			FillStudentLoadDataGrid();
			FillCourseListView();
		}

		//function: : shows available section of a course in load
		private void dgv_load_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//clear section list view first
			lv_section.Items.Clear();
			
			//view all sections with matching CourseCode
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dgv_load.Rows[e.RowIndex];
				string courseCode = row.Cells["CourseCode"].Value.ToString();
				FillSectionListView(courseCode);
			}
		}

		private void btn_addSection_Click(object sender, EventArgs e)
		{
			if (lv_section.SelectedItems.Count != 1)
			{
				MessageBox.Show("Select Course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//getting the CourseCode of the selected row in dgv_load
			int rowIndex = dgv_load.CurrentRow.Index;
			DataGridViewRow row = this.dgv_load.Rows[rowIndex];
			string courseCode = row.Cells["CourseCode"].Value.ToString();

			//Get SectionId from the lv_section
			ListViewItem item = lv_section.SelectedItems[0];
			int sectionId = Convert.ToInt32(item.SubItems[5].Text);

			loggedInAcct.AddSectionToCourseLoad(courseCode, sectionId);

			//refresh tables
			FillStudentLoadDataGrid();
			FillCourseListView();
		}
	}
}
