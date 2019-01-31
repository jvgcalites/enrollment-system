using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void SB_StudNum_Click(object sender, EventArgs e)
        {
            if(TB_StudNum.Text.Length != 10 )
            {
                MessageBox.Show("Invalid Student Number length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                searchStudent();
        }

        public void searchStudent()
        {
            SqlConnection connection = new SqlConnection(@"Server=LAPTOP-97VVC078; Database=EnrollmentSystem; Trusted_Connection=True;");
            SqlDataAdapter adapter = new SqlDataAdapter("getStudentbyStudentNum", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@sNum", int.Parse(TB_StudNum.Text));
            DataTable student = new DataTable();
            adapter.Fill(student);
            connection.Close();
            if(student.Rows.Count > 0)
            {
                fillData(student);
            }
            else
            {
                MessageBox.Show("No records found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void fillData(DataTable stud)
        {
            lblName.Text = (string)stud.Rows[0][0];
            lblProgram.Text = (string)stud.Rows[0][1];
            lblStudNum.Text = stud.Rows[0][2].ToString();
            lblYear.Text = stud.Rows[0][3].ToString();

            SqlConnection connection = new SqlConnection(@"Server=LAPTOP-97VVC078; Database=EnrollmentSystem; Trusted_Connection=True;");
            SqlDataAdapter adapter = new SqlDataAdapter("GetAvailableCourses", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@sNum", int.Parse(TB_StudNum.Text));
            DataTable student = new DataTable();
            adapter.Fill(student);
            DG_Courses.DataSource = student;

            SqlDataAdapter adapter2 = new SqlDataAdapter("GetCurrentLoad", connection);
            adapter2.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter2.SelectCommand.Parameters.AddWithValue("@studID", int.Parse(stud.Rows[0][4].ToString()));
            DataTable currentLoad = new DataTable();
            adapter2.Fill(currentLoad);
            DG_CurrentLoad.DataSource = currentLoad;
            connection.Close();


        }

        private void PB_Assign_Click(object sender, EventArgs e)
        {

        }

        private void DG_CurrentLoad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = DG_CurrentLoad.CurrentCell.RowIndex;
            fillSections(DG_CurrentLoad.Rows[rowindex].Cells[0].Value.ToString());
            
        }

        public void fillSections(string CN)
        {
            
            SqlConnection connection = new SqlConnection(@"Server=LAPTOP-97VVC078; Database=EnrollmentSystem; Trusted_Connection=True;");
            SqlDataAdapter adapter = new SqlDataAdapter("GetCourseID", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@courseName", CN);
            DataTable courseID = new DataTable();
            adapter.Fill(courseID);

            SqlDataAdapter adapter2 = new SqlDataAdapter("GetAvailableSections", connection);
            adapter2.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter2.SelectCommand.Parameters.AddWithValue("@courseID", int.Parse(courseID.Rows[0][0].ToString()));
            DataTable sections = new DataTable();
            adapter2.Fill(sections);
            DG_Sections.DataSource = sections;
            connection.Close();
        }

        private void PB_SearchSec_Click(object sender, EventArgs e)
        {
            fillSections(TB_Course.Text);
        }
    }
}
