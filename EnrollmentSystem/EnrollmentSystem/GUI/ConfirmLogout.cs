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
    public partial class ConfirmLogout : Form
    {
        public ConfirmLogout()
        {
            InitializeComponent();
        }

        private void button_yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void button_no_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
