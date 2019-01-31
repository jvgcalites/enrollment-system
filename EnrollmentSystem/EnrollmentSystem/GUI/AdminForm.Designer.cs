namespace EnrollmentSystem
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PB_RemoveCourse = new System.Windows.Forms.Button();
            this.DG_CurrentLoad = new System.Windows.Forms.DataGridView();
            this.SB_StudNum = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblStudNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_StudNum = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DG_Courses = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PB_SearchSec = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Course = new System.Windows.Forms.TextBox();
            this.PB_Assign = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DG_Sections = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_CurrentLoad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Courses)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Sections)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PB_RemoveCourse);
            this.groupBox1.Controls.Add(this.DG_CurrentLoad);
            this.groupBox1.Location = new System.Drawing.Point(496, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Load";
            // 
            // PB_RemoveCourse
            // 
            this.PB_RemoveCourse.Location = new System.Drawing.Point(497, 30);
            this.PB_RemoveCourse.Name = "PB_RemoveCourse";
            this.PB_RemoveCourse.Size = new System.Drawing.Size(75, 23);
            this.PB_RemoveCourse.TabIndex = 1;
            this.PB_RemoveCourse.Text = "Remove";
            this.PB_RemoveCourse.UseVisualStyleBackColor = true;
            // 
            // DG_CurrentLoad
            // 
            this.DG_CurrentLoad.AllowUserToAddRows = false;
            this.DG_CurrentLoad.AllowUserToDeleteRows = false;
            this.DG_CurrentLoad.AllowUserToOrderColumns = true;
            this.DG_CurrentLoad.AllowUserToResizeColumns = false;
            this.DG_CurrentLoad.AllowUserToResizeRows = false;
            this.DG_CurrentLoad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_CurrentLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_CurrentLoad.Location = new System.Drawing.Point(16, 30);
            this.DG_CurrentLoad.Name = "DG_CurrentLoad";
            this.DG_CurrentLoad.ReadOnly = true;
            this.DG_CurrentLoad.RowHeadersVisible = false;
            this.DG_CurrentLoad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_CurrentLoad.Size = new System.Drawing.Size(462, 214);
            this.DG_CurrentLoad.TabIndex = 0;
            this.DG_CurrentLoad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CurrentLoad_CellClick);
            // 
            // SB_StudNum
            // 
            this.SB_StudNum.Location = new System.Drawing.Point(403, 13);
            this.SB_StudNum.Name = "SB_StudNum";
            this.SB_StudNum.Size = new System.Drawing.Size(75, 23);
            this.SB_StudNum.TabIndex = 1;
            this.SB_StudNum.Text = "Search";
            this.SB_StudNum.UseVisualStyleBackColor = true;
            this.SB_StudNum.Click += new System.EventHandler(this.SB_StudNum_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblYear);
            this.groupBox2.Controls.Add(this.lblProgram);
            this.groupBox2.Controls.Add(this.lblStudNum);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(398, 55);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 16);
            this.lblYear.TabIndex = 10;
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(398, 25);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(0, 16);
            this.lblProgram.TabIndex = 9;
            // 
            // lblStudNum
            // 
            this.lblStudNum.AutoSize = true;
            this.lblStudNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudNum.Location = new System.Drawing.Point(123, 55);
            this.lblStudNum.Name = "lblStudNum";
            this.lblStudNum.Size = new System.Drawing.Size(0, 16);
            this.lblStudNum.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(64, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Program";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Number";
            // 
            // TB_StudNum
            // 
            this.TB_StudNum.Location = new System.Drawing.Point(122, 15);
            this.TB_StudNum.Name = "TB_StudNum";
            this.TB_StudNum.Size = new System.Drawing.Size(264, 20);
            this.TB_StudNum.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.DG_Courses);
            this.groupBox3.Location = new System.Drawing.Point(12, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 375);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Courses";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DG_Courses
            // 
            this.DG_Courses.AllowUserToAddRows = false;
            this.DG_Courses.AllowUserToDeleteRows = false;
            this.DG_Courses.AllowUserToResizeColumns = false;
            this.DG_Courses.AllowUserToResizeRows = false;
            this.DG_Courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Courses.Location = new System.Drawing.Point(15, 25);
            this.DG_Courses.Name = "DG_Courses";
            this.DG_Courses.ReadOnly = true;
            this.DG_Courses.RowHeadersVisible = false;
            this.DG_Courses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Courses.Size = new System.Drawing.Size(451, 315);
            this.DG_Courses.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PB_SearchSec);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.TB_Course);
            this.groupBox4.Controls.Add(this.PB_Assign);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.DG_Sections);
            this.groupBox4.Location = new System.Drawing.Point(497, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(586, 269);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sections";
            // 
            // PB_SearchSec
            // 
            this.PB_SearchSec.Location = new System.Drawing.Point(298, 23);
            this.PB_SearchSec.Name = "PB_SearchSec";
            this.PB_SearchSec.Size = new System.Drawing.Size(75, 23);
            this.PB_SearchSec.TabIndex = 5;
            this.PB_SearchSec.Text = "Search";
            this.PB_SearchSec.UseVisualStyleBackColor = true;
            this.PB_SearchSec.Click += new System.EventHandler(this.PB_SearchSec_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Course";
            // 
            // TB_Course
            // 
            this.TB_Course.Location = new System.Drawing.Point(59, 25);
            this.TB_Course.Name = "TB_Course";
            this.TB_Course.Size = new System.Drawing.Size(233, 20);
            this.TB_Course.TabIndex = 3;
            // 
            // PB_Assign
            // 
            this.PB_Assign.Location = new System.Drawing.Point(496, 84);
            this.PB_Assign.Name = "PB_Assign";
            this.PB_Assign.Size = new System.Drawing.Size(75, 23);
            this.PB_Assign.TabIndex = 2;
            this.PB_Assign.Text = "Assign";
            this.PB_Assign.UseVisualStyleBackColor = true;
            this.PB_Assign.Click += new System.EventHandler(this.PB_Assign_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Available Sections for ";
            // 
            // DG_Sections
            // 
            this.DG_Sections.AllowUserToAddRows = false;
            this.DG_Sections.AllowUserToDeleteRows = false;
            this.DG_Sections.AllowUserToOrderColumns = true;
            this.DG_Sections.AllowUserToResizeColumns = false;
            this.DG_Sections.AllowUserToResizeRows = false;
            this.DG_Sections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Sections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Sections.Location = new System.Drawing.Point(15, 84);
            this.DG_Sections.Name = "DG_Sections";
            this.DG_Sections.RowHeadersVisible = false;
            this.DG_Sections.Size = new System.Drawing.Size(462, 167);
            this.DG_Sections.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 622);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.SB_StudNum);
            this.Controls.Add(this.TB_StudNum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_CurrentLoad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Courses)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Sections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DG_CurrentLoad;
        private System.Windows.Forms.Button SB_StudNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_StudNum;
        private System.Windows.Forms.Button PB_RemoveCourse;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblStudNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DG_Courses;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button PB_SearchSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Course;
        private System.Windows.Forms.Button PB_Assign;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DG_Sections;
    }
}