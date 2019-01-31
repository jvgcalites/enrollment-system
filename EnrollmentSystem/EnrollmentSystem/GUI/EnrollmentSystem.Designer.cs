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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollmentSystem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_totalUnits = new System.Windows.Forms.Label();
            this.dgv_load = new System.Windows.Forms.DataGridView();
            this.courseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.colDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSecTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReserveSlots = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaxSlots = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSecId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_logOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_totalUnits);
            this.groupBox1.Controls.Add(this.dgv_load);
            this.groupBox1.Controls.Add(this.btn_removeSection);
            this.groupBox1.Controls.Add(this.btn_removeCourse);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(589, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(645, 374);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Load";
            // 
            // lbl_totalUnits
            // 
            this.lbl_totalUnits.AutoSize = true;
            this.lbl_totalUnits.Location = new System.Drawing.Point(181, 329);
            this.lbl_totalUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalUnits.Name = "lbl_totalUnits";
            this.lbl_totalUnits.Size = new System.Drawing.Size(81, 19);
            this.lbl_totalUnits.TabIndex = 7;
            this.lbl_totalUnits.Text = "Total Units: ";
            // 
            // dgv_load
            // 
            this.dgv_load.AllowUserToAddRows = false;
            this.dgv_load.AllowUserToDeleteRows = false;
            this.dgv_load.AllowUserToResizeColumns = false;
            this.dgv_load.AllowUserToResizeRows = false;
            this.dgv_load.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseCode,
            this.courseTitle,
            this.unit,
            this.section,
            this.remove});
            this.dgv_load.Location = new System.Drawing.Point(8, 34);
            this.dgv_load.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_load.MultiSelect = false;
            this.dgv_load.Name = "dgv_load";
            this.dgv_load.RowHeadersVisible = false;
            this.dgv_load.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_load.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_load.Size = new System.Drawing.Size(629, 281);
            this.dgv_load.TabIndex = 6;
            this.dgv_load.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_load_CellClick);
            // 
            // courseCode
            // 
            this.courseCode.HeaderText = "CourseCode";
            this.courseCode.Name = "courseCode";
            this.courseCode.Width = 75;
            // 
            // courseTitle
            // 
            this.courseTitle.HeaderText = "Course Title";
            this.courseTitle.Name = "courseTitle";
            this.courseTitle.Width = 226;
            // 
            // unit
            // 
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 45;
            // 
            // section
            // 
            this.section.HeaderText = "Section";
            this.section.Name = "section";
            this.section.ReadOnly = true;
            this.section.Width = 58;
            // 
            // remove
            // 
            this.remove.HeaderText = "Remove";
            this.remove.Name = "remove";
            this.remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.remove.Width = 60;
            // 
            // btn_removeSection
            // 
            this.btn_removeSection.BackColor = System.Drawing.Color.Moccasin;
            this.btn_removeSection.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_removeSection.FlatAppearance.BorderSize = 2;
            this.btn_removeSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeSection.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeSection.ForeColor = System.Drawing.Color.Maroon;
            this.btn_removeSection.Location = new System.Drawing.Point(482, 322);
            this.btn_removeSection.Margin = new System.Windows.Forms.Padding(4);
            this.btn_removeSection.Name = "btn_removeSection";
            this.btn_removeSection.Size = new System.Drawing.Size(155, 30);
            this.btn_removeSection.TabIndex = 5;
            this.btn_removeSection.Text = "Remove Section";
            this.btn_removeSection.UseVisualStyleBackColor = false;
            this.btn_removeSection.Click += new System.EventHandler(this.btn_removeSection_Click);
            // 
            // btn_removeCourse
            // 
            this.btn_removeCourse.BackColor = System.Drawing.Color.Moccasin;
            this.btn_removeCourse.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_removeCourse.FlatAppearance.BorderSize = 2;
            this.btn_removeCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeCourse.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeCourse.ForeColor = System.Drawing.Color.Maroon;
            this.btn_removeCourse.Location = new System.Drawing.Point(8, 322);
            this.btn_removeCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_removeCourse.Name = "btn_removeCourse";
            this.btn_removeCourse.Size = new System.Drawing.Size(152, 30);
            this.btn_removeCourse.TabIndex = 4;
            this.btn_removeCourse.Text = "Remove Course";
            this.btn_removeCourse.UseVisualStyleBackColor = false;
            this.btn_removeCourse.Click += new System.EventHandler(this.btn_removeCourse_Click);
            // 
            // lbl_studName
            // 
            this.lbl_studName.AutoSize = true;
            this.lbl_studName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_studName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_studName.Location = new System.Drawing.Point(43, 22);
            this.lbl_studName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_studName.Name = "lbl_studName";
            this.lbl_studName.Size = new System.Drawing.Size(105, 28);
            this.lbl_studName.TabIndex = 0;
            this.lbl_studName.Text = "Welcome ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_addCourse);
            this.groupBox2.Controls.Add(this.lv_course);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(533, 374);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course";
            // 
            // btn_addCourse
            // 
            this.btn_addCourse.BackColor = System.Drawing.Color.Moccasin;
            this.btn_addCourse.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_addCourse.FlatAppearance.BorderSize = 2;
            this.btn_addCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCourse.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCourse.ForeColor = System.Drawing.Color.Maroon;
            this.btn_addCourse.Location = new System.Drawing.Point(24, 322);
            this.btn_addCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addCourse.Name = "btn_addCourse";
            this.btn_addCourse.Size = new System.Drawing.Size(123, 30);
            this.btn_addCourse.TabIndex = 5;
            this.btn_addCourse.Text = "Add Course";
            this.btn_addCourse.UseVisualStyleBackColor = false;
            this.btn_addCourse.Click += new System.EventHandler(this.btn_addCourse_Click);
            // 
            // lv_course
            // 
            this.lv_course.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_CourseCode,
            this.col_CourseTitle,
            this.col_Unit,
            this.col_CourseId});
            this.lv_course.FullRowSelect = true;
            this.lv_course.GridLines = true;
            this.lv_course.Location = new System.Drawing.Point(24, 34);
            this.lv_course.Margin = new System.Windows.Forms.Padding(4);
            this.lv_course.Name = "lv_course";
            this.lv_course.Size = new System.Drawing.Size(487, 280);
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
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lv_sched);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(48, 452);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(695, 374);
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
            this.lv_sched.Location = new System.Drawing.Point(24, 34);
            this.lv_sched.Margin = new System.Windows.Forms.Padding(4);
            this.lv_sched.Name = "lv_sched";
            this.lv_sched.Size = new System.Drawing.Size(647, 280);
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
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btn_addSection);
            this.groupBox4.Controls.Add(this.lv_section);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(751, 452);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(484, 374);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Section";
            // 
            // btn_addSection
            // 
            this.btn_addSection.BackColor = System.Drawing.Color.Moccasin;
            this.btn_addSection.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_addSection.FlatAppearance.BorderSize = 2;
            this.btn_addSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addSection.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addSection.ForeColor = System.Drawing.Color.Maroon;
            this.btn_addSection.Location = new System.Drawing.Point(39, 322);
            this.btn_addSection.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addSection.Name = "btn_addSection";
            this.btn_addSection.Size = new System.Drawing.Size(123, 30);
            this.btn_addSection.TabIndex = 5;
            this.btn_addSection.Text = "Add Section";
            this.btn_addSection.UseVisualStyleBackColor = false;
            this.btn_addSection.Click += new System.EventHandler(this.btn_addSection_Click);
            // 
            // lv_section
            // 
            this.lv_section.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSec,
            this.colDay,
            this.colSecTime,
            this.colReserveSlots,
            this.colMaxSlots,
            this.colSecId});
            this.lv_section.FullRowSelect = true;
            this.lv_section.GridLines = true;
            this.lv_section.Location = new System.Drawing.Point(24, 34);
            this.lv_section.Margin = new System.Windows.Forms.Padding(4);
            this.lv_section.Name = "lv_section";
            this.lv_section.Size = new System.Drawing.Size(436, 280);
            this.lv_section.TabIndex = 0;
            this.lv_section.UseCompatibleStateImageBehavior = false;
            this.lv_section.View = System.Windows.Forms.View.Details;
            // 
            // colSec
            // 
            this.colSec.Text = "Section";
            // 
            // colDay
            // 
            this.colDay.Text = "Day";
            // 
            // colSecTime
            // 
            this.colSecTime.Text = "Time";
            // 
            // colReserveSlots
            // 
            this.colReserveSlots.Text = "ReserveSlots";
            this.colReserveSlots.Width = 84;
            // 
            // colMaxSlots
            // 
            this.colMaxSlots.Text = "MaxSlots";
            // 
            // colSecId
            // 
            this.colSecId.Width = 0;
            // 
            // btn_logOut
            // 
            this.btn_logOut.BackColor = System.Drawing.Color.Moccasin;
            this.btn_logOut.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_logOut.FlatAppearance.BorderSize = 2;
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOut.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logOut.ForeColor = System.Drawing.Color.Maroon;
            this.btn_logOut.Location = new System.Drawing.Point(1103, 19);
            this.btn_logOut.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(123, 31);
            this.btn_logOut.TabIndex = 8;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = false;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // EnrollmentSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnrollmentSystem.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1257, 839);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_studName);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EnrollmentSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAPÚA ENROLLMENT SYSTEM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
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
		private System.Windows.Forms.ColumnHeader colDay;
		private System.Windows.Forms.ColumnHeader colSecTime;
		private System.Windows.Forms.ColumnHeader colReserveSlots;
		private System.Windows.Forms.ColumnHeader colMaxSlots;
		private System.Windows.Forms.ColumnHeader colSecId;
		private System.Windows.Forms.DataGridView dgv_load;
		private System.Windows.Forms.Label lbl_totalUnits;
		private System.Windows.Forms.Button btn_logOut;
		private System.Windows.Forms.DataGridViewTextBoxColumn courseCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn courseTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn unit;
		private System.Windows.Forms.DataGridViewTextBoxColumn section;
		private System.Windows.Forms.DataGridViewCheckBoxColumn remove;
	}
}

