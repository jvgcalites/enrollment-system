namespace EnrollmentSystem
{
    partial class ErrorLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorLogin));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_email = new System.Windows.Forms.Label();
            this.button_okay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EnrollmentSystem.Properties.Resources.errorSymbol;
            this.pictureBox1.Location = new System.Drawing.Point(155, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Transparent;
            this.label_email.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.Maroon;
            this.label_email.Location = new System.Drawing.Point(48, 187);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(358, 28);
            this.label_email.TabIndex = 11;
            this.label_email.Text = "Invalid email address or password.";
            // 
            // button_okay
            // 
            this.button_okay.BackColor = System.Drawing.Color.Moccasin;
            this.button_okay.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_okay.FlatAppearance.BorderSize = 3;
            this.button_okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_okay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_okay.ForeColor = System.Drawing.Color.Maroon;
            this.button_okay.Location = new System.Drawing.Point(124, 258);
            this.button_okay.Margin = new System.Windows.Forms.Padding(4);
            this.button_okay.Name = "button_okay";
            this.button_okay.Size = new System.Drawing.Size(198, 48);
            this.button_okay.TabIndex = 15;
            this.button_okay.Text = "Okay";
            this.button_okay.UseVisualStyleBackColor = false;
            this.button_okay.Click += new System.EventHandler(this.button_okay_Click);
            // 
            // ErrorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnrollmentSystem.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 340);
            this.Controls.Add(this.button_okay);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ErrorLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAPÚA ENROLLMENT SYSTEM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Button button_okay;
    }
}