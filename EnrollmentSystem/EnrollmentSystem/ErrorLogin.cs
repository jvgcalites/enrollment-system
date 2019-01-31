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
    public partial class ErrorLogin : Form
    {
        public ErrorLogin()
        {
            InitializeComponent();
        }

        private void button_okay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
