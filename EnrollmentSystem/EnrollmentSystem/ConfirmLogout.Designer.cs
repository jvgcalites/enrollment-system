namespace EnrollmentSystem
{
    partial class ConfirmLogout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmLogout));
            this.button_yes = new System.Windows.Forms.Button();
            this.label_email = new System.Windows.Forms.Label();
            this.button_no = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_yes
            // 
            this.button_yes.BackColor = System.Drawing.Color.Moccasin;
            this.button_yes.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_yes.FlatAppearance.BorderSize = 3;
            this.button_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_yes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_yes.ForeColor = System.Drawing.Color.Maroon;
            this.button_yes.Location = new System.Drawing.Point(57, 253);
            this.button_yes.Margin = new System.Windows.Forms.Padding(4);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(150, 48);
            this.button_yes.TabIndex = 20;
            this.button_yes.Text = "Yes";
            this.button_yes.UseVisualStyleBackColor = false;
            this.button_yes.Click += new System.EventHandler(this.button_yes_Click);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Transparent;
            this.label_email.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.Maroon;
            this.label_email.Location = new System.Drawing.Point(52, 163);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(344, 28);
            this.label_email.TabIndex = 19;
            this.label_email.Text = "Are you sure you want to logout?";
            // 
            // button_no
            // 
            this.button_no.BackColor = System.Drawing.Color.Moccasin;
            this.button_no.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_no.FlatAppearance.BorderSize = 3;
            this.button_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_no.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_no.ForeColor = System.Drawing.Color.Maroon;
            this.button_no.Location = new System.Drawing.Point(246, 253);
            this.button_no.Margin = new System.Windows.Forms.Padding(4);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(150, 48);
            this.button_no.TabIndex = 21;
            this.button_no.Text = "No";
            this.button_no.UseVisualStyleBackColor = false;
            this.button_no.Click += new System.EventHandler(this.button_no_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EnrollmentSystem.Properties.Resources.questionSymbol;
            this.pictureBox1.Location = new System.Drawing.Point(159, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ConfirmLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnrollmentSystem.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 340);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_no);
            this.Controls.Add(this.button_yes);
            this.Controls.Add(this.label_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmLogout";
            this.Text = "MAPÚA ENROLLMENT SYSTEM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_yes;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Button button_no;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}