namespace EnrollmentSystem
{
	partial class EnrollmentSystem
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
			this.lv_load = new System.Windows.Forms.ListView();
			this.colCourseCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colCourseTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colRemove = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_removeSection = new System.Windows.Forms.Button();
			this.btn_removeCourse = new System.Windows.Forms.Button();
			this.lbl_studName = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_addCourse = new System.Windows.Forms.Button();
			this.lv_course = new System.Windows.Forms.ListView();
			this.col_CourseCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_CourseTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_Unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_CourseId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lv_sched = new System.Windows.Forms.ListView();
			this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colTues = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colWed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colThurs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btn_addSection = new System.Windows.Forms.Button();
			this.lv_section = new System.Windows.Forms.ListView();
			this.colSec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// lv_load
			// 
			this.lv_load.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCourseCode,
            this.colCourseTitle,
            this.colUnit,
            this.colSection,
            this.colRemove});
			this.lv_load.GridLines = true;
			this.lv_load.Location = new System.Drawing.Point(18, 28);
			this.lv_load.Name = "lv_load";
			this.lv_load.Size = new System.Drawing.Size(460, 228);
			this.lv_load.TabIndex = 0;
			this.lv_load.UseCompatibleStateImageBehavior = false;
			this.lv_load.View = System.Windows.Forms.View.Details;
			// 
			// colCourseCode
			// 
			this.colCourseCode.Text = "CourseCode";
			this.colCourseCode.Width = 75;
			// 
			// colCourseTitle
			// 
			this.colCourseTitle.Text = "CourseTitle";
			this.colCourseTitle.Width = 226;
			// 
			// colUnit
			// 
			this.colUnit.Text = "Unit";
			this.colUnit.Width = 45;
			// 
			// colSection
			// 
			this.colSection.Text = "Section";
			this.colSection.Width = 58;
			// 
			// colRemove
			// 
			this.colRemove.Text = "Remove";
			this.colRemove.Width = 98;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_removeSection);
			this.groupBox1.Controls.Add(this.btn_removeCourse);
			this.groupBox1.Controls.Add(this.lv_load);
			this.groupBox1.Location = new System.Drawing.Point(442, 57);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(484, 304);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Current Load";
			// 
			// btn_removeSection
			// 
			this.btn_removeSection.Location = new System.Drawing.Point(370, 263);
			this.btn_removeSection.Name = "btn_removeSection";
			this.btn_removeSection.Size = new System.Drawing.Size(99, 23);
			this.btn_removeSection.TabIndex = 5;
			this.btn_removeSection.Text = "Remove Section";
			this.btn_removeSection.UseVisualStyleBackColor = true;
			// 
			// btn_removeCourse
			// 
			this.btn_removeCourse.Location = new System.Drawing.Point(18, 262);
			this.btn_removeCourse.Name = "btn_removeCourse";
			this.btn_removeCourse.Size = new System.Drawing.Size(97, 23);
			this.btn_removeCourse.TabIndex = 4;
			this.btn_removeCourse.Text = "Remove Course";
			this.btn_removeCourse.UseVisualStyleBackColor = true;
			// 
			// lbl_studName
			// 
			this.lbl_studName.AutoSize = true;
			this.lbl_studName.Location = new System.Drawing.Point(12, 9);
			this.lbl_studName.Name = "lbl_studName";
			this.lbl_studName.Size = new System.Drawing.Size(55, 13);
			this.lbl_studName.TabIndex = 0;
			this.lbl_studName.Text = "Welcome ";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_addCourse);
			this.groupBox2.Controls.Add(this.lv_course);
			this.groupBox2.Location = new System.Drawing.Point(36, 57);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(400, 304);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Course";
			// 
			// btn_addCourse
			// 
			this.btn_addCourse.Location = new System.Drawing.Point(18, 262);
			this.btn_addCourse.Name = "btn_addCourse";
			this.btn_addCourse.Size = new System.Drawing.Size(75, 23);
			this.btn_addCourse.TabIndex = 5;
			this.btn_addCourse.Text = "Add Course";
			this.btn_addCourse.UseVisualStyleBackColor = true;
			// 
			// lv_course
			// 
			this.lv_course.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_CourseCode,
            this.col_CourseTitle,
            this.col_Unit,
            this.col_CourseId});
			this.lv_course.GridLines = true;
			this.lv_course.Location = new System.Drawing.Point(18, 28);
			this.lv_course.Name = "lv_course";
			this.lv_course.Size = new System.Drawing.Size(366, 228);
			this.lv_course.TabIndex = 0;
			this.lv_course.UseCompatibleStateImageBehavior = false;
			this.lv_course.View = System.Windows.Forms.View.Details;
			// 
			// col_CourseCode
			// 
			this.col_CourseCode.Text = "CourseCode";
			this.col_CourseCode.Width = 75;
			// 
			// col_CourseTitle
			// 
			this.col_CourseTitle.Text = "CourseTitle";
			this.col_CourseTitle.Width = 237;
			// 
			// col_Unit
			// 
			this.col_Unit.Text = "Unit";
			this.col_Unit.Width = 50;
			// 
			// col_CourseId
			// 
			this.col_CourseId.Text = "";
			this.col_CourseId.Width = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lv_sched);
			this.groupBox3.Location = new System.Drawing.Point(36, 367);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(521, 304);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Schedule";
			// 
			// lv_sched
			// 
			this.lv_sched.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime,
            this.colMon,
            this.colTues,
            this.colWed,
            this.colThurs,
            this.colFri,
            this.colSat,
            this.colSun});
			this.lv_sched.GridLines = true;
			this.lv_sched.Location = new System.Drawing.Point(18, 28);
			this.lv_sched.Name = "lv_sched";
			this.lv_sched.Size = new System.Drawing.Size(486, 228);
			this.lv_sched.TabIndex = 0;
			this.lv_sched.UseCompatibleStateImageBehavior = false;
			this.lv_sched.View = System.Windows.Forms.View.Details;
			// 
			// colTime
			// 
			this.colTime.Text = "Time";
			// 
			// colMon
			// 
			this.colMon.Text = "Monday";
			// 
			// colTues
			// 
			this.colTues.Text = "Tuesday";
			// 
			// colWed
			// 
			this.colWed.Text = "Wednesday";
			// 
			// colThurs
			// 
			this.colThurs.Text = "Thursday";
			// 
			// colFri
			// 
			this.colFri.Text = "Friday";
			// 
			// colSat
			// 
			this.colSat.Text = "Saturday";
			// 
			// colSun
			// 
			this.colSun.Text = "Sunday";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btn_addSection);
			this.groupBox4.Controls.Add(this.lv_section);
			this.groupBox4.Location = new System.Drawing.Point(563, 367);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(363, 304);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Section";
			// 
			// btn_addSection
			// 
			this.btn_addSection.Location = new System.Drawing.Point(18, 262);
			this.btn_addSection.Name = "btn_addSection";
			this.btn_addSection.Size = new System.Drawing.Size(75, 23);
			this.btn_addSection.TabIndex = 5;
			this.btn_addSection.Text = "Add Section";
			this.btn_addSection.UseVisualStyleBackColor = true;
			// 
			// lv_section
			// 
			this.lv_section.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSec,
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.lv_section.GridLines = true;
			this.lv_section.Location = new System.Drawing.Point(18, 28);
			this.lv_section.Name = "lv_section";
			this.lv_section.Size = new System.Drawing.Size(328, 228);
			this.lv_section.TabIndex = 0;
			this.lv_section.UseCompatibleStateImageBehavior = false;
			this.lv_section.View = System.Windows.Forms.View.Details;
			// 
			// colSec
			// 
			this.colSec.Text = "Section";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Day";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Time";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "ReserveSlots";
			this.columnHeader6.Width = 84;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "MaxSlots";
			this.columnHeader7.Width = 86;
			// 
			// EnrollmentSystem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(943, 682);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.lbl_studName);
			this.Controls.Add(this.groupBox1);
			this.Name = "EnrollmentSystem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EnrollmentSystem";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lv_load;
		private System.Windows.Forms.ColumnHeader colCourseCode;
		private System.Windows.Forms.ColumnHeader colCourseTitle;
		private System.Windows.Forms.ColumnHeader colUnit;
		private System.Windows.Forms.ColumnHeader colSection;
		private System.Windows.Forms.ColumnHeader colRemove;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_removeSection;
		private System.Windows.Forms.Button btn_removeCourse;
		private System.Windows.Forms.Label lbl_studName;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btn_addCourse;
		private System.Windows.Forms.ListView lv_course;
		private System.Windows.Forms.ColumnHeader col_CourseCode;
		private System.Windows.Forms.ColumnHeader col_CourseTitle;
		private System.Windows.Forms.ColumnHeader col_Unit;
		private System.Windows.Forms.ColumnHeader col_CourseId;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListView lv_sched;
		private System.Windows.Forms.ColumnHeader colTime;
		private System.Windows.Forms.ColumnHeader colMon;
		private System.Windows.Forms.ColumnHeader colTues;
		private System.Windows.Forms.ColumnHeader colWed;
		private System.Windows.Forms.ColumnHeader colThurs;
		private System.Windows.Forms.ColumnHeader colFri;
		private System.Windows.Forms.ColumnHeader colSat;
		private System.Windows.Forms.ColumnHeader colSun;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btn_addSection;
		private System.Windows.Forms.ListView lv_section;
		private System.Windows.Forms.ColumnHeader colSec;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
	}
}

