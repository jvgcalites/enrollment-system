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
		Student loggedInStudent;

		public EnrollmentSystem()
		{
			InitializeComponent();
			FillCourseListView();
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
	}
}
